using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StockSystem.BLL;
using StockSystem.Model;

namespace StockSystem
{
    public partial class Form_ProfitAndLoss : Form
    {
        private TacticsService tacticsService = new TacticsService();

        // 当前持有股票id
        private int hold_stock_info_id;

        //自动止损
        private double loss_per;
        private int loss_quantity;
        private int loss_tactics;

        //自动止盈
        private double profit_per;
        private int profit_quantity;
        private int profit_tactics;

        public Form_ProfitAndLoss(int hold_stock_info_id)
        {
            InitializeComponent();
            this.hold_stock_info_id = hold_stock_info_id;
            display();
        }

        //更新界面信息
        private void display()
        { 
            //查询股票投资策略信息
            Tactics info = tacticsService.getTacticsById(hold_stock_info_id);
            if (info != null)
            {
                this.numericUpDown_loss_per.Value = Convert.ToDecimal(info.loss_per);
                this.numericUpDown_loss_quantity.Value = info.loss_quantity;
                if (info.loss_tactics == 1)
                {
                    this.rb_1_1.Select();
                }
                else if (info.loss_tactics == 2)
                {
                    this.rb_1_2.Select();
                }
                else if (info.loss_tactics == 0)
                {
                    this.rb_1_0.Select();
                }
                this.numericUpDown_profit_per.Value = Convert.ToDecimal(info.profit_per);
                this.numericUpDown_profit_quantity.Value = info.profit_quantity;
                if (info.profit_tactics == 1)
                {
                    this.rb_2_1.Select();
                }
                else if (info.profit_tactics == 2)
                {
                    this.rb_2_2.Select();
                }
                else if (info.profit_tactics == 0)
                {
                    this.rb_2_0.Select();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            switch (((RadioButton)sender).Text.ToString())
            {
                case "下跌减仓":
                    this.loss_tactics = 1;
                    break;
                case "下跌加仓":
                    this.loss_tactics = 2;
                    break;
                default:
                    this.loss_tactics = 0;
                    break;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            switch (((RadioButton)sender).Text.ToString())
            {
                case "盈利减仓":
                    this.profit_tactics = 1;
                    break;
                case "盈利加仓":
                    this.profit_tactics = 2;
                    break;
                default:
                    this.profit_tactics = 0;
                    break;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            this.loss_per = Convert.ToDouble(this.numericUpDown_loss_per.Value);
            this.loss_quantity = Convert.ToInt32(this.numericUpDown_loss_quantity.Value);
            if (loss_tactics == 1 || loss_tactics == 2) {
                if (loss_per <= 0 ) {
                    MessageBox.Show("请设置止损百分比！");
                    return;
                }
                if (loss_quantity % 100 != 0) {
                    MessageBox.Show("输入的数量应是100的倍数！");
                    return;
                }
                if (loss_tactics != 0) {
                    MessageBox.Show(string.Format("设置成功{0} {1}", this.loss_per.ToString(), this.loss_quantity.ToString()));
                    
                    
                }
            }
        }

        private void btn_submit2_Click(object sender, EventArgs e)
        {
            this.profit_per = Convert.ToDouble(this.numericUpDown_profit_per.Value);
            this.profit_quantity = Convert.ToInt32(this.numericUpDown_profit_quantity.Value);
            if (profit_tactics == 1 || profit_tactics == 2)
            {
                if (profit_per <= 0)
                {
                    MessageBox.Show("请设置止损百分比！");
                    return;
                }
                if (profit_quantity % 100 != 0)
                {
                    MessageBox.Show("输入的数量应是100的倍数！");
                    return;
                }
                if (profit_tactics != 0) {
                    MessageBox.Show(string.Format("设置成功{0} {1}", this.profit_per.ToString(), this.profit_quantity.ToString()));

                    this.DialogResult = DialogResult.OK;
                    //关闭窗口
                    this.Close();
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.numericUpDown_loss_per.Value = 0;
            this.numericUpDown_loss_quantity.Value = 100;
        }

        private void btn_reset2_Click(object sender, EventArgs e)
        {
            this.numericUpDown_profit_per.Value = 0;
            this.numericUpDown_profit_quantity.Value = 100;
        }
    }
}
