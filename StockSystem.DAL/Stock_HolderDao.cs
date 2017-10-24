using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockSystem.Model;
using System.Data;
using MySql.Data.MySqlClient;
using StockSystem.ORM;

//股东信息数据持久层
namespace StockSystem.DAL
{
    public class Stock_HolderDao
    {
        private CommissionDao commissiondao = new CommissionDao();

        //获取股东列表
        public DataTable queryStockHolder()
        {
            string sql = @"select * from t_stock_holder";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();

            DataTable data = DBHelperSQL.Ins.ExcuteDataTable(sql, Paramter.ToArray());

            return data;
        }

        //根据ID获取一个股东信息
        public Stock_Holder getStockHoderByID(int id)
        {
            string sql = "select * from t_stock_holder where id = @id";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@id", id));

            DataTable dt = DBHelperSQL.Ins.ExcuteDataTable(sql, Paramter.ToArray());
            if (dt.Rows.Count > 0)
            {
                var list = DataConvert<Stock_Holder>.ToList(dt);
                //股东账户
                list[0].account = getAccountById(list[0].bankroll_id);
                //股东股票持仓信息
                list[0].HoldStockInfo = getHoldStockInfoById(list[0].id);
                return list[0];
            }
            else
            {
                return null;
            }
        }

        //根据ID查询出股东账户信息
        public Personal_Stock_Account getAccountById(int id)
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

        //通过id获取股东所有的股票持仓记录
        public List<Hold_Stock_Info> getHoldStockInfoById(int id)
        {
            string sql = "select * from t_hold_stock_info as h left join t_tactics as t on h.id = t.hold_stock_info_id where h.stock_holder_id = @id;";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@id", id));

            DataTable dt = DBHelperSQL.Ins.ExcuteDataTable(sql, Paramter.ToArray());
            if (dt.Rows.Count > 0)
            {
                List<Hold_Stock_Info> list = (List<Hold_Stock_Info>)DataConvert<Hold_Stock_Info>.ToList(dt);
                //查询出股票策略
                for (int i = 0; i < list.Count; i++)
                {
                    Tactics tactics = new Tactics();
                    if (dt.Rows[i][14] != DBNull.Value)
                    {
                        tactics.loss_per = Convert.ToDouble(dt.Rows[i][14]);
                    }
                    if (dt.Rows[i][15] != DBNull.Value)
                    {
                        tactics.loss_quantity = int.Parse(dt.Rows[i][15].ToString());
                    }
                    if (dt.Rows[i][16] != DBNull.Value)
                    {
                        tactics.loss_tactics = int.Parse(dt.Rows[i][16].ToString());
                    }
                    if (dt.Rows[i][17] != DBNull.Value)
                    {
                        tactics.profit_per = double.Parse(dt.Rows[i][17].ToString());
                    }
                    if (dt.Rows[i][18] != DBNull.Value)
                    {
                        tactics.profit_quantity = int.Parse(dt.Rows[i][18].ToString());
                    }
                    if (dt.Rows[i][19] != DBNull.Value)
                    {
                        tactics.profit_tactics = int.Parse(dt.Rows[i][19].ToString());
                    }
                        list[i].tactics = tactics;
                }
                //查询出股票的委托记录
                //TODO
                
                return list;
            }
            else
            {
                return null;
            }
        }
        //通过id获取股东持有的一支股票的信息
        public Hold_Stock_Info getOneStockInfo(int id)
        {
            string sql = "select * from t_hold_stock_info where id = @id";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@id", id));

            DataTable dt = DBHelperSQL.Ins.ExcuteDataTable(sql, Paramter.ToArray());
            if (dt.Rows.Count > 0)
            {
                var list = DataConvert<Hold_Stock_Info>.ToList(dt);
                return list[0];
            }
            else
            {
                return null;
            }
        }

        //通过id获取股东所有的股票持仓记录的股票代码 <id,股票代码>
        public Dictionary<String, String> getStockInfo(int id)
        {
            string sql = "select id,stock_code from t_hold_stock_info where stock_holder_id = @id";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@id", id));

            DataTable dt = DBHelperSQL.Ins.ExcuteDataTable(sql, Paramter.ToArray());
            Dictionary<String, String> map = new Dictionary<String, String>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows) {
                    map.Add(dr["id"].ToString() , dr["stock_code"].ToString());
                }
                return map;
            }
            else
            {
                return null;
            }
        }

        //更新数据
        public void updateStockInfo(Hold_Stock_Info model)
        {
            string sql = "update t_hold_stock_info set "
            + "market_price = @market_price, profit_loss = @profit_loss, profit_loss_per = @profit_loss_per ,"
            + "current_price = @current_price, stock_name = @stock_name where id = @id";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@market_price", model.market_price));
            Paramter.Add(new MySqlParameter("@profit_loss", model.profit_loss));
            Paramter.Add(new MySqlParameter("@profit_loss_per", model.profit_loss_per));
            Paramter.Add(new MySqlParameter("@current_price", model.current_price));
            Paramter.Add(new MySqlParameter("@id", model.id));
            Paramter.Add(new MySqlParameter("@stock_name", model.stock_name));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }

        //验证用户密码
        public Stock_Holder verifyPassword(string username, string password)
        {
            string sql = "select * from t_stock_holder where username = @username and password = @password limit 1";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@username", username));
            Paramter.Add(new MySqlParameter("@password", password));

            DataTable dt = DBHelperSQL.Ins.ExcuteDataTable(sql, Paramter.ToArray());

            if (dt.Rows.Count > 0) {
                var list = DataConvert<Stock_Holder>.ToList(dt);
                //根据ID获取所有的用户信息
                //TODO
                Stock_Holder result = getStockHoderByID(list[0].id);
                return result;
            }else {
                return null;
            }
        }
    }
}
