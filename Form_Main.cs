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

namespace StockSystem
{
    public partial class Form_Main : Form
    {
        // 布尔标志，用来确定输入的是否是字符.
        private bool nonNumberEntered = false;

        // 当前股票代码信息
        private string stock_code;
        // K线
        private string stock_k_url;

        //当前帐号ID
        private int stock_id;

        private Stock_HolderService stock_HolderService = new Stock_HolderService();

        public Form_Main()
        {
            InitializeComponent();
            stock_code = "sh601006";
            stock_k_url = "http://image2.sinajs.cn/newchart/min/n/";
            stock_id = 1;
            // 定时间隔
            this.index_Timer.Interval = 10000;
            //定时器
            this.index_Timer.Enabled = true;
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
        private void showData(string stock_data_content, string stock_k_model) 
        {
             //股票数据
            string stock_data = stock_data_content.Substring(stock_data_content.IndexOf("\"") +  1, (stock_data_content.LastIndexOf("\"") - stock_data_content.IndexOf("\"") - 1));
            string[] divide = new string[] { "," };
            string[] divide_result;

            divide_result = stock_data.Split(divide, StringSplitOptions.None);

            // K线图
            this.pictureBox1.ImageLocation = stock_k_model + stock_code + ".gif";

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
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            default_query(this.stock_code,this.stock_k_url);
        }

        //定时器10S一次
        private void index_Timer_Tick(object sender, EventArgs e)
        {
            //更新数据库的股东持仓信息
            stock_HolderService.updateStockHolderInfo(stock_id);
            DataBinding_Stock_Holder();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.stock_k_url = "http://image2.sinajs.cn/newchart/min/n/";
            default_query(stock_code, this.stock_k_url);
        }

        private void btn_daily_Click(object sender, EventArgs e)
        {
            this.stock_k_url = "http://image.sinajs.cn/newchart/daily/n/";
            default_query(stock_code, this.stock_k_url);
        }

        private void btn_weekly_Click(object sender, EventArgs e)
        {
            this.stock_k_url = "http://image.sinajs.cn/newchart/weekly/n/";
            default_query(stock_code, this.stock_k_url);
        }

        private void btn_monthly_Click(object sender, EventArgs e)
        {
            this.stock_k_url = "http://image.sinajs.cn/newchart/monthly/n/";
            default_query(stock_code, this.stock_k_url);
        }


        //窗体加载事件
        private void Form_Main_Load(object sender, EventArgs e)
        {
            DataBinding_Stock_Holder();
        }

        //ListView 窗口数据绑定
        private void DataBinding_Stock_Holder()
        {
            Stock_Holder sh = stock_HolderService.getStockHolder(stock_id);

            listView1.Items.Clear();
            
            foreach(Hold_Stock_Info item in sh.HoldStockInfo)
            {
                ListViewItem Lvitem = new ListViewItem(item.stock_name);
                Lvitem.SubItems.Add(item.stock_code);
                Lvitem.SubItems.Add(item.amount_useable.ToString());
                Lvitem.SubItems.Add(item.hold_quantity.ToString());
                Lvitem.SubItems.Add(item.market_price.ToString());
                Lvitem.SubItems.Add(item.market_price.ToString());
                Lvitem.SubItems.Add(item.profit_loss.ToString());
                Lvitem.SubItems.Add(item.profit_loss_per.ToString());
                Lvitem.SubItems.Add(item.current_price.ToString());
                Lvitem.SubItems.Add(item.cost_price.ToString());

                listView1.Items.Add(Lvitem);
            }
        }
    }
}
