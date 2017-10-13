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
        public int stock_code { get; set; }
        [DataField("amount_useable")]
        public double amount_useable{get; set;}
        [DataField("cost_price")]
        public double cost_price { get; set; }
        [DataField("commission_id")]
        public int commission_id { get; set; }
    }
}
