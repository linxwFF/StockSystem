using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockSystem.Model;
using MySql.Data.MySqlClient;
using StockSystem.ORM;
using System.Data;

namespace StockSystem.DAL
{
    public class TacticsDao
    {
        //根据ID查询
        public Tactics getTacticsById(int hold_stock_info_id)
        {
            string sql = "select * from t_tactics where  hold_stock_info_id = @hold_stock_info_id limit 1;";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@hold_stock_info_id", hold_stock_info_id));

            DataTable dt = DBHelperSQL.Ins.ExcuteDataTable(sql, Paramter.ToArray());
            if (dt.Rows.Count > 0)
            {
                var list = DataConvert<Tactics>.ToList(dt);
                return list[0];
            }
            else
            {
                return null;
            }
        }
    }
    
}
