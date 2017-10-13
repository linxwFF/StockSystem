using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockSystem.ORM;

//股东账户表
namespace StockSystem.Model
{
    [Serializable]
    public class Personal_Stock_Account
    {
        [DataField("id")]
        public int id { get; set; }
        [DataField("bankroll")]
        public double bankroll { get; set; }
        [DataField("bankroll_useable")]
        public double bankroll_useable { get; set; }
        [DataField("bankroll_freezed")]
        public double bankroll_freezed { get; set; }
        [DataField("bankroll_in_cash")]
        public double bankroll_in_cash { get; set; }
        [DataField("total")]
        public double total { get; set; }
        [DataField("total_stock")]
        public double total_stock { get; set; }
    }
}
