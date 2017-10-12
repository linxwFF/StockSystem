namespace StockSystem
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_daily = new System.Windows.Forms.Button();
            this.btn_weekly = new System.Windows.Forms.Button();
            this.text_stockCode = new System.Windows.Forms.TextBox();
            this.btn_query = new System.Windows.Forms.Button();
            this.stock_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.index_Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buy_1 = new System.Windows.Forms.Label();
            this.buy_1_price = new System.Windows.Forms.Label();
            this.buy_2 = new System.Windows.Forms.Label();
            this.buy_2_price = new System.Windows.Forms.Label();
            this.buy_3 = new System.Windows.Forms.Label();
            this.buy_3_price = new System.Windows.Forms.Label();
            this.buy_4 = new System.Windows.Forms.Label();
            this.buy_4_price = new System.Windows.Forms.Label();
            this.buy_5 = new System.Windows.Forms.Label();
            this.buy_5_price = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.sell_1 = new System.Windows.Forms.Label();
            this.sell_1_price = new System.Windows.Forms.Label();
            this.sell_2 = new System.Windows.Forms.Label();
            this.sell_2_price = new System.Windows.Forms.Label();
            this.sell_3 = new System.Windows.Forms.Label();
            this.sell_4 = new System.Windows.Forms.Label();
            this.sell_5 = new System.Windows.Forms.Label();
            this.sell_3_price = new System.Windows.Forms.Label();
            this.sell_4_price = new System.Windows.Forms.Label();
            this.sell_5_price = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btn_monthly = new System.Windows.Forms.Button();
            this.股票名字 = new System.Windows.Forms.Label();
            this.今日开盘价 = new System.Windows.Forms.Label();
            this.昨日收盘价 = new System.Windows.Forms.Label();
            this.当前价格 = new System.Windows.Forms.Label();
            this.今日最高价 = new System.Windows.Forms.Label();
            this.今日最低价 = new System.Windows.Forms.Label();
            this.竞买价 = new System.Windows.Forms.Label();
            this.竞卖价 = new System.Windows.Forms.Label();
            this.成交的股票数 = new System.Windows.Forms.Label();
            this.成交金额 = new System.Windows.Forms.Label();
            this.涨跌标签 = new System.Windows.Forms.Label();
            this.时间标签 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(190, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(28, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 265);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "持有股票";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(7, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(963, 239);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 341);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 300);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_min
            // 
            this.btn_min.Location = new System.Drawing.Point(28, 313);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(75, 23);
            this.btn_min.TabIndex = 0;
            this.btn_min.Text = "分时线";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_daily
            // 
            this.btn_daily.Location = new System.Drawing.Point(109, 313);
            this.btn_daily.Name = "btn_daily";
            this.btn_daily.Size = new System.Drawing.Size(75, 23);
            this.btn_daily.TabIndex = 1;
            this.btn_daily.Text = "日K线";
            this.btn_daily.UseVisualStyleBackColor = true;
            this.btn_daily.Click += new System.EventHandler(this.btn_daily_Click);
            // 
            // btn_weekly
            // 
            this.btn_weekly.Location = new System.Drawing.Point(190, 313);
            this.btn_weekly.Name = "btn_weekly";
            this.btn_weekly.Size = new System.Drawing.Size(75, 23);
            this.btn_weekly.TabIndex = 1;
            this.btn_weekly.Text = "周K线";
            this.btn_weekly.UseVisualStyleBackColor = true;
            this.btn_weekly.Click += new System.EventHandler(this.btn_weekly_Click);
            // 
            // text_stockCode
            // 
            this.text_stockCode.Location = new System.Drawing.Point(299, 13);
            this.text_stockCode.Name = "text_stockCode";
            this.text_stockCode.Size = new System.Drawing.Size(100, 21);
            this.text_stockCode.TabIndex = 4;
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(418, 13);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 23);
            this.btn_query.TabIndex = 1;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // stock_name
            // 
            this.stock_name.AutoSize = true;
            this.stock_name.Location = new System.Drawing.Point(27, 38);
            this.stock_name.Name = "stock_name";
            this.stock_name.Size = new System.Drawing.Size(53, 12);
            this.stock_name.TabIndex = 5;
            this.stock_name.Text = "股票名字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "今日开盘价";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "昨日收盘价";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "当前价格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "今日最高价";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "今日最低价";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "竞买价";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "竞卖价";
            // 
            // index_Timer
            // 
            this.index_Timer.Tick += new System.EventHandler(this.index_Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "成交的股票数";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "成交金额";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "买一";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "买二";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 9;
            this.label13.Text = "买三";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 9;
            this.label14.Text = "买四";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "买五";
            // 
            // buy_1
            // 
            this.buy_1.AutoSize = true;
            this.buy_1.Location = new System.Drawing.Point(75, 16);
            this.buy_1.Name = "buy_1";
            this.buy_1.Size = new System.Drawing.Size(0, 12);
            this.buy_1.TabIndex = 10;
            // 
            // buy_1_price
            // 
            this.buy_1_price.AutoSize = true;
            this.buy_1_price.Location = new System.Drawing.Point(127, 16);
            this.buy_1_price.Name = "buy_1_price";
            this.buy_1_price.Size = new System.Drawing.Size(0, 12);
            this.buy_1_price.TabIndex = 10;
            // 
            // buy_2
            // 
            this.buy_2.AutoSize = true;
            this.buy_2.Location = new System.Drawing.Point(75, 36);
            this.buy_2.Name = "buy_2";
            this.buy_2.Size = new System.Drawing.Size(0, 12);
            this.buy_2.TabIndex = 10;
            // 
            // buy_2_price
            // 
            this.buy_2_price.AutoSize = true;
            this.buy_2_price.Location = new System.Drawing.Point(127, 36);
            this.buy_2_price.Name = "buy_2_price";
            this.buy_2_price.Size = new System.Drawing.Size(0, 12);
            this.buy_2_price.TabIndex = 10;
            // 
            // buy_3
            // 
            this.buy_3.AutoSize = true;
            this.buy_3.Location = new System.Drawing.Point(75, 57);
            this.buy_3.Name = "buy_3";
            this.buy_3.Size = new System.Drawing.Size(0, 12);
            this.buy_3.TabIndex = 10;
            // 
            // buy_3_price
            // 
            this.buy_3_price.AutoSize = true;
            this.buy_3_price.Location = new System.Drawing.Point(127, 57);
            this.buy_3_price.Name = "buy_3_price";
            this.buy_3_price.Size = new System.Drawing.Size(0, 12);
            this.buy_3_price.TabIndex = 10;
            // 
            // buy_4
            // 
            this.buy_4.AutoSize = true;
            this.buy_4.Location = new System.Drawing.Point(75, 77);
            this.buy_4.Name = "buy_4";
            this.buy_4.Size = new System.Drawing.Size(0, 12);
            this.buy_4.TabIndex = 10;
            // 
            // buy_4_price
            // 
            this.buy_4_price.AutoSize = true;
            this.buy_4_price.Location = new System.Drawing.Point(127, 77);
            this.buy_4_price.Name = "buy_4_price";
            this.buy_4_price.Size = new System.Drawing.Size(0, 12);
            this.buy_4_price.TabIndex = 10;
            // 
            // buy_5
            // 
            this.buy_5.AutoSize = true;
            this.buy_5.Location = new System.Drawing.Point(75, 97);
            this.buy_5.Name = "buy_5";
            this.buy_5.Size = new System.Drawing.Size(0, 12);
            this.buy_5.TabIndex = 10;
            // 
            // buy_5_price
            // 
            this.buy_5_price.AutoSize = true;
            this.buy_5_price.Location = new System.Drawing.Point(127, 97);
            this.buy_5_price.Name = "buy_5_price";
            this.buy_5_price.Size = new System.Drawing.Size(0, 12);
            this.buy_5_price.TabIndex = 10;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(19, 129);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 9;
            this.label26.Text = "卖一";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(19, 148);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 12);
            this.label27.TabIndex = 9;
            this.label27.Text = "卖二";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(19, 169);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 9;
            this.label28.Text = "卖三";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(19, 189);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 12);
            this.label29.TabIndex = 9;
            this.label29.Text = "卖四";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(19, 209);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 12);
            this.label30.TabIndex = 9;
            this.label30.Text = "卖五";
            // 
            // sell_1
            // 
            this.sell_1.AutoSize = true;
            this.sell_1.Location = new System.Drawing.Point(78, 129);
            this.sell_1.Name = "sell_1";
            this.sell_1.Size = new System.Drawing.Size(0, 12);
            this.sell_1.TabIndex = 10;
            // 
            // sell_1_price
            // 
            this.sell_1_price.AutoSize = true;
            this.sell_1_price.Location = new System.Drawing.Point(126, 129);
            this.sell_1_price.Name = "sell_1_price";
            this.sell_1_price.Size = new System.Drawing.Size(0, 12);
            this.sell_1_price.TabIndex = 10;
            // 
            // sell_2
            // 
            this.sell_2.AutoSize = true;
            this.sell_2.Location = new System.Drawing.Point(78, 149);
            this.sell_2.Name = "sell_2";
            this.sell_2.Size = new System.Drawing.Size(0, 12);
            this.sell_2.TabIndex = 10;
            // 
            // sell_2_price
            // 
            this.sell_2_price.AutoSize = true;
            this.sell_2_price.Location = new System.Drawing.Point(126, 149);
            this.sell_2_price.Name = "sell_2_price";
            this.sell_2_price.Size = new System.Drawing.Size(0, 12);
            this.sell_2_price.TabIndex = 10;
            // 
            // sell_3
            // 
            this.sell_3.AutoSize = true;
            this.sell_3.Location = new System.Drawing.Point(78, 170);
            this.sell_3.Name = "sell_3";
            this.sell_3.Size = new System.Drawing.Size(0, 12);
            this.sell_3.TabIndex = 10;
            // 
            // sell_4
            // 
            this.sell_4.AutoSize = true;
            this.sell_4.Location = new System.Drawing.Point(78, 190);
            this.sell_4.Name = "sell_4";
            this.sell_4.Size = new System.Drawing.Size(0, 12);
            this.sell_4.TabIndex = 10;
            // 
            // sell_5
            // 
            this.sell_5.AutoSize = true;
            this.sell_5.Location = new System.Drawing.Point(78, 210);
            this.sell_5.Name = "sell_5";
            this.sell_5.Size = new System.Drawing.Size(0, 12);
            this.sell_5.TabIndex = 10;
            // 
            // sell_3_price
            // 
            this.sell_3_price.AutoSize = true;
            this.sell_3_price.Location = new System.Drawing.Point(126, 170);
            this.sell_3_price.Name = "sell_3_price";
            this.sell_3_price.Size = new System.Drawing.Size(0, 12);
            this.sell_3_price.TabIndex = 10;
            // 
            // sell_4_price
            // 
            this.sell_4_price.AutoSize = true;
            this.sell_4_price.Location = new System.Drawing.Point(126, 190);
            this.sell_4_price.Name = "sell_4_price";
            this.sell_4_price.Size = new System.Drawing.Size(0, 12);
            this.sell_4_price.TabIndex = 10;
            // 
            // sell_5_price
            // 
            this.sell_5_price.AutoSize = true;
            this.sell_5_price.Location = new System.Drawing.Point(126, 210);
            this.sell_5_price.Name = "sell_5_price";
            this.sell_5_price.Size = new System.Drawing.Size(0, 12);
            this.sell_5_price.TabIndex = 10;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 154;
            this.lineShape1.Y1 = 100;
            this.lineShape1.Y2 = 100;
            // 
            // btn_monthly
            // 
            this.btn_monthly.Location = new System.Drawing.Point(271, 313);
            this.btn_monthly.Name = "btn_monthly";
            this.btn_monthly.Size = new System.Drawing.Size(75, 23);
            this.btn_monthly.TabIndex = 1;
            this.btn_monthly.Text = "月K线";
            this.btn_monthly.UseVisualStyleBackColor = true;
            this.btn_monthly.Click += new System.EventHandler(this.btn_monthly_Click);
            // 
            // 股票名字
            // 
            this.股票名字.AutoSize = true;
            this.股票名字.Location = new System.Drawing.Point(112, 38);
            this.股票名字.Name = "股票名字";
            this.股票名字.Size = new System.Drawing.Size(53, 12);
            this.股票名字.TabIndex = 5;
            this.股票名字.Text = "股票名字";
            // 
            // 今日开盘价
            // 
            this.今日开盘价.AutoSize = true;
            this.今日开盘价.Location = new System.Drawing.Point(112, 60);
            this.今日开盘价.Name = "今日开盘价";
            this.今日开盘价.Size = new System.Drawing.Size(65, 12);
            this.今日开盘价.TabIndex = 5;
            this.今日开盘价.Text = "今日开盘价";
            // 
            // 昨日收盘价
            // 
            this.昨日收盘价.AutoSize = true;
            this.昨日收盘价.Location = new System.Drawing.Point(112, 82);
            this.昨日收盘价.Name = "昨日收盘价";
            this.昨日收盘价.Size = new System.Drawing.Size(65, 12);
            this.昨日收盘价.TabIndex = 5;
            this.昨日收盘价.Text = "昨日收盘价";
            // 
            // 当前价格
            // 
            this.当前价格.AutoSize = true;
            this.当前价格.Location = new System.Drawing.Point(112, 104);
            this.当前价格.Name = "当前价格";
            this.当前价格.Size = new System.Drawing.Size(53, 12);
            this.当前价格.TabIndex = 5;
            this.当前价格.Text = "当前价格";
            // 
            // 今日最高价
            // 
            this.今日最高价.AutoSize = true;
            this.今日最高价.Location = new System.Drawing.Point(112, 126);
            this.今日最高价.Name = "今日最高价";
            this.今日最高价.Size = new System.Drawing.Size(65, 12);
            this.今日最高价.TabIndex = 5;
            this.今日最高价.Text = "今日最高价";
            // 
            // 今日最低价
            // 
            this.今日最低价.AutoSize = true;
            this.今日最低价.Location = new System.Drawing.Point(112, 148);
            this.今日最低价.Name = "今日最低价";
            this.今日最低价.Size = new System.Drawing.Size(65, 12);
            this.今日最低价.TabIndex = 5;
            this.今日最低价.Text = "今日最低价";
            // 
            // 竞买价
            // 
            this.竞买价.AutoSize = true;
            this.竞买价.Location = new System.Drawing.Point(112, 171);
            this.竞买价.Name = "竞买价";
            this.竞买价.Size = new System.Drawing.Size(41, 12);
            this.竞买价.TabIndex = 5;
            this.竞买价.Text = "竞买价";
            // 
            // 竞卖价
            // 
            this.竞卖价.AutoSize = true;
            this.竞卖价.Location = new System.Drawing.Point(112, 193);
            this.竞卖价.Name = "竞卖价";
            this.竞卖价.Size = new System.Drawing.Size(41, 12);
            this.竞卖价.TabIndex = 5;
            this.竞卖价.Text = "竞卖价";
            // 
            // 成交的股票数
            // 
            this.成交的股票数.AutoSize = true;
            this.成交的股票数.Location = new System.Drawing.Point(114, 214);
            this.成交的股票数.Name = "成交的股票数";
            this.成交的股票数.Size = new System.Drawing.Size(77, 12);
            this.成交的股票数.TabIndex = 6;
            this.成交的股票数.Text = "成交的股票数";
            // 
            // 成交金额
            // 
            this.成交金额.AutoSize = true;
            this.成交金额.Location = new System.Drawing.Point(114, 236);
            this.成交金额.Name = "成交金额";
            this.成交金额.Size = new System.Drawing.Size(53, 12);
            this.成交金额.TabIndex = 8;
            this.成交金额.Text = "成交金额";
            // 
            // 涨跌标签
            // 
            this.涨跌标签.AutoSize = true;
            this.涨跌标签.Location = new System.Drawing.Point(28, 17);
            this.涨跌标签.Name = "涨跌标签";
            this.涨跌标签.Size = new System.Drawing.Size(53, 12);
            this.涨跌标签.TabIndex = 12;
            this.涨跌标签.Text = "涨跌标签";
            // 
            // 时间标签
            // 
            this.时间标签.AutoSize = true;
            this.时间标签.Location = new System.Drawing.Point(112, 17);
            this.时间标签.Name = "时间标签";
            this.时间标签.Size = new System.Drawing.Size(53, 12);
            this.时间标签.TabIndex = 12;
            this.时间标签.Text = "时间标签";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.sell_1);
            this.groupBox2.Controls.Add(this.sell_1_price);
            this.groupBox2.Controls.Add(this.sell_2);
            this.groupBox2.Controls.Add(this.sell_2_price);
            this.groupBox2.Controls.Add(this.sell_3);
            this.groupBox2.Controls.Add(this.sell_4);
            this.groupBox2.Controls.Add(this.sell_5);
            this.groupBox2.Controls.Add(this.sell_3_price);
            this.groupBox2.Controls.Add(this.sell_4_price);
            this.groupBox2.Controls.Add(this.sell_5_price);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.buy_1);
            this.groupBox2.Controls.Add(this.buy_1_price);
            this.groupBox2.Controls.Add(this.buy_2);
            this.groupBox2.Controls.Add(this.buy_2_price);
            this.groupBox2.Controls.Add(this.buy_3);
            this.groupBox2.Controls.Add(this.buy_4);
            this.groupBox2.Controls.Add(this.buy_5);
            this.groupBox2.Controls.Add(this.buy_3_price);
            this.groupBox2.Controls.Add(this.buy_4_price);
            this.groupBox2.Controls.Add(this.buy_5_price);
            this.groupBox2.Controls.Add(this.shapeContainer2);
            this.groupBox2.Location = new System.Drawing.Point(584, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 300);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 17);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(160, 280);
            this.shapeContainer2.TabIndex = 11;
            this.shapeContainer2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.涨跌标签);
            this.groupBox3.Controls.Add(this.stock_name);
            this.groupBox3.Controls.Add(this.时间标签);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.当前价格);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.股票名字);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.今日开盘价);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.昨日收盘价);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.今日最高价);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.今日最低价);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.竞买价);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.竞卖价);
            this.groupBox3.Controls.Add(this.成交金额);
            this.groupBox3.Controls.Add(this.成交的股票数);
            this.groupBox3.Location = new System.Drawing.Point(757, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 297);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 660);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_monthly);
            this.Controls.Add(this.text_stockCode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_weekly);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_daily);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.button1);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_daily;
        private System.Windows.Forms.Button btn_weekly;
        private System.Windows.Forms.TextBox text_stockCode;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Label stock_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer index_Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label buy_1;
        private System.Windows.Forms.Label buy_1_price;
        private System.Windows.Forms.Label buy_2;
        private System.Windows.Forms.Label buy_2_price;
        private System.Windows.Forms.Label buy_3;
        private System.Windows.Forms.Label buy_3_price;
        private System.Windows.Forms.Label buy_4;
        private System.Windows.Forms.Label buy_4_price;
        private System.Windows.Forms.Label buy_5;
        private System.Windows.Forms.Label buy_5_price;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label sell_1;
        private System.Windows.Forms.Label sell_1_price;
        private System.Windows.Forms.Label sell_2;
        private System.Windows.Forms.Label sell_2_price;
        private System.Windows.Forms.Label sell_3;
        private System.Windows.Forms.Label sell_4;
        private System.Windows.Forms.Label sell_5;
        private System.Windows.Forms.Label sell_3_price;
        private System.Windows.Forms.Label sell_4_price;
        private System.Windows.Forms.Label sell_5_price;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btn_monthly;
        private System.Windows.Forms.Label 股票名字;
        private System.Windows.Forms.Label 今日开盘价;
        private System.Windows.Forms.Label 昨日收盘价;
        private System.Windows.Forms.Label 当前价格;
        private System.Windows.Forms.Label 今日最高价;
        private System.Windows.Forms.Label 今日最低价;
        private System.Windows.Forms.Label 竞买价;
        private System.Windows.Forms.Label 竞卖价;
        private System.Windows.Forms.Label 成交的股票数;
        private System.Windows.Forms.Label 成交金额;
        private System.Windows.Forms.Label 涨跌标签;
        private System.Windows.Forms.Label 时间标签;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}