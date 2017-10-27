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

        //添加数据库的规则
        public void AddTactics(Tactics model)
        {
            string sql = "INSERT INTO t_tactics (hold_stock_info_id, loss_per, loss_quantity, loss_tactics, profit_per, profit_quantity, profit_tactics) "
                + " VALUES (@hold_stock_info_id, @loss_per, @loss_quantity, @loss_tactics,@profit_per, @profit_quantity, @profit_tactics) ";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@loss_per", model.loss_per));
            Paramter.Add(new MySqlParameter("@loss_quantity", model.loss_quantity));
            Paramter.Add(new MySqlParameter("@loss_tactics", model.loss_tactics));
            Paramter.Add(new MySqlParameter("@profit_per", model.profit_per));
            Paramter.Add(new MySqlParameter("@profit_quantity", model.profit_quantity));
            Paramter.Add(new MySqlParameter("@profit_tactics", model.profit_tactics));
            Paramter.Add(new MySqlParameter("@hold_stock_info_id", model.hold_stock_info_id));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }

        //更新数据库信息
        public void UpdateTactics(Tactics model)
        {
            string sql = "update t_tactics set "
            + "loss_per = @loss_per, loss_quantity = @loss_quantity, loss_tactics = @loss_tactics ,"
            + "profit_per = @profit_per, profit_quantity = @profit_quantity, profit_tactics = @profit_tactics where hold_stock_info_id = @hold_stock_info_id";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@loss_per", model.loss_per));
            Paramter.Add(new MySqlParameter("@loss_quantity", model.loss_quantity));
            Paramter.Add(new MySqlParameter("@loss_tactics", model.loss_tactics));
            Paramter.Add(new MySqlParameter("@profit_per", model.profit_per));
            Paramter.Add(new MySqlParameter("@profit_quantity", model.profit_quantity));
            Paramter.Add(new MySqlParameter("@profit_tactics", model.profit_tactics));
            Paramter.Add(new MySqlParameter("@hold_stock_info_id", model.hold_stock_info_id));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }
    }
    
}
