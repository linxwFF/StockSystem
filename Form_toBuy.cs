using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using StockSystem.BLL;
using StockSystem.Model;
using System.Configuration;

namespace StockSystem
{
    public partial class Form_toBuy : Form
    {
        private Stock_HolderService stock_HolderService = new Stock_HolderService();
        private CommissionService commissionService = new CommissionService();

        // 布尔标志，用来确定输入的是否是字符.
        private bool nonNumberEntered = false;
        // 当前股票代码信息
        private string stock_code;
        // 当前股票名称
        private string stock_name;

        private double buy_price;
        private int buy_quantity;
        private int canBuy;
        private double current_price;
        // 是否是有效的股票
        private bool isCanBuy;  //http://finance.sina.com.cn/data/#stock-schq-hsgs-qbag  可买的A股代码数据大全
        private Hold_Stock_Info hold_stock_info_select;    //选中要卖出的股票信息

        public Form_toBuy(string stock_code = "")
        {
            InitializeComponent();
            this.buy_quantity = 100;
            
            if (stock_code != "") {
                this.stock_code = stock_code;
                this.textBox_stock_code.Text = stock_code;
                SendKeys.Send("{ENTER}");
            }
        }

        //查询特定的股票信息
        private void textBox_stock_code_MouseLeave(object sender, EventArgs e)
        {
            if (this.textBox_stock_code.Text.Trim() != "")
            {
                this.stock_code = "sh" + this.textBox_stock_code.Text;
                query(this.stock_code);
            }
        }

        private void text_stockCode_KeyDown(object sender, KeyEventArgs e)
        {
            // 初始化标记为 false.
            nonNumberEntered = false;

            // 确定是否键盘上一排的数字键.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // 确定是否小键盘数字键.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // 确定是否退格键.
                    if (e.KeyCode != Keys.Back)
                    {
                        // 如果一个非数字键按下.
                        // 设置标志为 true 到 KeyPress 事件中.
                        nonNumberEntered = true;
                    }
                }
            }

            //按下 Shift 按键同上.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }

