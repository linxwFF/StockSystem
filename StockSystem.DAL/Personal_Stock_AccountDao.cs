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
    }
}
