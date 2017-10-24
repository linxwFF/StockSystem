using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockSystem.ORM;
using StockSystem.Model;

namespace StockSystem.Model
{
    [Serializable]
    public class Commission : DataEntityBase
    {
        [DataField("id")]
        public int id { get; set; }
        [DataField("commission_price")]
        public double commission_price { get; set; }
        [DataField("direction")]
        public int direction { get; set; }
        [DataField("time")]
        public DateTime time { get; set; }
        [DataField("commission_amount")]
        public int commission_amount { get; set; }
        [DataField("state")]
        public int state { get; set; }
        [DataField("remain")]
        public int remain { get; set; }

        [DataField("hold_stock_info")]
        public Hold_Stock_Info hold_stock_info { get; set; }

        [DataField("stockholder_id")]
        public int stockholder_id { get; set; }
    }
}
