using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockSystem.Model;
using System.Data;
using MySql.Data.MySqlClient;
using StockSystem.ORM;

namespace StockSystem.DAL
{
    public class Personal_Stock_AccountDao
    {
        //更新用户的账户的股票总值
        public void updateTotalStock(double totalStock,int id)
        {
            string sql = "update t_personal_stock_account set total_stock = @totalStock where id = @id;";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@totalStock", totalStock));
            Paramter.Add(new MySqlParameter("@id", id));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }

        //买入时， - 可用余额
        public void updateUserableBuy(double bankroll,int id)
        {
            string sql = "update t_personal_stock_account set bankroll = bankroll - @bankroll where id = @id";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@bankroll", bankroll));
            Paramter.Add(new MySqlParameter("@id", id));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }

        //卖出时， + 可用余额
        public void updateUserableSell(double bankroll, int id)
        {
            string sql = "update t_personal_stock_account set bankroll_useable = bankroll_useable + @bankroll where id = @id";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@bankroll", bankroll));
            Paramter.Add(new MySqlParameter("@id", id));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }

        //根据ID获取帐号信息
        public Personal_Stock_Account GetByID(int id)
        {
            string sql = "select * from t_personal_stock_account where id = @id";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@id", id));

            DataTable dt = DBHelperSQL.Ins.ExcuteDataTable(sql, Paramter.ToArray());
            if (dt.Rows.Count > 0)
            {
                var list = DataConvert<Personal_Stock_Account>.ToList(dt);
                return list[0];
            }
            else
            {
                return null;
            }
        }

        //更新帐号总资产
        public void UpdateTotal(double total, int id)
        {
            string sql = "update t_personal_stock_account set "
                + " total = @total "
                + " where id = @id ";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@total", total));
            Paramter.Add(new MySqlParameter("@id", id));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }
    }
}
