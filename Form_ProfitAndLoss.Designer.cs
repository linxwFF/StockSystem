namespace StockSystem
{
    partial class Form_ProfitAndLoss
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_loss_per = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_loss_quantity = new System.Windows.Forms.NumericUpDown();
            this.rb_1_0 = new System.Windows.Forms.RadioButton();
            this.rb_1_2 = new System.Windows.Forms.RadioButton();
            this.rb_1_1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_profit_per = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_profit_quantity = new System.Windows.Forms.NumericUpDown();
            this.rb_2_0 = new System.Windows.Forms.RadioButton();
            this.rb_2_2 = new System.Windows.Forms.RadioButton();
            this.rb_2_1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_reset2 = new System.Windows.Forms.Button();
            this.btn_submit2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_loss_per)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_loss_quantity)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_profit_per)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_profit_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_loss_per);
            this.groupBox1.Controls.Add(this.numericUpDown_loss_quantity);
            this.groupBox1.Controls.Add(this.rb_1_0);
            this.groupBox1.Controls.Add(this.rb_1_2);
            this.groupBox1.Controls.Add(this.rb_1_1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自动止损";
            // 
            // numericUpDown_loss_per
            // 
            this.numericUpDown_loss_per.DecimalPlaces = 2;
            this.numericUpDown_loss_per.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_loss_per.Location = new System.Drawing.Point(58, 23);
            this.numericUpDown_loss_per.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_loss_per.Name = "numericUpDown_loss_per";
            this.numericUpDown_loss_per.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown_loss_per.TabIndex = 8;
            // 
            // numericUpDown_loss_quantity
            // 
            this.numericUpDown_loss_quantity.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_loss_quantity.Location = new System.Drawing.Point(244, 23);
            this.numericUpDown_loss_quantity.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_loss_quantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_loss_quantity.Name = "numericUpDown_loss_quantity";
            this.numericUpDown_loss_quantity.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown_loss_quantity.TabIndex = 7;
            this.numericUpDown_loss_quantity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // rb_1_0
            // 
            this.rb_1_0.AutoSize = true;
            this.rb_1_0.Checked = true;
            this.rb_1_0.Location = new System.Drawing.Point(296, 61);
            this.rb_1_0.Name = "rb_1_0";
            this.rb_1_0.Size = new System.Drawing.Size(59, 16);
            this.rb_1_0.TabIndex = 6;
            this.rb_1_0.TabStop = true;
            this.rb_1_0.Text = "不设置";
            this.rb_1_0.UseVisualStyleBackColor = true;
            this.rb_1_0.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_1_2
            // 
            this.rb_1_2.AutoSize = true;
            this.rb_1_2.Location = new System.Drawing.Point(166, 61);
            this.rb_1_2.Name = "rb_1_2";
            this.rb_1_2.Size = new System.Drawing.Size(71, 16);
            this.rb_1_2.TabIndex = 6;
            this.rb_1_2.Text = "下跌加仓";
            this.rb_1_2.UseVisualStyleBackColor = true;
            this.rb_1_2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_1_1
            // 
            this.rb_1_1.AutoSize = true;
            this.rb_1_1.Location = new System.Drawing.Point(25, 61);
            this.rb_1_1.Name = "rb_1_1";
            this.rb_1_1.Size = new System.Drawing.Size(71, 16);
            this.rb_1_1.TabIndex = 6;
            this.rb_1_1.Text = "下跌减仓";
            this.rb_1_1.UseVisualStyleBackColor = true;
            this.rb_1_1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "股";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "%时";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "卖出";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "下跌";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown_profit_per);
            this.groupBox2.Controls.Add(this.numericUpDown_profit_quantity);
            this.groupBox2.Controls.Add(this.rb_2_0);
            this.groupBox2.Controls.Add(this.rb_2_2);
            this.groupBox2.Controls.Add(this.rb_2_1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(15, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 96);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自动止盈";
            // 
            // numericUpDown_profit_per
            // 
            this.numericUpDown_profit_per.DecimalPlaces = 2;
            this.numericUpDown_profit_per.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_profit_per.Location = new System.Drawing.Point(56, 23);
            this.numericUpDown_profit_per.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_profit_per.Name = "numericUpDown_profit_per";
            this.numericUpDown_profit_per.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown_profit_per.TabIndex = 9;
            // 
            // numericUpDown_profit_quantity
            // 
            this.numericUpDown_profit_quantity.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_profit_quantity.Location = new System.Drawing.Point(244, 25);
            this.numericUpDown_profit_quantity.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_profit_quantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_profit_quantity.Name = "numericUpDown_profit_quantity";
            this.numericUpDown_profit_quantity.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown_profit_quantity.TabIndex = 8;
            this.numericUpDown_profit_quantity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // rb_2_0
            // 
            this.rb_2_0.AutoSize = true;
            this.rb_2_0.Checked = true;
            this.rb_2_0.Location = new System.Drawing.Point(294, 61);
            this.rb_2_0.Name = "rb_2_0";
            this.rb_2_0.Size = new System.Drawing.Size(59, 16);
            this.rb_2_0.TabIndex = 6;
            this.rb_2_0.TabStop = true;
            this.rb_2_0.Text = "不设置";
            this.rb_2_0.UseVisualStyleBackColor = true;
            this.rb_2_0.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // rb_2_2
            // 
            this.rb_2_2.AutoSize = true;
            this.rb_2_2.Location = new System.Drawing.Point(166, 61);
            this.rb_2_2.Name = "rb_2_2";
            this.rb_2_2.Size = new System.Drawing.Size(71, 16);
            this.rb_2_2.TabIndex = 6;
            this.rb_2_2.Text = "盈利加仓";
            this.rb_2_2.UseVisualStyleBackColor = true;
            this.rb_2_2.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // rb_2_1
            // 
            this.rb_2_1.AutoSize = true;
            this.rb_2_1.Location = new System.Drawing.Point(25, 61);
            this.rb_2_1.Name = "rb_2_1";
            this.rb_2_1.Size = new System.Drawing.Size(71, 16);
            this.rb_2_1.TabIndex = 6;
            this.rb_2_1.Text = "盈利减仓";
            this.rb_2_1.UseVisualStyleBackColor = true;
            this.rb_2_1.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "股";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "%时";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "买入";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "上涨";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(96, 127);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(257, 127);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "提交";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_reset2
            // 
            this.btn_reset2.Location = new System.Drawing.Point(96, 255);
            this.btn_reset2.Name = "btn_reset2";
            this.btn_reset2.Size = new System.Drawing.Size(75, 23);
            this.btn_reset2.TabIndex = 4;
            this.btn_reset2.Text = "重置";
            this.btn_reset2.UseVisualStyleBackColor = true;
            this.btn_reset2.Click += new System.EventHandler(this.btn_reset2_Click);
            // 
            // btn_submit2
            // 
            this.btn_submit2.Location = new System.Drawing.Point(259, 255);
            this.btn_submit2.Name = "btn_submit2";
            this.btn_submit2.Size = new System.Drawing.Size(75, 23);
            this.btn_submit2.TabIndex = 5;
            this.btn_submit2.Text = "提交";
            this.btn_submit2.UseVisualStyleBackColor = true;
            this.btn_submit2.Click += new System.EventHandler(this.btn_submit2_Click);
            // 
            // Form_ProfitAndLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 291);
            this.Controls.Add(this.btn_submit2);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_reset2);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_ProfitAndLoss";
            this.Text = "Form_ProfitAndLoss";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_loss_per)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_loss_quantity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_profit_per)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_profit_quantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_1_2;
        private System.Windows.Forms.RadioButton rb_1_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_2_2;
        private System.Windows.Forms.RadioButton rb_2_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_loss_quantity;
        private System.Windows.Forms.NumericUpDown numericUpDown_profit_quantity;
        private System.Windows.Forms.NumericUpDown numericUpDown_loss_per;
        private System.Windows.Forms.NumericUpDown numericUpDown_profit_per;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.RadioButton rb_1_0;
        private System.Windows.Forms.RadioButton rb_2_0;
        private System.Windows.Forms.Button btn_reset2;
        private System.Windows.Forms.Button btn_submit2;
    }
}