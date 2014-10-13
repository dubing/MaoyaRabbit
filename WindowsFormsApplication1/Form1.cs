using System.Diagnostics;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private const string M_HostName = "localhost";
        private string hosturl = "http://localhost:15672";
        private string username;
        private string password;
        private readonly string exchangesApi;
        private readonly string queuesApi;
        private readonly string bingdingsApi;
        private List<ExchangeEntity> userExchanges;
        private List<QueueEntity> queues;
        private List<BindingEntity> bindings;
        private readonly ConnectionFactory factory;
        private ExchangeEntity exchange;
        private QueueEntity queue;
        private BindingEntity binding;

        public Form1()
        {
            InitializeComponent();
            exchangesApi = hosturl + "/api/exchanges";
            queuesApi = hosturl + "/api/queues";
            bingdingsApi = hosturl + "/api/bindings";
            factory = new ConnectionFactory { HostName = M_HostName };
            InitRabbit();
        }

        private void InitRabbit()
        {
            username = txtUsername.Text.Trim();
            password = txtPwd.Text.Trim();
            hosturl = txtHostUrl.Text.Trim();


            cbExchangeType.SelectedIndex = 0;
            cbDurable.SelectedIndex = 0;
            cbQueueDurable.SelectedIndex = 0;
            cbExclusive.SelectedIndex = 1;
            cbAutoDelete.SelectedIndex = 1;
            cbExchangeAutoDelete.SelectedIndex = 1;

            ShowLbUserUserExchanges(exchangesApi);
            ShowLbQueues(queuesApi);
            ShowLbBindings(bingdingsApi);

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
            DeleteExchanges();
            ShowLbUserUserExchanges(exchangesApi);
        }


        private void btnQueuesDelete_Click(object sender, EventArgs e)
        {
            DeleteQueues(queuesApi);
            ShowLbBindings(bingdingsApi);
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
                ShowSysMessage("不可删除默认交换机");
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
            exchange = userExchanges.FirstOrDefault(x => x.name == lbUserExchanges.SelectedItem.ToString());
            txtSysMessage.Clear();
            if (exchange != null)
            {
                if (exchange.message_stats == null) exchange.message_stats = new MessageStatsEntity();
                ShowSysMessage(string.Format("Name:{0},\r\nType:{1},Durable:{2},Auto_delete:{3},Internal:{4},Publish_in:{5},Publish_out：{6}\r\n",
                         exchange.name, exchange.type, exchange.durable, exchange.auto_delete, exchange.internalFlag, exchange.message_stats.publish_in, exchange.message_stats.publish_out));
            }
            else
            {
                ShowSysMessage("未发现该交换机");
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
            ShowLbBindings(bingdingsApi);
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
            queue = queues.FirstOrDefault(x => x.name == lbQueues.SelectedItem.ToString());
            txtSysMessage.Clear();
            if (queue != null)
            {
                ShowSysMessage(string.Format("Name:{0},\r\nState:{1},vhost:{2},Node:{3},Durable:{4},Auto_delete:{5},Memory:{6},Messages:{7},Messages_ready：{8},Messages_unacknowledged:{9},Idle_since:{10},Consumers:{11}\r\n",
                     queue.name, queue.state, queue.vhost, queue.node, queue.durable, queue.auto_delete, queue.memory, queue.messages, queue.messages_ready, queue.messages_unacknowledged, queue.idle_since, queue.consumers));
            }
            else
            {
                ShowSysMessage("未发现该队列");
            }
        }

        private void btnAddMessage_Click(object sender, EventArgs e)
        {
            if (CheckBind())
            {
                Produce(txtMessage.Text.Trim());
            }
        }

        private void lbUserExchanges_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUserExchanges.SelectedItem != null)
            {
                txtSelectExchange.Text = lbUserExchanges.SelectedItem.ToString();
            }
        }

        private void lbQueues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbQueues.SelectedItem != null)
            {
                txtSelectQueue.Text = lbQueues.SelectedItem.ToString();
            }
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
                        ShowSysMessage(string.Format("队列{0}与交换机{1}绑定成功", queue.name, exchange.name));
                        ShowLbBindings(bingdingsApi);
                    }
                }
            }
            else
            {
                ShowSysMessage("未绑定成功");
            }
        }

        private void btnBindingsRefresh_Click(object sender, EventArgs e)
        {
            ShowLbBindings(bingdingsApi);
        }

        private void btnBindingDetail_Click(object sender, EventArgs e)
        {
            if (lbBindings.SelectedItem == null)
            {
                return;
            }
            string bindingContent = lbBindings.SelectedItem.ToString().Replace("默认", "");
            var attr = new Regex(@"交换机:(?<1>.*?)---队列:(?<2>.*?)---Key:(?<3>.*)");
            var mat = attr.Matches(bindingContent);
            if (mat.Count != 0)
            {
                var item = mat[0];

                binding = bindings.FirstOrDefault(x => x.source == item.Groups[1].ToString() && x.destination == item.Groups[2].ToString() && x.routing_key == item.Groups[3].ToString());
                txtSysMessage.Clear();
                if (binding != null)
                {
                    ShowSysMessage(string.Format("exchange:{0},\r\nqueue:{1},\r\nvhost:{2},\r\nrouting_key:{3},\r\ndestination_type:{4},\r\nproperties_key:{5}",
                         binding.source, binding.destination, binding.vhost, binding.routing_key, binding.destination_type, binding.properties_key));
                }
                else
                {
                    ShowSysMessage("未发现该绑定关系");
                }
            }
            else
            {
                ShowSysMessage("正则匹配失败");
            }
        }

        private void btnRemoveBind_Click(object sender, EventArgs e)
        {
            if (CheckBind())
            {
                using (IConnection connection = factory.CreateConnection())
                {
                    using (IModel channel = connection.CreateModel())
                    {
                        channel.QueueUnbind(queue.name, exchange.name, txtRoutingKey.Text, null);
                        ShowSysMessage(string.Format("队列{0}与交换机{1}解绑成功", queue.name, exchange.name));
                        ShowLbBindings(bingdingsApi);
                    }
                }
            }
            else
            {
                ShowSysMessage("未解绑成功");
            }
        }

        private void btnReceiveMessage_Click(object sender, EventArgs e)
        {
            if (CheckBind())
            {
                ReceiveMessage();
            }
        }

        private void btnConsumeMessage_Click(object sender, EventArgs e)
        {
            if (CheckBind())
            {
                Consume();
            }
        }


        private bool CheckBind()
        {
            bool checkResult = false;
            if (string.IsNullOrWhiteSpace(txtSelectExchange.Text))
            {
                ShowSysMessage("未选择交换机");
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
                    ShowSysMessage("交换机不存在");
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

        private void ReceiveMessage()
        {
            using (IConnection connection = factory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    var s = new StringBuilder();
                    s.AppendLine("Waiting for messages");
                    var q = channel.BasicGet(queue.name, rbAckTrue.Checked);
                    if (q != null)
                    {
                        string w = Encoding.ASCII.GetString(q.Body);
                        s.AppendLine(string.Format("队列{0}读取从交换机{1}读取消息{2}", queue.name, exchange.name, w));
                        ShowSysMessage(s.ToString());
                    }
                    else
                    {
                        ShowSysMessage("已经无消息可读取\r\n");
                    }
                }
            }
        }


        private void Consume()
        {
            using (IConnection connection = factory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    txtSysMessage.Text = txtSysMessage.Text + @"
Waiting for messages";

                    var consumer = new QueueingBasicConsumer(channel);
                    channel.BasicQos(0, 1, false);
                    channel.BasicConsume(queue.name, rbAckTrue.Checked, consumer);
                    while (true)
                    {
                        var e = consumer.Queue.Dequeue();
                        MessageBox.Show(string.Format("队列{0}获取消息{1},线程id为{2}", queue.name, Encoding.ASCII.GetString(e.Body), Process.GetCurrentProcess().Id));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void Produce(string message)
        {
            using (IConnection connection = factory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    IBasicProperties properties = channel.CreateBasicProperties();
                    properties.SetPersistent(rbMessageDurableTrue.Checked);

                    byte[] payload = Encoding.ASCII.GetBytes(message);
                    channel.BasicPublish(exchange.name, txtMessageRoutingKey.Text.Trim(), properties, payload);

                    txtSysMessage.Text = txtSysMessage.Text + string.Format("\r\nSent Message {0} RoutingKey:{1}" ,message, txtMessageRoutingKey.Text.Trim());

                    Thread.Sleep(10);
                }
            }

        }

        private async Task<HttpResponseMessage> ShowHttpClientResult(string Url)
        {
            var client = new HttpClient();
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
            var exchanges = JsonConvert.DeserializeObject<List<ExchangeEntity>>(jsonContent);
            int count = exchanges.Count;
            txtSysMessage.Clear();
            var s = new StringBuilder();
            s.AppendLine(string.Format("Exchanges Count:{0}", count));
            s.AppendLine("NameList:");
            int index = 1;
            foreach (var exchangeEntity in exchanges)
            {
                s.AppendLine(index + ":" + exchangeEntity.name + "  ");
                index++;
            }
            s.AppendLine("");
            s.AppendLine("Detail:");
            index = 1;
            foreach (var entity in exchanges)
            {
                if (entity.message_stats == null) entity.message_stats = new MessageStatsEntity();
                s.AppendLine(string.Format("{0}.Name:{1},\r\nType:{2},Durable:{3},Auto_delete:{4},Internal:{5},Publish_in:{6},Publish_out：{7}\r\n",
                    index, entity.name, entity.type, entity.durable, entity.auto_delete, entity.internalFlag, entity.message_stats.publish_in, entity.message_stats.publish_out));
                index++;
            }
            ShowSysMessage(s.ToString());
        }

        private async Task<List<ExchangeEntity>> GetUserExchanges(string apiUrl)
        {
            string jsonContent = await ShowApiResult(apiUrl);
            var exchanges = JsonConvert.DeserializeObject<List<ExchangeEntity>>(jsonContent);
            var sysExchanges = (from object item in lbSysExchanges.Items select item.ToString().Trim()).ToList();
            var exchangeEntities = exchanges.Where(x => !sysExchanges.Contains(x.name.Trim())).ToList();
            return exchangeEntities;
        }

        private async void ShowLbUserUserExchanges(string apiUrl)
        {
            lbUserExchanges.Items.Clear();
            userExchanges = await GetUserExchanges(apiUrl);
            if (userExchanges != null && userExchanges.Count != 0)
            {
                foreach (var entity in userExchanges)
                {
                    lbUserExchanges.Items.Add(entity.name);
                }
            }
        }

        private void DeleteExchanges()
        {
            var list = (from object item in lbUserExchanges.Items select item.ToString().Trim()).ToList();
            txtSysMessage.Clear();
            var s = new StringBuilder();
            if (list.Count != 0)
            {
                using (IConnection connection = factory.CreateConnection())
                {
                    using (IModel channel = connection.CreateModel())
                    {
                        foreach (var s1 in list)
                        {
                            channel.ExchangeDelete(s1);
                            s.AppendLine("已删除交换机Name：" + s1);
                        }
                    }
                }
            }
            else
            {
                s.AppendLine("当前没有交换机可删");
            }
            ShowSysMessage(s.ToString());
        }

        private async Task<List<QueueEntity>> GetQueues(string apiUrl)
        {
            string jsonContent = await ShowApiResult(apiUrl);
            queues = JsonConvert.DeserializeObject<List<QueueEntity>>(jsonContent);
            return queues;
        }

        private async Task<List<BindingEntity>> GetBindings(string apiUrl)
        {
            string jsonContent = await ShowApiResult(apiUrl);
            bindings = JsonConvert.DeserializeObject<List<BindingEntity>>(jsonContent);
            return bindings;
        }

        private async void ShowAllQueues(string apiUrl)
        {
            queues = await GetQueues(apiUrl);
            int count = queues.Count;
            txtSysMessage.Clear();
            var s = new StringBuilder();
            s.AppendLine(string.Format("Queues Count:{0}", count));
            s.AppendLine("NameList:");
            int index = 1;
            foreach (var queueEntity in queues)
            {
                s.AppendLine(index + ":" + queueEntity.name + "  ");
                index++;
            }
            s.AppendLine("");
            s.AppendLine("Detail:");
            index = 1;
            foreach (var queueEntity in queues)
            {
                s.AppendLine(string.Format("{0}.Name:{1},\r\nState:{2},vhost:{3},Node:{4},Durable:{5},Auto_delete:{6},Memory:{7},Messages:{8},Messages_ready：{9},Messages_unacknowledged:{10},Idle_since:{11},Consumers:{12}\r\n",
                    index, queueEntity.name, queueEntity.state, queueEntity.vhost, queueEntity.node, queueEntity.durable, queueEntity.auto_delete, queueEntity.memory, queueEntity.messages, queueEntity.messages_ready, queueEntity.messages_unacknowledged, queueEntity.idle_since, queueEntity.consumers));
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
                foreach (var queueEntity in queues)
                {
                    lbQueues.Items.Add(queueEntity.name);
                }
            }
        }

        private async void ShowLbBindings(string apiUrl)
        {
            lbBindings.Items.Clear();
            bindings = await GetBindings(apiUrl);
            if (bindings != null)
            {
                foreach (var bindingEntity in bindings)
                {
                    lbBindings.Items.Add(string.Format("交换机:{0}---队列:{1}---Key:{2}", string.IsNullOrWhiteSpace(bindingEntity.source) ? "默认" : bindingEntity.source, bindingEntity.destination, bindingEntity.routing_key));
                }
            }
        }

        private async void DeleteQueues(string apiUrl)
        {
            string jsonContent = await ShowApiResult(apiUrl);
            var queueEntities = JsonConvert.DeserializeObject<List<QueueEntity>>(jsonContent);
            txtSysMessage.Clear();
            var s = new StringBuilder();
            if (queueEntities != null && queueEntities.Count != 0)
            {
                using (IConnection connection = factory.CreateConnection())
                {
                    using (IModel channel = connection.CreateModel())
                    {
                        foreach (var queueEntity in queueEntities)
                        {
                            channel.QueueDelete(queueEntity.name);
                            s.AppendLine("已删除队列Name：" + queueEntity.name);
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
            if (!string.IsNullOrWhiteSpace(txtSysMessage.Text))
            {
                txtSysMessage.Text = txtSysMessage.Text + @"
";
            }
            txtSysMessage.Text = txtSysMessage.Text + message;
        }

    }
}


