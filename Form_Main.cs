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
    public partial class Form_Main : Form
    {
        private Stock_HolderService stock_HolderService = new Stock_HolderService();
        private CommissionService commissionService = new CommissionService();
        private Personal_Stock_AccountService accountService = new Personal_Stock_AccountService();
        private Hold_Stock_InfoService holdStockInfoService = new Hold_Stock_InfoService();

        // 布尔标志，用来确定输入的是否是字符.
        private bool nonNumberEntered = false;
        // 布尔标志， 用来确定查询是否有结果
        private bool isReachResult = true;

        // 当前股票代码信息
        private string stock_code;
        // K线
        private string stock_k_url;
        //当前帐号ID
        private int stock_id;

        //选中的索引号
        private int SelectedIndices;
        // 当前股票id 
        private int hold_stock_info_id;
        // 当前股票可卖出状态
        private bool canSellState = true;

        //选中行右键状态
        private bool canRightClick = true;

        //当前持有股票的总价值
        private double CountStockAssets;

        //当前查询出的股票信息
        private Hold_Stock_Info ReachInfo;

        public Form_Main()
        {
            InitializeComponent();
            //最大化窗口
            this.WindowState = FormWindowState.Maximized;
            stock_code = "sh000001";
            stock_k_url = "http://image2.sinajs.cn/newchart/min/n/";
            //获取用户ID
            stock_id = Utility.user.id;
            
            // 定时间隔
            this.index_Timer.Interval = 10000;
            // 请求上证指数
            this.timer1.Interval = 10000;
            // 开始刷新
            start_Refresh();

            query();
            default_query(stock_code, stock_k_url);
        }
        

        private string default_query(string stock_code, string stock_k_model) 
        {
            
            string stock_data_content;  //股票数据内容

            WebRequest req = WebRequest.Create("http://hq.sinajs.cn/list=" + stock_code);

            WebResponse resp = req.GetResponse();

            Stream stream = resp.GetResponseStream();

            StreamReader streamReader = new StreamReader(stream, Encoding.Default);

            stock_data_content = streamReader.ReadToEnd();

            showData(stock_data_content,stock_k_model) ;

            return stock_data_content;
        }

        //显示数据
        private bool showData(string stock_data_content, string stock_k_model) 
        {
             //股票数据
            string stock_data = stock_data_content.Substring(stock_data_content.IndexOf("\"") +  1, (stock_data_content.LastIndexOf("\"") - stock_data_content.IndexOf("\"") - 1));
            string[] divide = new string[] { "," };
            string[] divide_result;

            divide_result = stock_data.Split(divide, StringSplitOptions.None);

            // K线图
            this.pictureBox1.ImageLocation = stock_k_model + stock_code + ".gif";

            if (divide_result.Length != 33)
            {
                this.isReachResult = false;
                //MessageBox.Show("数据信息获取错误，请输入正确的上证代码！");
                return false;
            }

            if (this.股票名字.Text != divide_result[0])
            {
                this.股票名字.Text = divide_result[0];
            }

            this.今日开盘价.Text = divide_result[1];
            this.昨日收盘价.Text = divide_result[2];

            this.当前价格.Text = double.Parse(divide_result[3]).ToString("f2");
            for (int i = 0; i < 2; i++)
            {
                this.当前价格.ForeColor = Color.White;
                if (double.Parse(divide_result[3]) >= double.Parse(divide_result[2]))
                    this.当前价格.ForeColor = Color.Red;
                else
                    this.当前价格.ForeColor = Color.Chartreuse;
            }

            this.今日最高价.Text = divide_result[4];
            this.今日最低价.Text = divide_result[5];
            this.竞买价.Text = divide_result[6];
            this.竞卖价.Text = divide_result[7];
            this.成交的股票数.Text = divide_result[8];
            this.成交金额.Text = divide_result[9];

            this.涨跌标签.Text = "涨跌:" + (double.Parse(divide_result[3]) - double.Parse(divide_result[2])).ToString("f2");
            if (double.Parse(divide_result[3]) >= double.Parse(divide_result[2]))
            {
                this.涨跌标签.ForeColor = Color.Red;
            }
            else
            {
                this.涨跌标签.ForeColor = Color.Chartreuse;
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

            //卖
            this.sell_1.Text = divide_result[20];
            this.sell_1_price.Text = divide_result[21];

            this.sell_2.Text = divide_result[22];
            this.sell_2_price.Text = divide_result[23];

            this.sell_3.Text = divide_result[24];
            this.sell_3_price.Text = divide_result[25];

            this.sell_4.Text = divide_result[26];
            this.sell_4_price.Text = divide_result[27];

            this.sell_5.Text = divide_result[28];
            this.sell_5_price.Text = divide_result[29];

            //存储股票搜索信息
            Hold_Stock_Info result = new Hold_Stock_Info();
            result.stock_name = divide_result[0];
            this.ReachInfo = result;

            this.isReachResult = true;

            return true;
        }

        //持股信息定时器 10S一次
        private void index_Timer_Tick(object sender, EventArgs e)
        {
            //更新数据库的股东持仓信息
            stock_HolderService.updateStockHolderInfo(stock_id);
            LoadData();

            //结算股东账户
            accountService.updateTotalStock(this.CountStockAssets);
        }
        //上证指数 定时器10S一次
        private void timer1_Tick(object sender, EventArgs e)
        {
            query();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.stock_k_url = "http://image2.sinajs.cn/newchart/min/n/";
            default_query(this.stock_code, this.stock_k_url);
        }

        private void btn_daily_Click(object sender, EventArgs e)
        {
            this.stock_k_url = "http://image.sinajs.cn/newchart/daily/n/";
            default_query(this.stock_code, this.stock_k_url);
        }

        private void btn_weekly_Click(object sender, EventArgs e)
        {
            this.stock_k_url = "http://image.sinajs.cn/newchart/weekly/n/";
            default_query(this.stock_code, this.stock_k_url);
        }

        private void btn_monthly_Click(object sender, EventArgs e)
        {
            this.stock_k_url = "http://image.sinajs.cn/newchart/monthly/n/";
            default_query(this.stock_code, this.stock_k_url);
        }

        //窗体加载事件
        private void Form_Main_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //加载所有信息
        private void LoadData()
        {
            DataBinding_Stock_Holder();
            DataBinding_Account_info();
            DataBinding_Commission();
            DataBinding_Optional();
        }

        //数据绑定 （优选股）
        //todo

        //数据绑定 （用户自选股）
        private void DataBinding_Optional()
        {
            listView_Optional.Items.Clear();
            List<Hold_Stock_Info> listOptional = holdStockInfoService.GetAllOptionalStock(Utility.user.id);
            foreach (Hold_Stock_Info item in listOptional)
            {
                ListViewItem Lvitem = new ListViewItem(item.stock_name);
                Lvitem.SubItems.Add(item.stock_code);

                this.listView_Optional.Items.Add(Lvitem);
            }
        }

        //数据绑定（用户账户信息）
        private void DataBinding_Account_info()
        {
            Stock_Holder sh = Utility.user;
            //账户信息
            this.lab_bankroll.Text = sh.account.bankroll.ToString("f2");
            this.lab_bankroll_freezed.Text = sh.account.bankroll.ToString("f2");
            this.lab_bankroll_in_cash.Text = sh.account.bankroll_in_cash.ToString("f2");
            this.lab_bankroll_useable.Text = sh.account.bankroll_useable.ToString("f2");
            this.lab_total.Text = sh.account.total.ToString("f2");
            this.lab_total_stock.Text = sh.account.total_stock.ToString("f2");
        }

        //数据绑定 （委托记录）
        private void DataBinding_Commission()
        {
            //委托记录信息
            listView2.Items.Clear();
            List<Commission> lisCom = commissionService.GetAllCommissionById(Utility.user.id);
            foreach (Commission item in lisCom)
            {
                ListViewItem Lvitem = new ListViewItem(item.hold_stock_info.stock_code);
                Lvitem.SubItems.Add(item.commission_price.ToString());
                if (item.direction == 1)
                {
                    Lvitem.SubItems.Add("买入");
                }
                else if (item.direction == 2)
                {
                    Lvitem.SubItems.Add("卖出");
                }

                Lvitem.SubItems.Add(item.commission_amount.ToString());
                Lvitem.SubItems.Add(item.remain.ToString());
                switch (item.state)
                {
                    case 1:
                        Lvitem.SubItems.Add("已撤单");
                        break;
                    case 2:
                        Lvitem.SubItems.Add("已成交");
                        break;
                    case 3:
                        Lvitem.SubItems.Add("已提交");
                        break;
                }
                Lvitem.SubItems.Add(item.time.ToString());
                this.listView2.Items.Add(Lvitem);
            }
        }

        //ListView 窗口数据绑定（持有股票信息）
        private void DataBinding_Stock_Holder()
        {
            Stock_Holder sh = stock_HolderService.getStockHolder(Utility.user.id);
            if (sh.HoldStockInfo == null) { return; }
            //持有股票信息
            listView1.Items.Clear();
            string tempString;

            double stockTotalAssets = 0;            //持有股票总价值
            double lossProfit = 0;                       //盈亏
            double lossProfitPer = 0;                  //盈亏百分比

            foreach(Hold_Stock_Info item in sh.HoldStockInfo)
            {
                ListViewItem Lvitem = new ListViewItem(item.stock_name);
                Lvitem.SubItems.Add(item.stock_code);
                Lvitem.SubItems.Add(item.amount_useable.ToString());
                Lvitem.SubItems.Add(item.hold_quantity.ToString());
                Lvitem.SubItems.Add(item.market_price.ToString());
                //计算持有股票总价值
                stockTotalAssets += item.market_price;
                Lvitem.SubItems.Add(item.profit_loss.ToString());
                //计算总盈亏
                lossProfit += item.profit_loss;
                Lvitem.SubItems.Add(item.profit_loss_per.ToString("f2"));
                //计算总盈亏百分比
                lossProfitPer += item.profit_loss_per;
                Lvitem.SubItems.Add(item.current_price.ToString("f2"));
                Lvitem.SubItems.Add(item.cost_price.ToString());

                if (item.tactics != null && item.tactics.profit_tactics == 1)
                {
                    //上涨减仓
                    tempString = string.Format("上涨{0}%,卖出{1}股", item.tactics.profit_per, item.tactics.profit_quantity);
                }
                else if (item.tactics != null && item.tactics.profit_tactics == 2)
                {
                    //上涨加仓
                    tempString = string.Format("上涨{0}%,买入{1}股", item.tactics.profit_per, item.tactics.profit_quantity);
                }else if(item.tactics.profit_tactics == 3){
                    tempString = string.Format("涨停买入,买入{0}股", item.tactics.profit_quantity);
                }
                else if (item.tactics.profit_tactics == 4) {
                    tempString = string.Format("涨停卖出,卖出{0}股", item.tactics.profit_quantity);
                }
                else if (item.tactics.profit_tactics == 5) {
                    tempString = string.Format("转折点卖出,卖出{0}股", item.tactics.profit_quantity);
                }
                else if (item.tactics.profit_tactics == 6) {
                    tempString = string.Format("转折点买入,买入{0}股", item.tactics.profit_quantity);
                }
                else
                {
                    tempString = string.Format(" ");
                }

                Lvitem.SubItems.Add(tempString);

                if(item.tactics != null && item.tactics.loss_tactics == 1 && item.tactics.loss_per != 0)
                {
                    //下跌减仓
                    tempString = string.Format("下跌{0}%,卖出{1}股", item.tactics.loss_per,item.tactics.loss_quantity);
                }
                else if (item.tactics != null && item.tactics.loss_tactics == 2 && item.tactics.loss_per != 0)
                {
                    //下跌加仓
                    tempString = string.Format("下跌{0}%,买入{1}股", item.tactics.loss_per, item.tactics.loss_quantity);
                }
                else if (item.tactics.loss_tactics == 3)
                {
                    tempString = string.Format("跌停卖出,卖出{0}股", item.tactics.loss_quantity);
                }
                else if (item.tactics.loss_tactics == 4)
                {
                    tempString = string.Format("跌停买入,买入{0}股", item.tactics.loss_quantity);
                }
                else if (item.tactics.loss_tactics == 5)
                {
                    tempString = string.Format("转折点买入,买入{0}股", item.tactics.loss_quantity);
                }
                else if (item.tactics.loss_tactics == 6)
                {
                    tempString = string.Format("转折点卖出,卖出{0}股", item.tactics.loss_quantity);
                }
                else {
                    tempString = string.Format(" ");
                }

                Lvitem.SubItems.Add(tempString);
                Lvitem.SubItems.Add("无");
                Lvitem.Tag = item.id;       //id 标识

                listView1.Items.Add(Lvitem);

                Lvitem.UseItemStyleForSubItems = false;

                if (item.profit_loss > 0)
                {
                    Lvitem.SubItems[5].ForeColor = Color.Red;
                    Lvitem.SubItems[6].ForeColor = Color.Red;
                }else if(item.profit_loss < 0){
                    Lvitem.SubItems[5].ForeColor = Color.Green;
                    Lvitem.SubItems[6].ForeColor = Color.Green;
                }
            }

            // 持有股票汇总
            ListViewItem LvitemCount = new ListViewItem("汇总：");
            LvitemCount.BackColor = Color.Orange;

            LvitemCount.SubItems.Add(" ");
            LvitemCount.SubItems.Add(" ");
            LvitemCount.SubItems.Add(" ");
            LvitemCount.SubItems.Add("总盈亏：");
            if (lossProfit > 0) {
                LvitemCount.SubItems.Add("+" +lossProfit.ToString());
                LvitemCount.SubItems.Add("+" +lossProfitPer.ToString() + "%");
            }
            else if (lossProfit < 0)
            {
                LvitemCount.SubItems.Add("-" + lossProfit.ToString());
                LvitemCount.SubItems.Add("-" + lossProfitPer.ToString() + "%");
            }
            else {
                LvitemCount.SubItems.Add(lossProfit.ToString());
                LvitemCount.SubItems.Add(lossProfitPer.ToString() + "%");
            }

            LvitemCount.SubItems.Add(" ");
            LvitemCount.SubItems.Add(" ");
            LvitemCount.SubItems.Add("股票总值：￥" + stockTotalAssets);
            LvitemCount.SubItems.Add("持有股票数量：" + sh.HoldStockInfo.Count().ToString());
            this.CountStockAssets = stockTotalAssets;

            listView1.Items.Add(LvitemCount);

            this.listView1.Focus();
            this.listView1.Items[SelectedIndices].Selected = true;
        }

        // 持有股票的选中事件
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) 
            {
                ListViewItem vItem = listView1.SelectedItems[0];
                if (vItem.SubItems[0].Text == "汇总：")
                {
                    this.canRightClick = false;
                    return;
                }
                else {
                    this.canRightClick = true;
                }
                //获取当前选中的股票代码
                this.stock_code = vItem.SubItems[1].Text;
                //获取当前选中的股票id
                this.hold_stock_info_id = int.Parse(vItem.Tag.ToString());
                //股票可卖出状态
                if (vItem.SubItems[2].Text == "0")
                {
                    this.canSellState = false;
                }
                else {
                    this.canSellState = true;
                }
                default_query(this.stock_code, this.stock_k_url);
                this.SelectedIndices = this.listView1.SelectedIndices[0];
            }
        }

        //自选股票的选中事件
        private void listView_Optional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Optional.SelectedItems.Count > 0)
            {
                ListViewItem vItem = listView_Optional.SelectedItems[0];
                //获取当前选中的股票代码
                this.stock_code = vItem.SubItems[1].Text;

                default_query(this.stock_code, this.stock_k_url);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && this.listView1.SelectedItems.Count > 0)
            {
                this.contextMenuStrip1.Show(this, e.Location);
            }
        }

        //定时获取上证指数等信息
        private void query()
        {
            string stock_data_content;  //股票数据内容

            WebRequest req = WebRequest.Create("http://hq.sinajs.cn/list=s_sh000001");//上证指数

            WebResponse resp = req.GetResponse();

            Stream stream = resp.GetResponseStream();

            StreamReader streamReader = new StreamReader(stream, Encoding.Default);

            stock_data_content = streamReader.ReadToEnd();

            //股票数据
            string stock_data = stock_data_content.Substring(stock_data_content.IndexOf("\"") + 1, (stock_data_content.LastIndexOf("\"") - stock_data_content.IndexOf("\"") - 1));
            string[] divide = new string[] { "," };
            string[] divide_result;

            divide_result = stock_data.Split(divide, StringSplitOptions.None);

            this.lab_1.Text = divide_result[0];
            this.lab_2.Text = divide_result[1];
            this.lab_3.Text = "当前价格：" + divide_result[2];
            this.lab_4.Text = "涨跌率："+ divide_result[3] + " %";
            if (double.Parse(divide_result[3]) < 0 )
            {
                this.lab_4.ForeColor = Color.Red;
            }
            else if (double.Parse(divide_result[3]) > 0)
            {
                this.lab_4.ForeColor = Color.Chartreuse;
            }

            this.lab_5.Text = "成交量：" + divide_result[4] + "（手）";
            this.lab_6.Text = "成交额：" + divide_result[5] + "（万元）";
        }

        //查询特定的股票信息
        private void btn_query_Click(object sender, EventArgs e)
        {
            if (this.text_stockCode.Text.Trim() != "")
            {
                this.stock_code = "sh" + this.text_stockCode.Text;
                default_query(this.stock_code, this.stock_k_url);
                if (this.isReachResult == false)
                {
                    MessageBox.Show("请输入正确的A股股票代码！");

                    this.股票名字.Text = "";
                    this.今日开盘价.Text = "";
                    this.昨日收盘价.Text = "";
                    this.当前价格.Text = "";
                    this.今日最高价.Text = "";
                    this.今日最低价.Text = "";
                    this.竞买价.Text = "";
                    this.竞卖价.Text = "";
                    this.成交的股票数.Text = "";
                    this.成交金额.Text = "";
                    this.涨跌标签.Text = "涨跌:";

                    //买
                    this.buy_1.Text = "";
                    this.buy_1_price.Text = "";
                    this.buy_2.Text = "";
                    this.buy_2_price.Text = "";
                    this.buy_3.Text = "";
                    this.buy_3_price.Text = "";
                    this.buy_4.Text = "";
                    this.buy_4_price.Text = "";
                    this.buy_5.Text = "";
                    this.buy_5_price.Text = "";

                    //卖
                    this.sell_1.Text = "";
                    this.sell_1_price.Text = "";
                    this.sell_2.Text = "";
                    this.sell_2_price.Text = "";
                    this.sell_3.Text = "";
                    this.sell_3_price.Text = "";
                    this.sell_4.Text = "";
                    this.sell_4_price.Text = "";
                    this.sell_5.Text = "";
                    this.sell_5_price.Text = "";
                }
                else {
                    //暂停刷新
                    pause_Refresh();
                    this.btn_addOptional.Enabled = true;
                }
                
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
                // 开始刷新
                start_Refresh();
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
                this.text_stockCode.Focus();
                this.text_stockCode.SelectAll();
            }
        }

        private void btn_toBuy_Click(object sender, EventArgs e)
        {
              //买入窗口
             Form_toBuy form_toBuy = new Form_toBuy();
             form_toBuy.ShowDialog();
             //暂停刷新
             pause_Refresh();

             if (form_toBuy.DialogResult == DialogResult.OK)
             {
                 start_Refresh();
                 LoadData();//重新加载数据
                 //index_Timer_Tick(sender, e);
             }
        }

        private void btn_toBuy_Click_code(object sender, EventArgs e)
        {
            if (this.canRightClick == false)
            {
                MessageBox.Show("不可操作！");
                return;
            }
            //买入窗口
            string code = this.stock_code.Replace("sh", "");
            Form_toBuy form_toBuy = new Form_toBuy(code);
            form_toBuy.ShowDialog();
            //暂停刷新
            pause_Refresh();

            if (form_toBuy.DialogResult == DialogResult.OK)
            {
                start_Refresh();
                LoadData();//重新加载数据
                //index_Timer_Tick(sender, e);
            }
        }

        //卖出股票
        private void btn_toSell_Click_code(object sender, EventArgs e)
        {
            if (canSellState == false)
            {
                MessageBox.Show("当前股票可卖股数为0，不可卖出!");
                return;
            }
            if (this.canRightClick == false)
            {
                MessageBox.Show("不可操作！");
                return;
            }
            //卖出窗口
            string code = this.stock_code.Replace("sh", "");
            Form_toSell form_toSell = new Form_toSell(code);
            form_toSell.ShowDialog();
            //暂停刷新
            pause_Refresh();

            if (form_toSell.DialogResult == DialogResult.OK)
            {
                start_Refresh();
                LoadData();//重新加载数据
                //index_Timer_Tick(sender, e);
            }
        }

        //指定策略
        private void btn_make_plan_Click(object sender, EventArgs e)
        {
            if (this.canRightClick == false)
            {
                MessageBox.Show("不可操作！");
                return;
            }
            //窗口
            Form_ProfitAndLoss form_ProfitAndLoss = new Form_ProfitAndLoss(hold_stock_info_id);
            form_ProfitAndLoss.ShowDialog();

            //暂停刷新
            pause_Refresh();

            if (form_ProfitAndLoss.DialogResult == DialogResult.OK)
            {
                start_Refresh();
                LoadData();//重新加载数据
            }
        }

        //开始刷新
        private void start_Refresh()
        {
            this.index_Timer.Enabled = true;
            this.timer1.Enabled = true;
            this.btn_Refresh.Text = "刷新中";
        }
        //暂停刷新
        private void pause_Refresh()
        {
            this.index_Timer.Enabled = false;
            this.timer1.Enabled = false;
            this.btn_Refresh.Text = "暂停中";
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            // 开始刷新
            start_Refresh();

            query();
            default_query(stock_code, stock_k_url);

            this.listView1.Items[SelectedIndices].Selected = true;
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();//重新加载数据
        }

        private void btn_addOptional_Click(object sender, EventArgs e)
        {
            this.stock_code = "sh" + this.text_stockCode.Text;

            //是否是持有的股票代码
            if (Utility.user.HoldStockInfo != null)
            {
                var datalist = Utility.user.HoldStockInfo.Where(hsi => hsi.stock_code.Equals(stock_code)).ToList();
                if (datalist.Count == 0)
                {
                    //是否是已经加入到自选股中的股票
                    if (holdStockInfoService.IsHaveOptional(stock_id, this.stock_code)) {
                        MessageBox.Show("已加入自选股中");
                        start_Refresh();
                        return;
                    }
                    //未持有，加入到数据库中  type = 2
                    this.ReachInfo.type = 2;
                    this.ReachInfo.stock_code = this.stock_code;
                    this.ReachInfo.stock_holder_id = stock_id;
                    holdStockInfoService.AddHoldStockInfo(this.ReachInfo);
                    DataBinding_Optional();//刷新界面
                }
                else {
                    //如果是持有的股票，则不做处理
                    MessageBox.Show("已持有该股票!");
                    start_Refresh();
                    return;
                }
            }
        }

        // 跳转出自选股界面
        private void tabControl_top_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_top.SelectedTab.Name == "tabPage_optional")
            {
                tabControl_bottom.SelectedTab = this.tabPage_advise;
                //请求远程的优选股数据
                //todo
            }
        }

        //跳转出优选股界面
        private void tabControl_bottom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_bottom.SelectedTab.Name == "tabPage_advise")
            {
                tabControl_top.SelectedTab = this.tabPage_optional;
                //请求远程的优选股数据
                //todo
            }
        }

        


        





    }
}
