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
    public class CommissionDao
    {
        //插入委托记录 持有的
        public void AddCommissionHave(Commission model)
        {
            string sql = "insert into t_commission ("
            + "hold_stock_info_id, commission_price, direction,time,commission_amount,state,remain,stockholder_id) "
            + "values( @hold_stock_info_id, @commission_price, @direction, now(), @commission_amount, @state, @remain, @stockholder_id) ";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@hold_stock_info_id", model.hold_stock_info.id));
            Paramter.Add(new MySqlParameter("@commission_price", model.commission_price));
            Paramter.Add(new MySqlParameter("@direction", model.direction));
            Paramter.Add(new MySqlParameter("@commission_amount", model.commission_amount));
            Paramter.Add(new MySqlParameter("@state", model.state));
            Paramter.Add(new MySqlParameter("@remain", model.remain));
            Paramter.Add(new MySqlParameter("@stockholder_id", model.stockholder_id));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }

        //根据用户ID查询所有的委托记录
        public List<Commission> GetAllCommissionById(int id)
        {
            string sql = "select * from t_commission as c right join t_hold_stock_info as h on c.hold_stock_info_id = h.id where c.stockholder_id = @id order by c.time";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@id", id));

            DataTable dt = DBHelperSQL.Ins.ExcuteDataTable(sql, Paramter.ToArray());
            if (dt.Rows.Count > 0)
            {
                List<Commission> list = (List<Commission>)DataConvert<Commission>.ToList(dt);
                //股票信息
                for (int i = 0; i < list.Count; i++)
                {
                    Hold_Stock_Info holdStockInfo = new Hold_Stock_Info();
                    if (dt.Rows[i][11] != DBNull.Value)
                    {
                        holdStockInfo.stock_name = dt.Rows[i][11].ToString();
                    }
                    if (dt.Rows[i][12] != DBNull.Value)
                    {
                        holdStockInfo.stock_code = dt.Rows[i][12].ToString();
                    }
                    if (dt.Rows[i][13] != DBNull.Value)
                    {
                        holdStockInfo.amount_useable = int.Parse(dt.Rows[i][13].ToString());
                    }
                    if (dt.Rows[i][14] != DBNull.Value)
                    {
                        holdStockInfo.hold_quantity = int.Parse(dt.Rows[i][14].ToString());
                    }
                    if (dt.Rows[i][15] != DBNull.Value)
                    {
                        holdStockInfo.market_price = double.Parse(dt.Rows[i][15].ToString());
                    }
                    if (dt.Rows[i][16] != DBNull.Value)
                    {
                        holdStockInfo.profit_loss = double.Parse(dt.Rows[i][16].ToString());
                    }
                    if (dt.Rows[i][17] != DBNull.Value)
                    {
                        holdStockInfo.profit_loss_per = double.Parse(dt.Rows[i][17].ToString());
                    }
                    if (dt.Rows[i][18] != DBNull.Value)
                    {
                        holdStockInfo.current_price = double.Parse(dt.Rows[i][18].ToString());
                    }
                    if (dt.Rows[i][19] != DBNull.Value)
                    {
                        holdStockInfo.cost_price = double.Parse(dt.Rows[i][19].ToString());
                    }
                    list[i].hold_stock_info = holdStockInfo;
                }
                return list;
            }
            else
            {
                return null;
            }
        }

        //根据用户ID查询所有的委托记录
        public List<Commission> GetAllCommissionByIdDeal(int id)
        {
            string sql = "select * from t_commission as c right join t_hold_stock_info as h on c.hold_stock_info_id = h.id where c.stockholder_id = @id and state =3 order by c.time";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@id", id));

            DataTable dt = DBHelperSQL.Ins.ExcuteDataTable(sql, Paramter.ToArray());
            if (dt.Rows.Count > 0)
            {
                List<Commission> list = (List<Commission>)DataConvert<Commission>.ToList(dt);
                //股票信息
                for (int i = 0; i < list.Count; i++)
                {
                    Hold_Stock_Info holdStockInfo = new Hold_Stock_Info();
                    if (dt.Rows[i][11] != DBNull.Value)
                    {
                        holdStockInfo.stock_name = dt.Rows[i][11].ToString();
                    }
                    if (dt.Rows[i][12] != DBNull.Value)
                    {
                        holdStockInfo.stock_code = dt.Rows[i][12].ToString();
                    }
                    if (dt.Rows[i][13] != DBNull.Value)
                    {
                        holdStockInfo.amount_useable = int.Parse(dt.Rows[i][13].ToString());
                    }
                    if (dt.Rows[i][14] != DBNull.Value)
                    {
                        holdStockInfo.hold_quantity = int.Parse(dt.Rows[i][14].ToString());
                    }
                    if (dt.Rows[i][15] != DBNull.Value)
                    {
                        holdStockInfo.market_price = double.Parse(dt.Rows[i][15].ToString());
                    }
                    if (dt.Rows[i][16] != DBNull.Value)
                    {
                        holdStockInfo.profit_loss = double.Parse(dt.Rows[i][16].ToString());
                    }
                    if (dt.Rows[i][17] != DBNull.Value)
                    {
                        holdStockInfo.profit_loss_per = double.Parse(dt.Rows[i][17].ToString());
                    }
                    if (dt.Rows[i][18] != DBNull.Value)
                    {
                        holdStockInfo.current_price = double.Parse(dt.Rows[i][18].ToString());
                    }
                    if (dt.Rows[i][19] != DBNull.Value)
                    {
                        holdStockInfo.cost_price = double.Parse(dt.Rows[i][19].ToString());
                    }
                    list[i].hold_stock_info = holdStockInfo;
                }
                return list;
            }
            else
            {
                return null;
            }
        }

        //根据hold_stock_info_id 和 stockholder_id 查询
        public List<Commission> getCommissionByholdStockInfoID(int hold_stock_info_id, int stockholder_id)
        {
            string sql = "select * from t_commission where hold_stock_info_id = @hold_stock_info_id and stockholder_id = @stockholder_id";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@hold_stock_info_id", hold_stock_info_id));
            Paramter.Add(new MySqlParameter("@stockholder_id", stockholder_id));

            DataTable dt = DBHelperSQL.Ins.ExcuteDataTable(sql, Paramter.ToArray());
            if (dt.Rows.Count > 0)
            {
                List<Commission> list = (List<Commission>)DataConvert<Commission>.ToList(dt);
                return list;
            }
            else
            {
                return null;
            }
        }

        public void UpdateState(int id, int state)
        {
            string sql = "update t_commission set "
                + "state = @state "
                + "where id = @id";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@id", id));
            Paramter.Add(new MySqlParameter("@state", state));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }
    }
    
}
