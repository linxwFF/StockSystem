using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockSystem.ORM;

namespace StockSystem.Model
{
    [Serializable]
    public class Tactics : DataEntityBase
    {
        [DataField("id")]
        public int id { get; set; }
        [DataField("hold_stock_info_id")]
        public int hold_stock_info_id { get; set; }

        [DataField("loss_per")]
        public double loss_per { get; set; }
        [DataField("loss_quantity")]
        public int loss_quantity { get; set; }
        [DataField("loss_tactics")]
        public int loss_tactics { get; set; }
        // 0. 不设置
        // 1. 下跌买入
        // 2. 下跌卖出

        [DataField("profit_per")]
        public double profit_per { get; set; }
        [DataField("profit_quantity")]
        public int profit_quantity { get; set; }
        [DataField("profit_tactics")]
        public int profit_tactics { get; set; }
        // 0. 不设置
        // 1. 上涨买入
        // 2. 上涨卖出
    }
}
