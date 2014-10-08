using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private const string EXCHANGE_NAME = "directexchange1";
        private const string M_HostName = "localhost";
        private const string QueueName = "maoyaQueue2";
        private const string RoutingKey = "maoyaRK";
        private string hosturl = "http://localhost:15672";
        private string username;
        private string password;
        private string exchangesApi;
        private string queuesApi;
        private List<ExchangeEntity> userExchanges;
        private List<QueueEntity> queues;
        private ConnectionFactory factory;
        private ExchangeEntity exchange;
        private QueueEntity queue;

        public Form1()
        {
            InitializeComponent();
            InitRabbit();
        }

        private void InitRabbit()
        {
            username = txtUsername.Text.Trim();
            password = txtPwd.Text.Trim();
            hosturl = txtHostUrl.Text.Trim();
            exchangesApi = hosturl + "/api/exchanges";
            queuesApi = hosturl + "/api/queues";

            cbExchangeType.SelectedIndex = 0;
            cbDurable.SelectedIndex = 0;
            cbQueueDurable.SelectedIndex = 0;
            cbExclusive.SelectedIndex = 1;
            cbAutoDelete.SelectedIndex = 1;
            cbExchangeAutoDelete.SelectedIndex = 1;

            ShowLbUserUserExchanges(exchangesApi);
            ShowLbQueues(queuesApi);

            factory = new ConnectionFactory { HostName = M_HostName };
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitRabbit();
        }

        private void btnCheckEnv_Click(object sender, EventArgs e)
        {
            InitRabbit();
            CheckEnv(hosturl);
        }

        private void btnExchangesView_Click(object sender, EventArgs e)
        {
            ShowExchanges(exchangesApi);
        }

        private void btnQueuesView_Click(object sender, EventArgs e)
        {
            ShowAllQueues(queuesApi);
        }

        private void btnExchangesDelete_Click(object sender, EventArgs e)
        {
            DeleteExchanges(exchangesApi);
            ShowLbUserUserExchanges(exchangesApi);
        }


        private void btnQueuesDelete_Click(object sender, EventArgs e)
        {
            DeleteQueues(queuesApi);
        }

        private void btnGetApiResult_Click(object sender, EventArgs e)
        {
            try
            {
                ShowMessage(hosturl + "/api/" + txtApiName.Text.Trim());
            }
            catch
            {
                ShowSysMessage("该服务不支持");
            }
        }

        private void btnRemoveSysExchanges_Click(object sender, EventArgs e)
        {
            if (lbSysExchanges.SelectedIndex == -1)
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(lbSysExchanges.SelectedItem.ToString()))
            {
                ShowSysMessage("不可删除默认通道");
            }
            else
            {
                var selectName = lbSysExchanges.SelectedItem;
                lbSysExchanges.Items.Remove(selectName);
                lbUserExchanges.Items.Add(selectName);
                ShowLbUserUserExchanges(exchangesApi);

            }
        }

        private void btnRemoveUserExchanges_Click(object sender, EventArgs e)
        {
            lbUserExchanges.Items.Remove(lbUserExchanges.SelectedItem);
        }

        private void btnRefreshUserExchanges_Click(object sender, EventArgs e)
        {
            ShowLbUserUserExchanges(exchangesApi);
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            if (lbUserExchanges.SelectedItem == null)
            {
                return;
            }
            var exchange = userExchanges.FirstOrDefault(x => x.name == lbUserExchanges.SelectedItem.ToString());
            txtSysMessage.Clear();
            if (exchange != null)
            {
                if (exchange.message_stats == null) exchange.message_stats = new MessageStatsEntity();
                ShowSysMessage(string.Format("Name:{0},\r\nType:{1},Durable:{2},Auto_delete:{3},Internal:{4},Publish_in:{5},Publish_out：{6}\r\n",
                         exchange.name, exchange.type, exchange.durable, exchange.auto_delete, exchange.internalFlag, exchange.message_stats.publish_in, exchange.message_stats.publish_out));
            }
            else
            {
                ShowSysMessage("未发现该通道");
            }
        }

        private void btnAddExchange_Click(object sender, EventArgs e)
        {
            using (IConnection connection = factory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare(txtExchangeName.Text.Trim(), cbExchangeType.SelectedItem.ToString(), cbDurable.SelectedIndex == 0, cbExchangeAutoDelete.SelectedIndex == 0, null);
                }
            }
            ShowLbUserUserExchanges(exchangesApi);
        }

        private void btnAddQueue_Click(object sender, EventArgs e)
        {
            using (IConnection connection = factory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    channel.QueueDeclare(txtQueue.Text.Trim(),
                        cbDurable.SelectedIndex == 0,
                        cbExclusive.SelectedIndex == 0,
                        cbAutoDelete.SelectedIndex == 0,
                        null);
                }
            }
            ShowLbQueues(queuesApi);
        }

        private void btnRefreshQueue_Click(object sender, EventArgs e)
        {
            ShowLbQueues(queuesApi);
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            if (lbQueues.SelectedItem == null)
            {
                return;
            }
            var queue = queues.FirstOrDefault(x => x.name == lbQueues.SelectedItem.ToString());
            txtSysMessage.Clear();
            if (queue != null)
            {
                ShowSysMessage(string.Format(".Name:{0},\r\nState:{1},vhost:{2},Node:{3},Durable:{4},Auto_delete:{5},Memory:{6},Messages:{7},Messages_ready：{8},Messages_unacknowledged:{9},Idle_since:{10},Consumers:{11}\r\n",
                     queue.name, queue.state, queue.vhost, queue.node, queue.durable, queue.auto_delete, queue.memory, queue.messages, queue.messages_ready, queue.messages_unacknowledged, queue.idle_since, queue.consumers));
            }
            else
            {
                ShowSysMessage("未发现该队列");
            }
        }

        private void btnAddMessage_Click(object sender, EventArgs e)
        {
            if (lbUserExchanges.SelectedItem == null)
            {
                ShowSysMessage("请选择用户通道");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSelectExchange.Text))
            {
                ShowSysMessage("请选择队列");
                return;
            }
            Produce(txtSelectExchange.Text.Trim());
        }

        private void btnConsume_Click(object sender, EventArgs e)
        {
            Consume();
        }

        private void lbUserExchanges_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelectExchange.Text = lbUserExchanges.SelectedItem.ToString();
        }

        private void lbQueues_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelectQueue.Text = lbQueues.SelectedItem.ToString();
        }

        private void btnBind_Click(object sender, EventArgs e)
        {
            if (CheckBind())
            {
                using (IConnection connection = factory.CreateConnection())
                {
                    using (IModel channel = connection.CreateModel())
                    {
                        channel.QueueBind(queue.name, exchange.name, txtRoutingKey.Text);
                        ShowSysMessage(string.Format("队列{0}与通道{1}绑定成功", queue.name, exchange.name));
                    }
                }
            }
            else
            {
                ShowSysMessage("未绑定成功");
            }
        }

        private bool CheckBind()
        {
            bool checkResult = false;
            if (string.IsNullOrWhiteSpace(txtSelectExchange.Text))
            {
                ShowSysMessage("未选择通道");
            }
            else if (string.IsNullOrWhiteSpace(txtSelectQueue.Text))
            {
                ShowSysMessage("未选择队列");
            }
            else
            {
                exchange = userExchanges.FirstOrDefault(x => x.name == txtSelectExchange.Text);
                queue = queues.FirstOrDefault(x => x.name == txtSelectQueue.Text);

                if (exchange == null)
                {
                    ShowSysMessage("通道不存在");
                }

                else if (queue == null)
                {
                    ShowSysMessage("队列不存在");
                }
                else
                {
                    checkResult = true;
                }
            }

            return checkResult;

        }


        private void Consume()
        {
            using (IConnection connection = factory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    channel.QueueDeclare(QueueName, true, false, false, null);
                    channel.ExchangeDeclare(EXCHANGE_NAME, "direct");
                    channel.QueueBind(QueueName, EXCHANGE_NAME, RoutingKey);

                    txtSysMessage.Text = txtSysMessage.Text + @"
Waiting for messages";

                    var consumer = new QueueingBasicConsumer(channel);
                    //channel.BasicConsume(QueueName, true, consumer);
                    var q = channel.BasicGet(QueueName, false);
                    string w = Encoding.ASCII.GetString(q.Body);
                    //                    while (true)
                    //                    {
                    //                        var e = consumer.Queue.Dequeue();
                    //                        txtSysMessage.Text = txtSysMessage.Text + @"
                    //" + Encoding.ASCII.GetString(e.Body);
                    //                        Thread.Sleep(100);
                    //                    }
                }
            }
        }

        public void Produce(string message)
        {
            var exchange = userExchanges.FirstOrDefault(x => x.name == lbUserExchanges.SelectedItem.ToString());

            using (IConnection connection = factory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    IBasicProperties properties = channel.CreateBasicProperties();
                    properties.SetPersistent(rbMessageDurableTrue.Checked);

                    channel.ExchangeDeclare(exchange.name, exchange.type);
                    byte[] payload = Encoding.ASCII.GetBytes(message);
                    channel.BasicPublish(exchange.name, txtRoutingKey.Text.Trim(), properties, payload);

                    txtSysMessage.Text = txtSysMessage.Text + @"
Sent Message " + message;
                    Thread.Sleep(10);
                }
            }

        }

        private async Task<HttpResponseMessage> ShowHttpClientResult(string Url)
        {
            HttpClient client = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes(string.Format("{0}:{1}", username, password));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            HttpResponseMessage response = await client.GetAsync(Url);
            return response;
        }

        private async void CheckEnv(string Url)
        {
            try
            {
                var response = await ShowHttpClientResult(Url);
                txtSysMessage.Clear();
                ShowSysMessage(response.IsSuccessStatusCode ? "环境正常" : "服务器未运行");
            }
            catch
            {
                ShowSysMessage("服务器未运行");
            }
        }

        private async Task<string> ShowApiResult(string apiUrl)
        {
            var response = await ShowHttpClientResult(apiUrl);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        private async void ShowMessage(string apiUrl)
        {
            string jsonContent = await ShowApiResult(apiUrl);
            txtSysMessage.Clear();
            ShowSysMessage(jsonContent);
        }

        private async void ShowExchanges(string apiUrl)
        {
            string jsonContent = await ShowApiResult(apiUrl);
            List<ExchangeEntity> exchanges = JsonConvert.DeserializeObject<List<ExchangeEntity>>(jsonContent);
            int count = exchanges.Count;
            txtSysMessage.Clear();
            StringBuilder s = new StringBuilder();
            s.AppendLine(string.Format("Exchanges Count:{0}", count));
            s.AppendLine("NameList:");
            int index = 1;
            foreach (var exchange in exchanges)
            {
                s.AppendLine(index + ":" + exchange.name + "  ");
                index++;
            }
            s.AppendLine("");
            s.AppendLine("Detail:");
            index = 1;
            foreach (var exchange in exchanges)
            {
                if (exchange.message_stats == null) exchange.message_stats = new MessageStatsEntity();
                s.AppendLine(string.Format("{0}.Name:{1},\r\nType:{2},Durable:{3},Auto_delete:{4},Internal:{5},Publish_in:{6},Publish_out：{7}\r\n",
                    index, exchange.name, exchange.type, exchange.durable, exchange.auto_delete, exchange.internalFlag, exchange.message_stats.publish_in, exchange.message_stats.publish_out));
                index++;
            }
            ShowSysMessage(s.ToString());
        }

        private async Task<List<ExchangeEntity>> GetUserExchanges(string apiUrl)
        {
            string jsonContent = await ShowApiResult(apiUrl);
            var exchanges = JsonConvert.DeserializeObject<List<ExchangeEntity>>(jsonContent);
            var sysExchanges = (from object item in lbSysExchanges.Items select item.ToString().Trim()).ToList();
            var userExchanges = exchanges.Where(x => !sysExchanges.Contains(x.name.Trim())).ToList();
            return userExchanges;
        }

        private async void ShowLbUserUserExchanges(string apiUrl)
        {
            lbUserExchanges.Items.Clear();
            userExchanges = await GetUserExchanges(apiUrl);
            if (userExchanges != null && userExchanges.Count != 0)
            {
                foreach (var exchange in userExchanges)
                {
                    lbUserExchanges.Items.Add(exchange.name);
                }
            }
        }

        private void DeleteExchanges(string apiUrl)
        {
            var userExchanges = (from object item in lbUserExchanges.Items select item.ToString().Trim()).ToList();
            txtSysMessage.Clear();
            var s = new StringBuilder();
            if (userExchanges != null && userExchanges.Count != 0)
            {
                using (IConnection connection = factory.CreateConnection())
                {
                    using (IModel channel = connection.CreateModel())
                    {
                        foreach (var exchange in userExchanges)
                        {
                            channel.ExchangeDelete(exchange);
                            s.AppendLine("已删除通道Name：" + exchange);
                        }
                    }
                }
            }
            else
            {
                s.AppendLine("当前没有通道可删");
            }
            ShowSysMessage(s.ToString());
        }

        private async Task<List<QueueEntity>> GetQueues(string apiUrl)
        {
            string jsonContent = await ShowApiResult(apiUrl);
            queues = JsonConvert.DeserializeObject<List<QueueEntity>>(jsonContent);
            return queues;
        }

        private async void ShowAllQueues(string apiUrl)
        {
            queues = await GetQueues(apiUrl);
            int count = queues.Count;
            txtSysMessage.Clear();
            StringBuilder s = new StringBuilder();
            s.AppendLine(string.Format("Queues Count:{0}", count));
            s.AppendLine("NameList:");
            int index = 1;
            foreach (var queue in queues)
            {
                s.AppendLine(index + ":" + queue.name + "  ");
                index++;
            }
            s.AppendLine("");
            s.AppendLine("Detail:");
            index = 1;
            foreach (var queue in queues)
            {
                s.AppendLine(string.Format("{0}.Name:{1},\r\nState:{2},vhost:{3},Node:{4},Durable:{5},Auto_delete:{6},Memory:{7},Messages:{8},Messages_ready：{9},Messages_unacknowledged:{10},Idle_since:{11},Consumers:{12}\r\n",
                    index, queue.name, queue.state, queue.vhost, queue.node, queue.durable, queue.auto_delete, queue.memory, queue.messages, queue.messages_ready, queue.messages_unacknowledged, queue.idle_since, queue.consumers));
                index++;
            }
            ShowSysMessage(s.ToString());
        }

        private async void ShowLbQueues(string apiUrl)
        {
            lbQueues.Items.Clear();
            queues = await GetQueues(apiUrl);
            if (queues != null)
            {
                foreach (var queue in queues)
                {
                    lbQueues.Items.Add(queue.name);
                }
            }
        }

        private async void DeleteQueues(string apiUrl)
        {
            string jsonContent = await ShowApiResult(apiUrl);
            List<QueueEntity> queues = JsonConvert.DeserializeObject<List<QueueEntity>>(jsonContent);
            txtSysMessage.Clear();
            StringBuilder s = new StringBuilder();
            if (queues != null && queues.Count != 0)
            {
                using (IConnection connection = factory.CreateConnection())
                {
                    using (IModel channel = connection.CreateModel())
                    {
                        foreach (var queue in queues)
                        {
                            channel.QueueDelete(queue.name);
                            s.AppendLine("已删除队列Name：" + queue.name);
                        }
                    }
                }
            }
            else
            {
                s.AppendLine("当前没有队列可删");
            }
            ShowSysMessage(s.ToString());
            ShowLbQueues(queuesApi);
        }

        private void ShowSysMessage(string message)
        {
            txtSysMessage.Text = txtSysMessage.Text + "\r\n" + message;
        }























    }
}
