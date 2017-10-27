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
                if (info.loss_quantity == 0)
                {
                    this.numericUpDown_loss_quantity.Value = 100;
                }
                else {
                    this.numericUpDown_loss_quantity.Value = info.loss_quantity;
                }
                
                switch (info.loss_tactics)
                {
                    case 1:
                        this.rb_1_1.Select();
                        break;
                    case 2:
                        this.rb_1_2.Select();
                        break;
                    case 3:
                        this.rb_1_3.Select();
                        break;
                    case 4:
                        this.rb_1_4.Select();
                        break;
                    case 5:
                        this.rb_1_5.Select();
                        break;
                    case 6:
                        this.rb_1_6.Select();
                        break;
                    case -1:
                        this.rb_1_0.Select();
                        break;
                    default:
                        break;
                }

                this.numericUpDown_profit_per.Value = Convert.ToDecimal(info.profit_per);
                if (info.profit_quantity == 0)
                {
                    this.numericUpDown_profit_quantity.Value = 100;
                }
                else
                {
                    this.numericUpDown_profit_quantity.Value = info.profit_quantity;
                }

                switch (info.profit_tactics)
                {
                    case 1:
                        this.rb_2_1.Select();
                        break;
                    case 2:
                        this.rb_2_2.Select();
                        break;
                    case 3:
                        this.rb_2_3.Select();
                        break;
                    case 4:
                        this.rb_2_4.Select();
                        break;
                    case 5:
                        this.rb_2_5.Select();
                        break;
                    case 6:
                        this.rb_2_6.Select();
                        break;
                    case -1:
                        this.rb_2_0.Select();
                        break;
                    default:
                        break;
                }
            }
        }

        //下跌设置
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
                case "跌停卖出":
                    this.loss_tactics = 3;
                    break;
                case "跌停买入":
                    this.loss_tactics = 4;
                    break;
                case "转折点买入":
                    this.loss_tactics = 5;
                    break;
                case "转折点卖出":
                    this.loss_tactics = 6;
                    break;
                case "不设置":
                    this.loss_tactics = -1;
                    break;
                default:
                    this.loss_tactics = 0;
                    break;
            }
        }

        //盈利设置
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
                case "涨停买入":
                    this.profit_tactics = 3;
                    break;
                case "涨停卖出":
                    this.profit_tactics = 4;
                    break;
                case "转折点卖出":
                    this.profit_tactics = 5;
                    break;
                case "转折点买入":
                    this.profit_tactics = 6;
                    break;
                case "不设置":
                    this.profit_tactics = -1;
                    break;
                default:
                    this.profit_tactics = 0;
                    break;
            }
        }

        private void btn_submit2_Click(object sender, EventArgs e)
        {
            //止损验证
            this.loss_per = Convert.ToDouble(this.numericUpDown_loss_per.Value);
            this.loss_quantity = Convert.ToInt32(this.numericUpDown_loss_quantity.Value);
            if ((loss_tactics == 1 || loss_tactics == 2) && loss_per <= 0)
            {
                MessageBox.Show("请设置止损百分比！");
                return;
            }
            if ((loss_tactics == 1 || loss_tactics == 2) && loss_quantity % 100 != 0)
            {
                MessageBox.Show("输入的数量应是100的倍数！");
                return;
            }

            //止盈验证
            this.profit_per = Convert.ToDouble(this.numericUpDown_profit_per.Value);
            this.profit_quantity = Convert.ToInt32(this.numericUpDown_profit_quantity.Value);
            if ((profit_tactics == 1 || profit_tactics == 2) && profit_per <= 0)
            {
                MessageBox.Show("请设置止损百分比！");
                return;
            }
            if ((profit_tactics == 1 || profit_tactics == 2) && profit_quantity % 100 != 0)
            {
                MessageBox.Show("输入的数量应是100的倍数！");
                return;
            }

            if (profit_tactics != 0 || loss_tactics != 0) {
                //修改数据库，亏损设置
                Tactics model = new Tactics();
                model.hold_stock_info_id = this.hold_stock_info_id;
                model.loss_per = this.loss_per;
                model.loss_quantity = this.loss_quantity;
                model.loss_tactics = this.loss_tactics;
                model.profit_per = this.profit_per;
                model.profit_quantity = this.profit_quantity;
                model.profit_tactics = this.profit_tactics;
                tacticsService.UpdateTactics(model);
                

                MessageBox.Show(string.Format("设置成功{0} {1}", this.profit_per.ToString(), this.profit_quantity.ToString()));

                this.DialogResult = DialogResult.OK;
                //关闭窗口
                this.Close();
            }
        }

        private void btn_reset2_Click(object sender, EventArgs e)
        {
            this.numericUpDown_profit_per.Value = 0;
            this.numericUpDown_profit_quantity.Value = 100;
        }

    }
}
