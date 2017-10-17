using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockSystem.ORM;

//股东信息实体类
namespace StockSystem.Model
{
    [Serializable]
    public class Stock_Holder : DataEntityBase
    {
        [DataField("id")]
        public int id { get; set; }
        [DataField("bankroll_id")]
        public int bankroll_id { get;set; }
        [DataField("name")]
        public string name { get;set; }
        [DataField("personalID")]
        public string personalID { get; set; }
        [DataField("phone")]
        public string phone{ get; set; }
        [DataField("username")]
        public string username { get; set; }
        [DataField("password")]
        public string password { get; set; }

        //账户信息
        public Personal_Stock_Account account { get; set; }

        //持仓信息
        public List<Hold_Stock_Info> HoldStockInfo { get; set; }
    }
}
