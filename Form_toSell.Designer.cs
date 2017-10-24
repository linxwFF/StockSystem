namespace StockSystem
{
    partial class Form_toSell
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lab_cansell = new System.Windows.Forms.Label();
            this.lab_get_money = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_stock_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_max = new System.Windows.Forms.Button();
            this.numericUpDown_sell_quantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_sell_price = new System.Windows.Forms.NumericUpDown();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.textBox_stock_code = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.涨跌标签 = new System.Windows.Forms.Label();
            this.时间标签 = new System.Windows.Forms.Label();
            this.sell_1_price = new System.Windows.Forms.Label();
            this.sell_2_price = new System.Windows.Forms.Label();
            this.sell_3_price = new System.Windows.Forms.Label();
            this.sell_4_price = new System.Windows.Forms.Label();
            this.sell_5_price = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.sell_1 = new System.Windows.Forms.Label();
            this.sell_2 = new System.Windows.Forms.Label();
            this.sell_3 = new System.Windows.Forms.Label();
            this.sell_4 = new System.Windows.Forms.Label();
            this.sell_5 = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sell_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sell_price)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lab_cansell);
            this.groupBox6.Controls.Add(this.lab_get_money);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.lab_stock_name);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.btn_max);
            this.groupBox6.Controls.Add(this.numericUpDown_sell_quantity);
            this.groupBox6.Controls.Add(this.numericUpDown_sell_price);
            this.groupBox6.Controls.Add(this.btn_reset);
            this.groupBox6.Controls.Add(this.btn_submit);
            this.groupBox6.Controls.Add(this.textBox_stock_code);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.ForeColor = System.Drawing.Color.Green;
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(173, 188);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "卖出股票";
            // 
            // lab_cansell
            // 
            this.lab_cansell.AutoSize = true;
            this.lab_cansell.Location = new System.Drawing.Point(64, 88);
            this.lab_cansell.Name = "lab_cansell";
            this.lab_cansell.Size = new System.Drawing.Size(11, 12);
            this.lab_cansell.TabIndex = 18;
            this.lab_cansell.Text = "0";
            // 
            // lab_get_money
            // 
            this.lab_get_money.AutoSize = true;
            this.lab_get_money.Location = new System.Drawing.Point(64, 132);
            this.lab_get_money.Name = "lab_get_money";
            this.lab_get_money.Size = new System.Drawing.Size(29, 12);
            this.lab_get_money.TabIndex = 16;
            this.lab_get_money.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "卖出金额";
            // 
            // lab_stock_name
            // 
            this.lab_stock_name.AutoSize = true;
            this.lab_stock_name.Location = new System.Drawing.Point(68, 42);
            this.lab_stock_name.Name = "lab_stock_name";
            this.lab_stock_name.Size = new System.Drawing.Size(0, 12);
            this.lab_stock_name.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "可卖（股）";
            // 
            // btn_max
            // 
            this.btn_max.Enabled = false;
            this.btn_max.Location = new System.Drawing.Point(128, 84);
            this.btn_max.Margin = new System.Windows.Forms.Padding(0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(38, 20);
            this.btn_max.TabIndex = 13;
            this.btn_max.Text = "最大";
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // numericUpDown_sell_quantity
            // 
            this.numericUpDown_sell_quantity.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_sell_quantity.Location = new System.Drawing.Point(64, 106);
            this.numericUpDown_sell_quantity.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_sell_quantity.Name = "numericUpDown_sell_quantity";
            this.numericUpDown_sell_quantity.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown_sell_quantity.TabIndex = 11;
            this.numericUpDown_sell_quantity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_sell_quantity.ValueChanged += new System.EventHandler(this.numericUpDown_buy_quantity_ValueChanged);
            // 
            // numericUpDown_sell_price
            // 
            this.numericUpDown_sell_price.DecimalPlaces = 2;
            this.numericUpDown_sell_price.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_sell_price.Location = new System.Drawing.Point(64, 61);
            this.numericUpDown_sell_price.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_sell_price.Name = "numericUpDown_sell_price";
            this.numericUpDown_sell_price.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown_sell_price.TabIndex = 12;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(11, 154);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(91, 154);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "卖出";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // textBox_stock_code
            // 
            this.textBox_stock_code.Location = new System.Drawing.Point(66, 14);
            this.textBox_stock_code.Name = "textBox_stock_code";
            this.textBox_stock_code.Size = new System.Drawing.Size(100, 21);
            this.textBox_stock_code.TabIndex = 2;
            this.textBox_stock_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_stockCode_KeyDown);
            this.textBox_stock_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_stockCode_KeyPress);
            this.textBox_stock_code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_stockCode_KeyUp);
            this.textBox_stock_code.MouseLeave += new System.EventHandler(this.textBox_stock_code_MouseLeave);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(9, 110);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 12);
            this.label31.TabIndex = 1;
            this.label31.Text = "卖出数量";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 64);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 12);
            this.label24.TabIndex = 1;
            this.label24.Text = "卖出价格";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 1;
            this.label23.Text = "证券名称";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "证卷代码";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.涨跌标签);
            this.groupBox2.Controls.Add(this.时间标签);
            this.groupBox2.Controls.Add(this.sell_1_price);
            this.groupBox2.Controls.Add(this.sell_2_price);
            this.groupBox2.Controls.Add(this.sell_3_price);
            this.groupBox2.Controls.Add(this.sell_4_price);
            this.groupBox2.Controls.Add(this.sell_5_price);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.sell_1);
            this.groupBox2.Controls.Add(this.sell_2);
            this.groupBox2.Controls.Add(this.sell_3);
            this.groupBox2.Controls.Add(this.sell_4);
            this.groupBox2.Controls.Add(this.sell_5);
            this.groupBox2.Location = new System.Drawing.Point(191, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 185);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "交易信息";
            // 
            // 涨跌标签
            // 
            this.涨跌标签.AutoSize = true;
            this.涨跌标签.Location = new System.Drawing.Point(16, 159);
            this.涨跌标签.Name = "涨跌标签";
            this.涨跌标签.Size = new System.Drawing.Size(53, 12);
            this.涨跌标签.TabIndex = 27;
            this.涨跌标签.Text = "涨跌标签";
            // 
            // 时间标签
            // 
            this.时间标签.AutoSize = true;
            this.时间标签.Location = new System.Drawing.Point(16, 17);
            this.时间标签.Name = "时间标签";
            this.时间标签.Size = new System.Drawing.Size(53, 12);
            this.时间标签.TabIndex = 26;
            this.时间标签.Text = "时间标签";
            // 
            // sell_1_price
            // 
            this.sell_1_price.AutoSize = true;
            this.sell_1_price.Location = new System.Drawing.Point(133, 36);
            this.sell_1_price.Name = "sell_1_price";
            this.sell_1_price.Size = new System.Drawing.Size(11, 12);
            this.sell_1_price.TabIndex = 21;
            this.sell_1_price.Text = "0";
            // 
            // sell_2_price
            // 
            this.sell_2_price.AutoSize = true;
            this.sell_2_price.Location = new System.Drawing.Point(133, 57);
            this.sell_2_price.Name = "sell_2_price";
            this.sell_2_price.Size = new System.Drawing.Size(11, 12);
            this.sell_2_price.TabIndex = 22;
            this.sell_2_price.Text = "0";
            // 
            // sell_3_price
            // 
            this.sell_3_price.AutoSize = true;
            this.sell_3_price.Location = new System.Drawing.Point(133, 81);
            this.sell_3_price.Name = "sell_3_price";
            this.sell_3_price.Size = new System.Drawing.Size(11, 12);
            this.sell_3_price.TabIndex = 23;
            this.sell_3_price.Text = "0";
            // 
            // sell_4_price
            // 
            this.sell_4_price.AutoSize = true;
            this.sell_4_price.Location = new System.Drawing.Point(133, 103);
            this.sell_4_price.Name = "sell_4_price";
            this.sell_4_price.Size = new System.Drawing.Size(11, 12);
            this.sell_4_price.TabIndex = 24;
            this.sell_4_price.Text = "0";
            // 
            // sell_5_price
            // 
            this.sell_5_price.AutoSize = true;
            this.sell_5_price.Location = new System.Drawing.Point(133, 128);
            this.sell_5_price.Name = "sell_5_price";
            this.sell_5_price.Size = new System.Drawing.Size(11, 12);
            this.sell_5_price.TabIndex = 25;
            this.sell_5_price.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 35);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 11;
            this.label26.Text = "卖一";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 57);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 12);
            this.label27.TabIndex = 12;
            this.label27.Text = "卖二";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(16, 81);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 13;
            this.label28.Text = "卖三";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(16, 105);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 12);
            this.label29.TabIndex = 14;
            this.label29.Text = "卖四";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(16, 129);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 12);
            this.label30.TabIndex = 15;
            this.label30.Text = "卖五";
            // 
            // sell_1
            // 
            this.sell_1.AutoSize = true;
            this.sell_1.Location = new System.Drawing.Point(66, 36);
            this.sell_1.Name = "sell_1";
            this.sell_1.Size = new System.Drawing.Size(29, 12);
            this.sell_1.TabIndex = 16;
            this.sell_1.Text = "0.00";
            // 
            // sell_2
            // 
            this.sell_2.AutoSize = true;
            this.sell_2.Location = new System.Drawing.Point(66, 57);
            this.sell_2.Name = "sell_2";
            this.sell_2.Size = new System.Drawing.Size(29, 12);
            this.sell_2.TabIndex = 17;
            this.sell_2.Text = "0.00";
            // 
            // sell_3
            // 
            this.sell_3.AutoSize = true;
            this.sell_3.Location = new System.Drawing.Point(66, 81);
            this.sell_3.Name = "sell_3";
            this.sell_3.Size = new System.Drawing.Size(29, 12);
            this.sell_3.TabIndex = 18;
            this.sell_3.Text = "0.00";
            // 
            // sell_4
            // 
            this.sell_4.AutoSize = true;
            this.sell_4.Location = new System.Drawing.Point(66, 104);
            this.sell_4.Name = "sell_4";
            this.sell_4.Size = new System.Drawing.Size(29, 12);
            this.sell_4.TabIndex = 19;
            this.sell_4.Text = "0.00";
            // 
            // sell_5
            // 
            this.sell_5.AutoSize = true;
            this.sell_5.Location = new System.Drawing.Point(66, 128);
            this.sell_5.Name = "sell_5";
            this.sell_5.Size = new System.Drawing.Size(29, 12);
            this.sell_5.TabIndex = 20;
            this.sell_5.Text = "0.00";
            // 
            // Form_toSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 212);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form_toSell";
            this.Text = "Form_toSell";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sell_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sell_price)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox textBox_stock_code;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label sell_1;
        private System.Windows.Forms.Label sell_2;
        private System.Windows.Forms.Label sell_3;
        private System.Windows.Forms.Label sell_4;
        private System.Windows.Forms.Label sell_5;
        private System.Windows.Forms.Label sell_1_price;
        private System.Windows.Forms.Label sell_2_price;
        private System.Windows.Forms.Label sell_3_price;
        private System.Windows.Forms.Label sell_4_price;
        private System.Windows.Forms.Label sell_5_price;
        private System.Windows.Forms.Label 时间标签;
        private System.Windows.Forms.Label 涨跌标签;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.NumericUpDown numericUpDown_sell_quantity;
        private System.Windows.Forms.NumericUpDown numericUpDown_sell_price;
        private System.Windows.Forms.Label lab_stock_name;
        private System.Windows.Forms.Label lab_get_money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_cansell;
        private System.Windows.Forms.Label label2;
    }
}