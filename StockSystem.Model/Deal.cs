using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockSystem.ORM;

namespace StockSystem.Model
{
    [Serializable]
    public class Deal : DataEntityBase
    {
        [DataField("id")]
        public int id { get; set; }
        [DataField("stock_code")]
        public string stock_code { get; set; }
        [DataField("deal_price")]
        public double deal_price { get; set; }

        // 1. 买入 2. 卖出
        [DataField("direction")]
        public int direction { get; set; }
        [DataField("dealed_amount")]
        public int dealed_amount { get; set; }
        [DataField("dealed_value")]
        public double dealed_value { get; set; }
        [DataField("buy_commission")]
        public int buy_commission { get; set; }
        [DataField("sell_commission")]
        public int sell_commission { get; set; }

        [DataField("time")]
        public DateTime time { get; set; }
    }
}
