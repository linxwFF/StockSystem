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
    public class DealDao
    {
        //根据用户ID查询所有的交易记录
        public List<Deal> GetAllDealById(int holdStockId)
        {
            string sql = "select * from t_deal  where hold_stock_id = @id;";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@id", holdStockId));

            DataTable dt = DBHelperSQL.Ins.ExcuteDataTable(sql, Paramter.ToArray());
            if (dt.Rows.Count > 0)
            {
                List<Deal> list = (List<Deal>)DataConvert<Deal>.ToList(dt);
                return list;
            }
            else
            {
                return null;
            }
        }
       
    }
}
