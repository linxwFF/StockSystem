using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockSystem.ORM;

//股东持股实体类
namespace StockSystem.Model
{
    [Serializable]
    public class Hold_Stock_Info : DataEntityBase
    {
        [DataField("id")]
        public int id { get; set; }
        [DataField("stock_holder_id")]
        public int stock_holder_id { get; set; }
        [DataField("stock_code")]
        public string stock_code { get; set; }
        [DataField("amount_useable")]
        public int amount_useable{get; set;}
        [DataField("cost_price")]
        public double cost_price { get; set; }
        [DataField("hold_quantity")]
        public int hold_quantity { get; set; }
        [DataField("market_price")]
        public double market_price { get; set; }
        [DataField("profit_loss")]
        public double profit_loss { get; set; }
        [DataField("profit_loss_per")]
        public double profit_loss_per { get; set; }
        [DataField("current_price")]
        public double current_price { get; set; }
        [DataField("stock_name")]
        public string stock_name { get; set; }

        [DataField("type")]
        public int type { get; set; }

        // 持有股票指定的策略
        [DataField("tactics")]
        public Tactics tactics { get; set; }

        //委托记录
        [DataField("commission_list")]
        public List<Commission> commission_list { get; set; }
    }
}