            // 按下回车键调用查询股票方法
            if (e.KeyCode == Keys.Enter)
            {
                if (this.textBox_stock_code.Text.Trim() != "")
                {
                    this.stock_code = "sh" + this.textBox_stock_code.Text;
                    query(this.stock_code);
                }
            }
        }

        private void text_stockCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 检查 KeyDown 事件中的标志.
            if (nonNumberEntered == true)
            {
                // 停止输入，因为它不是数字键.
                e.Handled = true;
            }
        }

        private void text_stockCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBox_stock_code.Focus();
                this.textBox_stock_code.SelectAll();
            }
        }

        //定时获取上证指数等信息
        private void query(string stock_code)
        {
            string stock_data_content;  //股票数据内容

            WebRequest req = WebRequest.Create("http://hq.sinajs.cn/list=" + stock_code);//上证指数

            WebResponse resp = req.GetResponse();

            Stream stream = resp.GetResponseStream();

            StreamReader streamReader = new StreamReader(stream, Encoding.Default);

            stock_data_content = streamReader.ReadToEnd();

            //股票数据
            string stock_data = stock_data_content.Substring(stock_data_content.IndexOf("\"") + 1, (stock_data_content.LastIndexOf("\"") - stock_data_content.IndexOf("\"") - 1));
            string[] divide = new string[] { "," };
            string[] divide_result;

            divide_result = stock_data.Split(divide, StringSplitOptions.None);

            if (divide_result.Length != 33)
            {
                //MessageBox.Show("数据信息获取错误，请输入正确的上证代码！");
                this.isCanBuy = false;
                return;
            }
            else {
                this.isCanBuy = true;
            }

            this.时间标签.Text = divide_result[30] + " " + divide_result[31];
            //买
            this.buy_1.Text = divide_result[10];
            this.buy_1_price.Text = divide_result[11];

            this.buy_2.Text = divide_result[12];
            this.buy_2_price.Text = divide_result[13];

            this.buy_3.Text = divide_result[14];
            this.buy_3_price.Text = divide_result[15];

            this.buy_4.Text = divide_result[16];
            this.buy_4_price.Text = divide_result[17];

            this.buy_5.Text = divide_result[18];
            this.buy_5_price.Text = divide_result[19];

            this.涨跌标签.Text = "涨跌:" + (double.Parse(divide_result[3]) - double.Parse(divide_result[2])).ToString("f2");
            if (double.Parse(divide_result[3]) >= double.Parse(divide_result[2]))
            {
                this.涨跌标签.ForeColor = Color.Red;
            }
            else
            {
                this.涨跌标签.ForeColor = Color.Chartreuse;
            }
            this.lab_stock_name.Text = divide_result[0];
            this.stock_name = divide_result[0];

            //计算可买股票数量
            int stock_id = Utility.user.id;
            Stock_Holder sh = stock_HolderService.getStockHolder(stock_id);

            //是否是持有的股票代码
            if (sh.HoldStockInfo != null) {
                var datalist = sh.HoldStockInfo.Where(hsi => hsi.stock_code.Equals(stock_code)).ToList();
                if (datalist.Count != 0)
                {
                    this.hold_stock_info_select = datalist[0];
                }
            }

            //当前价
            this.current_price = double.Parse(divide_result[3]);

            double bankroll_useable = sh.account.bankroll_useable;
            this.canBuy = (int)(bankroll_useable / this.current_price);

            this.lab_canbuy.Text = canBuy.ToString();
            this.btn_max.Enabled = true;

            //买入的默认价格
            this.numericUpDown_buy_price.Value = Convert.ToDecimal(divide_result[3]);
        }

        private void numericUpDown_buy_quantity_ValueChanged(object sender, EventArgs e)
        {
            //所需要的总金额
            this.buy_price = Convert.ToDouble(this.numericUpDown_buy_price.Value);
            this.buy_quantity = Convert.ToInt32(this.numericUpDown_buy_quantity.Value);
            if (this.buy_quantity > this.canBuy) {
                this.buy_quantity = 100;
                MessageBox.Show("购买数量不能超过可买数量！");
            }
            if (this.buy_quantity / 100 == 0) {
                this.buy_quantity = 100;
                MessageBox.Show("购买数量为100的倍数！");
            }
            this.lab_need_money.Text = Convert.ToDouble(buy_price * buy_quantity).ToString();
        }

        //买入按钮
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (this.buy_quantity == 0)
            {
                MessageBox.Show("请输入购买数量!");
                return;
            }
            if (!this.isCanBuy) 
            {
                MessageBox.Show("请输入有效的A股代码!");
                return;
            }
            //MessageBox.Show(string.Format("买入价格：{0}, 买入数量：{1}",this.buy_price,this.buy_quantity));

            //生成买入的委托记录
            Commission model = new Commission();
            model.hold_stock_info = this.hold_stock_info_select;
            model.commission_price = this.buy_price;
            model.commission_amount = this.buy_quantity;
            // 1.买入 2. 卖出
            model.direction = 1;
            // 状态：1.已撤销 2.已成交 3.已提交（默认值）
            model.state = 3;
            model.remain = this.buy_quantity;
            model.stockholder_id = Utility.user.id;

            if (this.hold_stock_info_select == null)
            {
                //生成持有股票记录 （数据库中无持有此股票）
                Hold_Stock_Info holdStockInfo = new Hold_Stock_Info();
                holdStockInfo.stock_name = this.stock_name;
                holdStockInfo.stock_code = this.stock_code;
                holdStockInfo.amount_useable = 0;
                holdStockInfo.hold_quantity = this.buy_quantity;
                holdStockInfo.cost_price = this.buy_price * this.buy_quantity;
                holdStockInfo.stock_holder_id = Utility.user.id;
                holdStockInfo.type = 1;
                commissionService.AddCommission(model, holdStockInfo);

                //委托交易成功后，减少 bankroll的金额 cost_price
                //TODO 

            } else {
                commissionService.AddCommission(model, this.hold_stock_info_select);

                commissionService.UpdateAmountUseableBuy(this.buy_quantity,this.buy_price, this.hold_stock_info_select);
                //委托交易成功后，减少 bankroll的金额
                //TODO


            }

            this.DialogResult = DialogResult.OK;
            //关闭窗口
            this.Close();
        }

        //重置按钮
        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.numericUpDown_buy_price.Value = Convert.ToDecimal(this.current_price);
            this.numericUpDown_buy_quantity.Value = 100;
            this.numericUpDown_buy_price.Focus();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.numericUpDown_buy_quantity.Value = (this.canBuy/100) * 100;
        }
    }
}