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
    public class Hold_Stock_InfoDao
    {
        //添加持有股票信息
        public int AddHoldStockInfo(Hold_Stock_Info model) 
        {
            string sql = "insert into t_hold_stock_info ("
            + "stock_holder_id, stock_name, stock_code,amount_useable,hold_quantity,cost_price,market_price,profit_loss,profit_loss_per,current_price,type) "
            + "values( @stock_holder_id, @stock_name, @stock_code, @amount_useable, @hold_quantity, @cost_price,@market_price,@profit_loss,@profit_loss_per,@current_price,@type) ";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@stock_holder_id", model.stock_holder_id));
            Paramter.Add(new MySqlParameter("@stock_name", model.stock_name));
            Paramter.Add(new MySqlParameter("@stock_code", model.stock_code));
            Paramter.Add(new MySqlParameter("@amount_useable", "0"));
            Paramter.Add(new MySqlParameter("@hold_quantity", model.hold_quantity));
            Paramter.Add(new MySqlParameter("@cost_price", model.cost_price));

            Paramter.Add(new MySqlParameter("@market_price", "0"));
            Paramter.Add(new MySqlParameter("@profit_loss", "0"));
            Paramter.Add(new MySqlParameter("@profit_loss_per", "0"));
            Paramter.Add(new MySqlParameter("@current_price", "0"));
            // 1. 买入 2. 卖出
            Paramter.Add(new MySqlParameter("@type", model.type));

            return (int)DBHelperSQL.Ins.ExecuteLastId(sql, Paramter.ToArray());
        }

        // 根据用户ID,查询所有自选股信息
        public List<Hold_Stock_Info> GetAllOptionalStock(int id)
        {
            string sql = "select * from t_hold_stock_info where stock_holder_id = @id and type = 2";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@id", id));

            DataTable dt = DBHelperSQL.Ins.ExcuteDataTable(sql, Paramter.ToArray());
            if (dt.Rows.Count > 0)
            {
                List<Hold_Stock_Info> list = (List<Hold_Stock_Info>)DataConvert<Hold_Stock_Info>.ToList(dt);
                return list;
            }
            else
            {
                return null;
            }
        }

        //修改股东持有股票的可使用股票数量  卖出
        public void UpdateAmountUseable(int quantity, string stock_code, int stock_holder_id)
        {
            string sql = "update t_hold_stock_info set amount_useable = @quantity where stock_holder_id = @stock_holder_id and stock_code = @stock_code";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@quantity", quantity));
            Paramter.Add(new MySqlParameter("@stock_holder_id", stock_holder_id));
            Paramter.Add(new MySqlParameter("@stock_code", stock_code));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }

        //修改股东持有股票的可使用股票数量  买入
        public void UpdateAmountUseableBuy(int quantity, double price, string stock_code, int stock_holder_id)
        {
            string sql = "update t_hold_stock_info set "
                + "hold_quantity = hold_quantity +@hold_quantity ,"
                + "cost_price = cost_price +@quantity*@price "
                + "where stock_holder_id = @stock_holder_id and stock_code = @stock_code";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@quantity", quantity));
            Paramter.Add(new MySqlParameter("@hold_quantity", quantity));
            Paramter.Add(new MySqlParameter("@stock_holder_id", stock_holder_id));
            Paramter.Add(new MySqlParameter("@stock_code", stock_code));
            Paramter.Add(new MySqlParameter("@price", price));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }

        //买入委托成功   +可用股票数量
        public void BuyCommissionAmount(int quantity, string stock_code, int stock_holder_id)
        {
            string sql = "update t_hold_stock_info set amount_useable = amount_useable + @quantity where stock_holder_id = @stock_holder_id and stock_code = @stock_code";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@quantity", quantity));
            Paramter.Add(new MySqlParameter("@stock_holder_id", stock_holder_id));
            Paramter.Add(new MySqlParameter("@stock_code", stock_code));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }

        //卖出委托成功  -持有股票数量
        public void SellCommissionHold(int quantity, string stock_code, int stock_holder_id)
        {
            string sql = "update t_hold_stock_info set hold_quantity = hold_quantity - @quantity where stock_holder_id = @stock_holder_id and stock_code = @stock_code";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@quantity", quantity));
            Paramter.Add(new MySqlParameter("@stock_holder_id", stock_holder_id));
            Paramter.Add(new MySqlParameter("@stock_code", stock_code));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }


    }
}
