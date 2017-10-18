namespace StockSystem
{
    partial class Form_toBuy
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
            this.buy_4 = new System.Windows.Forms.Label();
            this.buy_5 = new System.Windows.Forms.Label();
            this.buy_3_price = new System.Windows.Forms.Label();
            this.buy_4_price = new System.Windows.Forms.Label();
            this.buy_5_price = new System.Windows.Forms.Label();
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
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "买入股票";
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
            this.label31.Text = "买入数量";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 86);
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
            this.label24.Text = "买入价格";
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
            this.groupBox2.Location = new System.Drawing.Point(191, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 161);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "交易信息";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "买一";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "买二";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 9;
            this.label13.Text = "买三";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 9;
            this.label14.Text = "买四";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "买五";
            // 
            // buy_1
            // 
            this.buy_1.AutoSize = true;
            this.buy_1.Location = new System.Drawing.Point(64, 27);
            this.buy_1.Name = "buy_1";
            this.buy_1.Size = new System.Drawing.Size(29, 12);
            this.buy_1.TabIndex = 10;
            this.buy_1.Text = "0.00";
            // 
            // buy_1_price
            // 
            this.buy_1_price.AutoSize = true;
            this.buy_1_price.Location = new System.Drawing.Point(127, 27);
            this.buy_1_price.Name = "buy_1_price";
            this.buy_1_price.Size = new System.Drawing.Size(11, 12);
            this.buy_1_price.TabIndex = 10;
            this.buy_1_price.Text = "0";
            // 
            // buy_2
            // 
            this.buy_2.AutoSize = true;
            this.buy_2.Location = new System.Drawing.Point(64, 53);
            this.buy_2.Name = "buy_2";
            this.buy_2.Size = new System.Drawing.Size(29, 12);
            this.buy_2.TabIndex = 10;
            this.buy_2.Text = "0.00";
            // 
            // buy_2_price
            // 
            this.buy_2_price.AutoSize = true;
            this.buy_2_price.Location = new System.Drawing.Point(127, 53);
            this.buy_2_price.Name = "buy_2_price";
            this.buy_2_price.Size = new System.Drawing.Size(11, 12);
            this.buy_2_price.TabIndex = 10;
            this.buy_2_price.Text = "0";
            // 
            // buy_3
            // 
            this.buy_3.AutoSize = true;
            this.buy_3.Location = new System.Drawing.Point(64, 82);
            this.buy_3.Name = "buy_3";
            this.buy_3.Size = new System.Drawing.Size(29, 12);
            this.buy_3.TabIndex = 10;
            this.buy_3.Text = "0.00";
            // 
            // buy_4
            // 
            this.buy_4.AutoSize = true;
            this.buy_4.Location = new System.Drawing.Point(64, 108);
            this.buy_4.Name = "buy_4";
            this.buy_4.Size = new System.Drawing.Size(29, 12);
            this.buy_4.TabIndex = 10;
            this.buy_4.Text = "0.00";
            // 
            // buy_5
            // 
            this.buy_5.AutoSize = true;
            this.buy_5.Location = new System.Drawing.Point(64, 135);
            this.buy_5.Name = "buy_5";
            this.buy_5.Size = new System.Drawing.Size(29, 12);
            this.buy_5.TabIndex = 10;
            this.buy_5.Text = "0.00";
            // 
            // buy_3_price
            // 
            this.buy_3_price.AutoSize = true;
            this.buy_3_price.Location = new System.Drawing.Point(127, 81);
            this.buy_3_price.Name = "buy_3_price";
            this.buy_3_price.Size = new System.Drawing.Size(11, 12);
            this.buy_3_price.TabIndex = 10;
            this.buy_3_price.Text = "0";
            // 
            // buy_4_price
            // 
            this.buy_4_price.AutoSize = true;
            this.buy_4_price.Location = new System.Drawing.Point(127, 103);
            this.buy_4_price.Name = "buy_4_price";
            this.buy_4_price.Size = new System.Drawing.Size(11, 12);
            this.buy_4_price.TabIndex = 10;
            this.buy_4_price.Text = "0";
            // 
            // buy_5_price
            // 
            this.buy_5_price.AutoSize = true;
            this.buy_5_price.Location = new System.Drawing.Point(127, 134);
            this.buy_5_price.Name = "buy_5_price";
            this.buy_5_price.Size = new System.Drawing.Size(11, 12);
            this.buy_5_price.TabIndex = 10;
            this.buy_5_price.Text = "0";
            // 
            // Form_toBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 338);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form_toBuy";
            this.Text = "Form_toBuy";
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
        private System.Windows.Forms.Label buy_4;
        private System.Windows.Forms.Label buy_5;
        private System.Windows.Forms.Label buy_3_price;
        private System.Windows.Forms.Label buy_4_price;
        private System.Windows.Forms.Label buy_5_price;
    }
}