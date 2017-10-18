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
            this.numericUpDown_buy_quantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_buy_price = new System.Windows.Forms.NumericUpDown();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.textBox_stock_code = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.sell_1_price = new System.Windows.Forms.Label();
            this.sell_2_price = new System.Windows.Forms.Label();
            this.sell_3_price = new System.Windows.Forms.Label();
            this.sell_4_price = new System.Windows.Forms.Label();
            this.sell_5_price = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_buy_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_buy_price)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numericUpDown_buy_quantity);
            this.groupBox6.Controls.Add(this.numericUpDown_buy_price);
            this.groupBox6.Controls.Add(this.btn_reset);
            this.groupBox6.Controls.Add(this.btn_submit);
            this.groupBox6.Controls.Add(this.textBox_stock_code);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.ForeColor = System.Drawing.Color.Red;
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(173, 164);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "卖出股票";
            // 
            // numericUpDown_buy_quantity
            // 
            this.numericUpDown_buy_quantity.Location = new System.Drawing.Point(66, 104);
            this.numericUpDown_buy_quantity.Name = "numericUpDown_buy_quantity";
            this.numericUpDown_buy_quantity.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown_buy_quantity.TabIndex = 4;
            // 
            // numericUpDown_buy_price
            // 
            this.numericUpDown_buy_price.Location = new System.Drawing.Point(66, 60);
            this.numericUpDown_buy_price.Name = "numericUpDown_buy_price";
            this.numericUpDown_buy_price.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown_buy_price.TabIndex = 4;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(11, 130);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(92, 130);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "买入";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // textBox_stock_code
            // 
            this.textBox_stock_code.Location = new System.Drawing.Point(66, 14);
            this.textBox_stock_code.Name = "textBox_stock_code";
            this.textBox_stock_code.Size = new System.Drawing.Size(100, 21);
            this.textBox_stock_code.TabIndex = 2;
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
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 87);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 12);
            this.label25.TabIndex = 1;
            this.label25.Text = "可买（股）";
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
            this.groupBox2.Size = new System.Drawing.Size(193, 161);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "交易信息";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 20);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 11;
            this.label26.Text = "卖一";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 45);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 12);
            this.label27.TabIndex = 12;
            this.label27.Text = "卖二";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(16, 75);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 13;
            this.label28.Text = "卖三";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(16, 103);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 12);
            this.label29.TabIndex = 14;
            this.label29.Text = "卖四";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(16, 131);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 12);
            this.label30.TabIndex = 15;
            this.label30.Text = "卖五";
            // 
            // sell_1
            // 
            this.sell_1.AutoSize = true;
            this.sell_1.Location = new System.Drawing.Point(66, 21);
            this.sell_1.Name = "sell_1";
            this.sell_1.Size = new System.Drawing.Size(29, 12);
            this.sell_1.TabIndex = 16;
            this.sell_1.Text = "0.00";
            // 
            // sell_2
            // 
            this.sell_2.AutoSize = true;
            this.sell_2.Location = new System.Drawing.Point(66, 45);
            this.sell_2.Name = "sell_2";
            this.sell_2.Size = new System.Drawing.Size(29, 12);
            this.sell_2.TabIndex = 17;
            this.sell_2.Text = "0.00";
            // 
            // sell_3
            // 
            this.sell_3.AutoSize = true;
            this.sell_3.Location = new System.Drawing.Point(66, 75);
            this.sell_3.Name = "sell_3";
            this.sell_3.Size = new System.Drawing.Size(29, 12);
            this.sell_3.TabIndex = 18;
            this.sell_3.Text = "0.00";
            // 
            // sell_4
            // 
            this.sell_4.AutoSize = true;
            this.sell_4.Location = new System.Drawing.Point(66, 102);
            this.sell_4.Name = "sell_4";
            this.sell_4.Size = new System.Drawing.Size(29, 12);
            this.sell_4.TabIndex = 19;
            this.sell_4.Text = "0.00";
            // 
            // sell_5
            // 
            this.sell_5.AutoSize = true;
            this.sell_5.Location = new System.Drawing.Point(66, 130);
            this.sell_5.Name = "sell_5";
            this.sell_5.Size = new System.Drawing.Size(29, 12);
            this.sell_5.TabIndex = 20;
            this.sell_5.Text = "0.00";
            // 
            // sell_1_price
            // 
            this.sell_1_price.AutoSize = true;
            this.sell_1_price.Location = new System.Drawing.Point(133, 21);
            this.sell_1_price.Name = "sell_1_price";
            this.sell_1_price.Size = new System.Drawing.Size(11, 12);
            this.sell_1_price.TabIndex = 21;
            this.sell_1_price.Text = "0";
            // 
            // sell_2_price
            // 
            this.sell_2_price.AutoSize = true;
            this.sell_2_price.Location = new System.Drawing.Point(133, 45);
            this.sell_2_price.Name = "sell_2_price";
            this.sell_2_price.Size = new System.Drawing.Size(11, 12);
            this.sell_2_price.TabIndex = 22;
            this.sell_2_price.Text = "0";
            // 
            // sell_3_price
            // 
            this.sell_3_price.AutoSize = true;
            this.sell_3_price.Location = new System.Drawing.Point(133, 75);
            this.sell_3_price.Name = "sell_3_price";
            this.sell_3_price.Size = new System.Drawing.Size(11, 12);
            this.sell_3_price.TabIndex = 23;
            this.sell_3_price.Text = "0";
            // 
            // sell_4_price
            // 
            this.sell_4_price.AutoSize = true;
            this.sell_4_price.Location = new System.Drawing.Point(133, 101);
            this.sell_4_price.Name = "sell_4_price";
            this.sell_4_price.Size = new System.Drawing.Size(11, 12);
            this.sell_4_price.TabIndex = 24;
            this.sell_4_price.Text = "0";
            // 
            // sell_5_price
            // 
            this.sell_5_price.AutoSize = true;
            this.sell_5_price.Location = new System.Drawing.Point(133, 130);
            this.sell_5_price.Name = "sell_5_price";
            this.sell_5_price.Size = new System.Drawing.Size(11, 12);
            this.sell_5_price.TabIndex = 25;
            this.sell_5_price.Text = "0";
            // 
            // Form_toSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 338);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form_toSell";
            this.Text = "Form_toSell";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_buy_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_buy_price)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown_buy_quantity;
        private System.Windows.Forms.NumericUpDown numericUpDown_buy_price;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox textBox_stock_code;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label25;
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
    }
}