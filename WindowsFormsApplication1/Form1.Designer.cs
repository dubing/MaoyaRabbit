namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectExchange = new System.Windows.Forms.TextBox();
            this.txtSysMessage = new System.Windows.Forms.TextBox();
            this.txtHostUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetApiResult = new System.Windows.Forms.Button();
            this.txtApiName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnQueuesDelete = new System.Windows.Forms.Button();
            this.btnExchangesDelete = new System.Windows.Forms.Button();
            this.btnCheckEnv = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExchangesView = new System.Windows.Forms.Button();
            this.btnQueuesView = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnRefreshQueue = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.lbQueues = new System.Windows.Forms.ListBox();
            this.btnAddQueue = new System.Windows.Forms.Button();
            this.cbAutoDelete = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbExclusive = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbQueueDurable = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtQueue = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbExchangeAutoDelete = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnExchange = new System.Windows.Forms.Button();
            this.btnRefreshUserExchanges = new System.Windows.Forms.Button();
            this.cbDurable = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddExchange = new System.Windows.Forms.Button();
            this.txtExchangeName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRemoveUserExchanges = new System.Windows.Forms.Button();
            this.lbUserExchanges = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbExchangeType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRemoveSysExchanges = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbSysExchanges = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMessageRoutingKey = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btnRemoveBind = new System.Windows.Forms.Button();
            this.btnBind = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMessageDurableFalse = new System.Windows.Forms.RadioButton();
            this.rbMessageDurableTrue = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAckFalse = new System.Windows.Forms.RadioButton();
            this.rbAckTrue = new System.Windows.Forms.RadioButton();
            this.btnConsumeMessage = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.btnReceiveMessage = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.txtRoutingKey = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSelectQueue = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBindingDetail = new System.Windows.Forms.Button();
            this.btnBindingsRefresh = new System.Windows.Forms.Button();
            this.lbBindings = new System.Windows.Forms.ListBox();
            this.label37 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMessage
            // 
            this.btnAddMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddMessage.Location = new System.Drawing.Point(132, 265);
            this.btnAddMessage.Name = "btnAddMessage";
            this.btnAddMessage.Size = new System.Drawing.Size(103, 23);
            this.btnAddMessage.TabIndex = 0;
            this.btnAddMessage.Text = "推送消息";
            this.btnAddMessage.UseVisualStyleBackColor = true;
            this.btnAddMessage.Click += new System.EventHandler(this.btnAddMessage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(234, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "RabbitMq测试";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSelectExchange
            // 
            this.txtSelectExchange.Enabled = false;
            this.txtSelectExchange.Location = new System.Drawing.Point(132, 30);
            this.txtSelectExchange.Name = "txtSelectExchange";
            this.txtSelectExchange.Size = new System.Drawing.Size(103, 21);
            this.txtSelectExchange.TabIndex = 2;
            // 
            // txtSysMessage
            // 
            this.txtSysMessage.Location = new System.Drawing.Point(617, 99);
            this.txtSysMessage.Multiline = true;
            this.txtSysMessage.Name = "txtSysMessage";
            this.txtSysMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSysMessage.Size = new System.Drawing.Size(330, 696);
            this.txtSysMessage.TabIndex = 8;
            // 
            // txtHostUrl
            // 
            this.txtHostUrl.Location = new System.Drawing.Point(69, 34);
            this.txtHostUrl.Name = "txtHostUrl";
            this.txtHostUrl.Size = new System.Drawing.Size(151, 21);
            this.txtHostUrl.TabIndex = 10;
            this.txtHostUrl.Text = "http://localhost:15672";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "宿主地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "选择用户exchange";
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.AllowDrop = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGetApiResult);
            this.panel1.Controls.Add(this.txtApiName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnQueuesDelete);
            this.panel1.Controls.Add(this.btnExchangesDelete);
            this.panel1.Controls.Add(this.btnCheckEnv);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnExchangesView);
            this.panel1.Controls.Add(this.btnQueuesView);
            this.panel1.Controls.Add(this.txtHostUrl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(14, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 133);
            this.panel1.TabIndex = 20;
            // 
            // btnGetApiResult
            // 
            this.btnGetApiResult.Location = new System.Drawing.Point(454, 94);
            this.btnGetApiResult.Name = "btnGetApiResult";
            this.btnGetApiResult.Size = new System.Drawing.Size(115, 23);
            this.btnGetApiResult.TabIndex = 27;
            this.btnGetApiResult.Text = "查看返回信息";
            this.btnGetApiResult.UseVisualStyleBackColor = true;
            this.btnGetApiResult.Click += new System.EventHandler(this.btnGetApiResult_Click);
            // 
            // txtApiName
            // 
            this.txtApiName.Location = new System.Drawing.Point(69, 96);
            this.txtApiName.Name = "txtApiName";
            this.txtApiName.Size = new System.Drawing.Size(379, 21);
            this.txtApiName.TabIndex = 26;
            this.txtApiName.Text = "users";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "其他服务";
            // 
            // btnQueuesDelete
            // 
            this.btnQueuesDelete.Location = new System.Drawing.Point(454, 61);
            this.btnQueuesDelete.Name = "btnQueuesDelete";
            this.btnQueuesDelete.Size = new System.Drawing.Size(115, 23);
            this.btnQueuesDelete.TabIndex = 24;
            this.btnQueuesDelete.Text = "删除所有队列";
            this.btnQueuesDelete.UseVisualStyleBackColor = true;
            this.btnQueuesDelete.Click += new System.EventHandler(this.btnQueuesDelete_Click);
            // 
            // btnExchangesDelete
            // 
            this.btnExchangesDelete.Location = new System.Drawing.Point(347, 61);
            this.btnExchangesDelete.Name = "btnExchangesDelete";
            this.btnExchangesDelete.Size = new System.Drawing.Size(101, 23);
            this.btnExchangesDelete.TabIndex = 23;
            this.btnExchangesDelete.Text = "删除用户交换机";
            this.btnExchangesDelete.UseVisualStyleBackColor = true;
            this.btnExchangesDelete.Click += new System.EventHandler(this.btnExchangesDelete_Click);
            // 
            // btnCheckEnv
            // 
            this.btnCheckEnv.Location = new System.Drawing.Point(12, 61);
            this.btnCheckEnv.Name = "btnCheckEnv";
            this.btnCheckEnv.Size = new System.Drawing.Size(101, 23);
            this.btnCheckEnv.TabIndex = 22;
            this.btnCheckEnv.Text = "检查基本环境";
            this.btnCheckEnv.UseVisualStyleBackColor = true;
            this.btnCheckEnv.Click += new System.EventHandler(this.btnCheckEnv_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "基本配置";
            // 
            // btnExchangesView
            // 
            this.btnExchangesView.Location = new System.Drawing.Point(119, 61);
            this.btnExchangesView.Name = "btnExchangesView";
            this.btnExchangesView.Size = new System.Drawing.Size(101, 23);
            this.btnExchangesView.TabIndex = 12;
            this.btnExchangesView.Text = "查看所有交换机";
            this.btnExchangesView.UseVisualStyleBackColor = true;
            this.btnExchangesView.Click += new System.EventHandler(this.btnExchangesView_Click);
            // 
            // btnQueuesView
            // 
            this.btnQueuesView.Location = new System.Drawing.Point(226, 61);
            this.btnQueuesView.Name = "btnQueuesView";
            this.btnQueuesView.Size = new System.Drawing.Size(115, 23);
            this.btnQueuesView.TabIndex = 13;
            this.btnQueuesView.Text = "查看所有队列";
            this.btnQueuesView.UseVisualStyleBackColor = true;
            this.btnQueuesView.Click += new System.EventHandler(this.btnQueuesView_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(454, 32);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 23);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "刷新用户配置";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(382, 34);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(66, 21);
            this.txtPwd.TabIndex = 17;
            this.txtPwd.Text = "guest";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(285, 34);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(56, 21);
            this.txtUsername.TabIndex = 14;
            this.txtUsername.Text = "guest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "用户名";
            // 
            // panel2
            // 
            this.panel2.AccessibleName = "";
            this.panel2.AllowDrop = true;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnQueue);
            this.panel2.Controls.Add(this.btnRefreshQueue);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.lbQueues);
            this.panel2.Controls.Add(this.btnAddQueue);
            this.panel2.Controls.Add(this.cbAutoDelete);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.cbExclusive);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.cbQueueDurable);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtQueue);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 220);
            this.panel2.TabIndex = 21;
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(78, 187);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(51, 23);
            this.btnQueue.TabIndex = 39;
            this.btnQueue.Text = "查看";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnRefreshQueue
            // 
            this.btnRefreshQueue.Location = new System.Drawing.Point(14, 187);
            this.btnRefreshQueue.Name = "btnRefreshQueue";
            this.btnRefreshQueue.Size = new System.Drawing.Size(51, 23);
            this.btnRefreshQueue.TabIndex = 44;
            this.btnRefreshQueue.Text = "刷新";
            this.btnRefreshQueue.UseVisualStyleBackColor = true;
            this.btnRefreshQueue.Click += new System.EventHandler(this.btnRefreshQueue_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 39;
            this.label21.Text = "队列";
            // 
            // lbQueues
            // 
            this.lbQueues.FormattingEnabled = true;
            this.lbQueues.ItemHeight = 12;
            this.lbQueues.Location = new System.Drawing.Point(14, 57);
            this.lbQueues.Name = "lbQueues";
            this.lbQueues.Size = new System.Drawing.Size(115, 124);
            this.lbQueues.TabIndex = 39;
            this.lbQueues.SelectedIndexChanged += new System.EventHandler(this.lbQueues_SelectedIndexChanged);
            // 
            // btnAddQueue
            // 
            this.btnAddQueue.Location = new System.Drawing.Point(242, 162);
            this.btnAddQueue.Name = "btnAddQueue";
            this.btnAddQueue.Size = new System.Drawing.Size(71, 23);
            this.btnAddQueue.TabIndex = 43;
            this.btnAddQueue.Text = "添加";
            this.btnAddQueue.UseVisualStyleBackColor = true;
            this.btnAddQueue.Click += new System.EventHandler(this.btnAddQueue_Click);
            // 
            // cbAutoDelete
            // 
            this.cbAutoDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutoDelete.FormattingEnabled = true;
            this.cbAutoDelete.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbAutoDelete.Location = new System.Drawing.Point(209, 136);
            this.cbAutoDelete.Name = "cbAutoDelete";
            this.cbAutoDelete.Size = new System.Drawing.Size(104, 20);
            this.cbAutoDelete.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(150, 139);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 41;
            this.label20.Text = "自动删除";
            // 
            // cbExclusive
            // 
            this.cbExclusive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExclusive.FormattingEnabled = true;
            this.cbExclusive.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbExclusive.Location = new System.Drawing.Point(209, 110);
            this.cbExclusive.Name = "cbExclusive";
            this.cbExclusive.Size = new System.Drawing.Size(104, 20);
            this.cbExclusive.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(150, 113);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 39;
            this.label19.Text = "排他性";
            // 
            // cbQueueDurable
            // 
            this.cbQueueDurable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQueueDurable.FormattingEnabled = true;
            this.cbQueueDurable.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbQueueDurable.Location = new System.Drawing.Point(209, 84);
            this.cbQueueDurable.Name = "cbQueueDurable";
            this.cbQueueDurable.Size = new System.Drawing.Size(104, 20);
            this.cbQueueDurable.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(150, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 37;
            this.label18.Text = "持久化";
            // 
            // txtQueue
            // 
            this.txtQueue.Location = new System.Drawing.Point(209, 57);
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.Size = new System.Drawing.Size(104, 21);
            this.txtQueue.TabIndex = 34;
            this.txtQueue.Text = "testQueue";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(150, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 35;
            this.label17.Text = "名称";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "队列操作";
            // 
            // panel3
            // 
            this.panel3.AccessibleName = "";
            this.panel3.AllowDrop = true;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbExchangeAutoDelete);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.btnExchange);
            this.panel3.Controls.Add(this.btnRefreshUserExchanges);
            this.panel3.Controls.Add(this.cbDurable);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.btnAddExchange);
            this.panel3.Controls.Add(this.txtExchangeName);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btnRemoveUserExchanges);
            this.panel3.Controls.Add(this.lbUserExchanges);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.cbExchangeType);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.btnRemoveSysExchanges);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lbSysExchanges);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(14, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(589, 192);
            this.panel3.TabIndex = 22;
            // 
            // cbExchangeAutoDelete
            // 
            this.cbExchangeAutoDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExchangeAutoDelete.FormattingEnabled = true;
            this.cbExchangeAutoDelete.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbExchangeAutoDelete.Location = new System.Drawing.Point(479, 132);
            this.cbExchangeAutoDelete.Name = "cbExchangeAutoDelete";
            this.cbExchangeAutoDelete.Size = new System.Drawing.Size(90, 20);
            this.cbExchangeAutoDelete.TabIndex = 44;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(420, 135);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 12);
            this.label24.TabIndex = 43;
            this.label24.Text = "自动删除";
            // 
            // btnExchange
            // 
            this.btnExchange.Location = new System.Drawing.Point(333, 112);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(51, 23);
            this.btnExchange.TabIndex = 38;
            this.btnExchange.Text = "查看";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // btnRefreshUserExchanges
            // 
            this.btnRefreshUserExchanges.Location = new System.Drawing.Point(333, 85);
            this.btnRefreshUserExchanges.Name = "btnRefreshUserExchanges";
            this.btnRefreshUserExchanges.Size = new System.Drawing.Size(51, 23);
            this.btnRefreshUserExchanges.TabIndex = 37;
            this.btnRefreshUserExchanges.Text = "刷新";
            this.btnRefreshUserExchanges.UseVisualStyleBackColor = true;
            this.btnRefreshUserExchanges.Click += new System.EventHandler(this.btnRefreshUserExchanges_Click);
            // 
            // cbDurable
            // 
            this.cbDurable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDurable.FormattingEnabled = true;
            this.cbDurable.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbDurable.Location = new System.Drawing.Point(479, 109);
            this.cbDurable.Name = "cbDurable";
            this.cbDurable.Size = new System.Drawing.Size(90, 20);
            this.cbDurable.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(420, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 35;
            this.label16.Text = "持久化";
            // 
            // btnAddExchange
            // 
            this.btnAddExchange.Location = new System.Drawing.Point(498, 158);
            this.btnAddExchange.Name = "btnAddExchange";
            this.btnAddExchange.Size = new System.Drawing.Size(71, 23);
            this.btnAddExchange.TabIndex = 34;
            this.btnAddExchange.Text = "添加";
            this.btnAddExchange.UseVisualStyleBackColor = true;
            this.btnAddExchange.Click += new System.EventHandler(this.btnAddExchange_Click);
            // 
            // txtExchangeName
            // 
            this.txtExchangeName.Location = new System.Drawing.Point(479, 79);
            this.txtExchangeName.Name = "txtExchangeName";
            this.txtExchangeName.Size = new System.Drawing.Size(90, 21);
            this.txtExchangeName.TabIndex = 28;
            this.txtExchangeName.Text = "testExchange";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(420, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 33;
            this.label12.Text = "名称";
            // 
            // btnRemoveUserExchanges
            // 
            this.btnRemoveUserExchanges.Location = new System.Drawing.Point(333, 56);
            this.btnRemoveUserExchanges.Name = "btnRemoveUserExchanges";
            this.btnRemoveUserExchanges.Size = new System.Drawing.Size(51, 23);
            this.btnRemoveUserExchanges.TabIndex = 32;
            this.btnRemoveUserExchanges.Text = "移出";
            this.btnRemoveUserExchanges.UseVisualStyleBackColor = true;
            this.btnRemoveUserExchanges.Click += new System.EventHandler(this.btnRemoveUserExchanges_Click);
            // 
            // lbUserExchanges
            // 
            this.lbUserExchanges.FormattingEnabled = true;
            this.lbUserExchanges.ItemHeight = 12;
            this.lbUserExchanges.Location = new System.Drawing.Point(196, 56);
            this.lbUserExchanges.Name = "lbUserExchanges";
            this.lbUserExchanges.Size = new System.Drawing.Size(115, 112);
            this.lbUserExchanges.TabIndex = 31;
            this.lbUserExchanges.SelectedIndexChanged += new System.EventHandler(this.lbUserExchanges_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(194, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 30;
            this.label15.Text = "用户exchange";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(420, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 29;
            this.label14.Text = "类型";
            // 
            // cbExchangeType
            // 
            this.cbExchangeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExchangeType.FormattingEnabled = true;
            this.cbExchangeType.Items.AddRange(new object[] {
            "fanout",
            "topic",
            "direct"});
            this.cbExchangeType.Location = new System.Drawing.Point(479, 53);
            this.cbExchangeType.Name = "cbExchangeType";
            this.cbExchangeType.Size = new System.Drawing.Size(90, 20);
            this.cbExchangeType.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(420, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "添加交换机";
            // 
            // btnRemoveSysExchanges
            // 
            this.btnRemoveSysExchanges.Enabled = false;
            this.btnRemoveSysExchanges.Location = new System.Drawing.Point(139, 56);
            this.btnRemoveSysExchanges.Name = "btnRemoveSysExchanges";
            this.btnRemoveSysExchanges.Size = new System.Drawing.Size(51, 23);
            this.btnRemoveSysExchanges.TabIndex = 22;
            this.btnRemoveSysExchanges.Text = "移出";
            this.btnRemoveSysExchanges.UseVisualStyleBackColor = true;
            this.btnRemoveSysExchanges.Click += new System.EventHandler(this.btnRemoveSysExchanges_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "限定exchange(移除才可删除):";
            // 
            // lbSysExchanges
            // 
            this.lbSysExchanges.FormattingEnabled = true;
            this.lbSysExchanges.ItemHeight = 12;
            this.lbSysExchanges.Items.AddRange(new object[] {
            "",
            "amq.direct ",
            "amq.fanout ",
            "amq.headers",
            "amq.match",
            "amq.rabbitmq.log ",
            "amq.rabbitmq.trace",
            "amq.topic"});
            this.lbSysExchanges.Location = new System.Drawing.Point(12, 56);
            this.lbSysExchanges.Name = "lbSysExchanges";
            this.lbSysExchanges.Size = new System.Drawing.Size(121, 112);
            this.lbSysExchanges.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "交换机操作";
            // 
            // panel4
            // 
            this.panel4.AccessibleName = "";
            this.panel4.AllowDrop = true;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtMessageRoutingKey);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.btnRemoveBind);
            this.panel4.Controls.Add(this.btnBind);
            this.panel4.Controls.Add(this.txtMessage);
            this.panel4.Controls.Add(this.label32);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.btnConsumeMessage);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.btnReceiveMessage);
            this.panel4.Controls.Add(this.label27);
            this.panel4.Controls.Add(this.txtRoutingKey);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.txtSelectQueue);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtSelectExchange);
            this.panel4.Controls.Add(this.btnAddMessage);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(348, 403);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 392);
            this.panel4.TabIndex = 23;
            // 
            // txtMessageRoutingKey
            // 
            this.txtMessageRoutingKey.Location = new System.Drawing.Point(132, 229);
            this.txtMessageRoutingKey.Name = "txtMessageRoutingKey";
            this.txtMessageRoutingKey.Size = new System.Drawing.Size(103, 21);
            this.txtMessageRoutingKey.TabIndex = 56;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(13, 232);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 12);
            this.label29.TabIndex = 55;
            this.label29.Text = "路由Key";
            // 
            // btnRemoveBind
            // 
            this.btnRemoveBind.Location = new System.Drawing.Point(132, 111);
            this.btnRemoveBind.Name = "btnRemoveBind";
            this.btnRemoveBind.Size = new System.Drawing.Size(103, 23);
            this.btnRemoveBind.TabIndex = 54;
            this.btnRemoveBind.Text = "解绑";
            this.btnRemoveBind.UseVisualStyleBackColor = true;
            this.btnRemoveBind.Click += new System.EventHandler(this.btnRemoveBind_Click);
            // 
            // btnBind
            // 
            this.btnBind.Location = new System.Drawing.Point(13, 111);
            this.btnBind.Name = "btnBind";
            this.btnBind.Size = new System.Drawing.Size(103, 23);
            this.btnBind.TabIndex = 53;
            this.btnBind.Text = "绑定";
            this.btnBind.UseVisualStyleBackColor = true;
            this.btnBind.Click += new System.EventHandler(this.btnBind_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(132, 202);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(103, 21);
            this.txtMessage.TabIndex = 52;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(13, 205);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 12);
            this.label32.TabIndex = 51;
            this.label32.Text = "消息内容";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMessageDurableFalse);
            this.groupBox2.Controls.Add(this.rbMessageDurableTrue);
            this.groupBox2.Location = new System.Drawing.Point(132, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(86, 34);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            // 
            // rbMessageDurableFalse
            // 
            this.rbMessageDurableFalse.AutoSize = true;
            this.rbMessageDurableFalse.Location = new System.Drawing.Point(47, 12);
            this.rbMessageDurableFalse.Name = "rbMessageDurableFalse";
            this.rbMessageDurableFalse.Size = new System.Drawing.Size(35, 16);
            this.rbMessageDurableFalse.TabIndex = 1;
            this.rbMessageDurableFalse.Text = "否";
            this.rbMessageDurableFalse.UseVisualStyleBackColor = true;
            // 
            // rbMessageDurableTrue
            // 
            this.rbMessageDurableTrue.AutoSize = true;
            this.rbMessageDurableTrue.Checked = true;
            this.rbMessageDurableTrue.Location = new System.Drawing.Point(6, 12);
            this.rbMessageDurableTrue.Name = "rbMessageDurableTrue";
            this.rbMessageDurableTrue.Size = new System.Drawing.Size(35, 16);
            this.rbMessageDurableTrue.TabIndex = 0;
            this.rbMessageDurableTrue.TabStop = true;
            this.rbMessageDurableTrue.Text = "是";
            this.rbMessageDurableTrue.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAckFalse);
            this.groupBox1.Controls.Add(this.rbAckTrue);
            this.groupBox1.Location = new System.Drawing.Point(132, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 34);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // rbAckFalse
            // 
            this.rbAckFalse.AutoSize = true;
            this.rbAckFalse.Location = new System.Drawing.Point(47, 12);
            this.rbAckFalse.Name = "rbAckFalse";
            this.rbAckFalse.Size = new System.Drawing.Size(35, 16);
            this.rbAckFalse.TabIndex = 1;
            this.rbAckFalse.Text = "否";
            this.rbAckFalse.UseVisualStyleBackColor = true;
            // 
            // rbAckTrue
            // 
            this.rbAckTrue.AutoSize = true;
            this.rbAckTrue.Checked = true;
            this.rbAckTrue.Location = new System.Drawing.Point(6, 12);
            this.rbAckTrue.Name = "rbAckTrue";
            this.rbAckTrue.Size = new System.Drawing.Size(35, 16);
            this.rbAckTrue.TabIndex = 0;
            this.rbAckTrue.TabStop = true;
            this.rbAckTrue.Text = "是";
            this.rbAckTrue.UseVisualStyleBackColor = true;
            // 
            // btnConsumeMessage
            // 
            this.btnConsumeMessage.Location = new System.Drawing.Point(132, 350);
            this.btnConsumeMessage.Name = "btnConsumeMessage";
            this.btnConsumeMessage.Size = new System.Drawing.Size(103, 23);
            this.btnConsumeMessage.TabIndex = 46;
            this.btnConsumeMessage.Text = "消费消息";
            this.btnConsumeMessage.UseVisualStyleBackColor = true;
            this.btnConsumeMessage.Click += new System.EventHandler(this.btnConsumeMessage_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(13, 326);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(101, 12);
            this.label28.TabIndex = 43;
            this.label28.Text = "是否添加确认标记";
            // 
            // btnReceiveMessage
            // 
            this.btnReceiveMessage.Location = new System.Drawing.Point(15, 350);
            this.btnReceiveMessage.Name = "btnReceiveMessage";
            this.btnReceiveMessage.Size = new System.Drawing.Size(103, 23);
            this.btnReceiveMessage.TabIndex = 42;
            this.btnReceiveMessage.Text = "接受消息";
            this.btnReceiveMessage.UseVisualStyleBackColor = true;
            this.btnReceiveMessage.Click += new System.EventHandler(this.btnReceiveMessage_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(13, 301);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 12);
            this.label27.TabIndex = 41;
            this.label27.Text = "接受消息";
            // 
            // txtRoutingKey
            // 
            this.txtRoutingKey.Location = new System.Drawing.Point(132, 84);
            this.txtRoutingKey.Name = "txtRoutingKey";
            this.txtRoutingKey.Size = new System.Drawing.Size(103, 21);
            this.txtRoutingKey.TabIndex = 40;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(13, 90);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 12);
            this.label26.TabIndex = 39;
            this.label26.Text = "路由Key";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(13, 179);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 12);
            this.label25.TabIndex = 37;
            this.label25.Text = "持久化";
            // 
            // txtSelectQueue
            // 
            this.txtSelectQueue.Enabled = false;
            this.txtSelectQueue.Location = new System.Drawing.Point(132, 57);
            this.txtSelectQueue.Name = "txtSelectQueue";
            this.txtSelectQueue.Size = new System.Drawing.Size(103, 21);
            this.txtSelectQueue.TabIndex = 22;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 23;
            this.label22.Text = "选择队列";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 152);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 24;
            this.label23.Text = "推送消息";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "消息操作";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(615, 76);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 12);
            this.label31.TabIndex = 45;
            this.label31.Text = "输出窗口";
            // 
            // panel5
            // 
            this.panel5.AccessibleName = "";
            this.panel5.AllowDrop = true;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnBindingDetail);
            this.panel5.Controls.Add(this.btnBindingsRefresh);
            this.panel5.Controls.Add(this.lbBindings);
            this.panel5.Controls.Add(this.label37);
            this.panel5.Location = new System.Drawing.Point(12, 629);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 166);
            this.panel5.TabIndex = 46;
            // 
            // btnBindingDetail
            // 
            this.btnBindingDetail.Location = new System.Drawing.Point(262, 57);
            this.btnBindingDetail.Name = "btnBindingDetail";
            this.btnBindingDetail.Size = new System.Drawing.Size(51, 23);
            this.btnBindingDetail.TabIndex = 39;
            this.btnBindingDetail.Text = "查看";
            this.btnBindingDetail.UseVisualStyleBackColor = true;
            this.btnBindingDetail.Click += new System.EventHandler(this.btnBindingDetail_Click);
            // 
            // btnBindingsRefresh
            // 
            this.btnBindingsRefresh.Location = new System.Drawing.Point(262, 28);
            this.btnBindingsRefresh.Name = "btnBindingsRefresh";
            this.btnBindingsRefresh.Size = new System.Drawing.Size(51, 23);
            this.btnBindingsRefresh.TabIndex = 44;
            this.btnBindingsRefresh.Text = "刷新";
            this.btnBindingsRefresh.UseVisualStyleBackColor = true;
            this.btnBindingsRefresh.Click += new System.EventHandler(this.btnBindingsRefresh_Click);
            // 
            // lbBindings
            // 
            this.lbBindings.FormattingEnabled = true;
            this.lbBindings.ItemHeight = 12;
            this.lbBindings.Location = new System.Drawing.Point(14, 28);
            this.lbBindings.Name = "lbBindings";
            this.lbBindings.Size = new System.Drawing.Size(235, 124);
            this.lbBindings.TabIndex = 39;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(12, 9);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(53, 12);
            this.label37.TabIndex = 21;
            this.label37.Text = "绑定关系";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 803);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSysMessage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectExchange;
        private System.Windows.Forms.TextBox txtSysMessage;
        private System.Windows.Forms.TextBox txtHostUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExchangesView;
        private System.Windows.Forms.Button btnQueuesView;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCheckEnv;
        private System.Windows.Forms.Button btnQueuesDelete;
        private System.Windows.Forms.Button btnExchangesDelete;
        private System.Windows.Forms.Button btnGetApiResult;
        private System.Windows.Forms.TextBox txtApiName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbSysExchanges;
        private System.Windows.Forms.Button btnRemoveSysExchanges;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbExchangeType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbUserExchanges;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRemoveUserExchanges;
        private System.Windows.Forms.TextBox txtExchangeName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddExchange;
        private System.Windows.Forms.ComboBox cbDurable;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnRefreshUserExchanges;
        private System.Windows.Forms.TextBox txtQueue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbQueueDurable;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbExclusive;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnAddQueue;
        private System.Windows.Forms.ComboBox cbAutoDelete;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnRefreshQueue;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox lbQueues;
        private System.Windows.Forms.TextBox txtSelectQueue;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbExchangeAutoDelete;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnConsumeMessage;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnReceiveMessage;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtRoutingKey;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAckFalse;
        private System.Windows.Forms.RadioButton rbAckTrue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMessageDurableFalse;
        private System.Windows.Forms.RadioButton rbMessageDurableTrue;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnRemoveBind;
        private System.Windows.Forms.Button btnBind;
        private System.Windows.Forms.TextBox txtMessageRoutingKey;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBindingDetail;
        private System.Windows.Forms.Button btnBindingsRefresh;
        private System.Windows.Forms.ListBox lbBindings;
        private System.Windows.Forms.Label label37;
    }
}

