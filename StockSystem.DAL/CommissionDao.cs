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
        //插入委托记录
        public void AddCommission(Commission model)
        {
            string sql = "insert into t_commission ("
            + "hold_stock_info_id, commission_price, direction,time,commission_amount,state,remain) "
            + "values( @hold_stock_info_id, @commission_price, @direction, now(), @commission_amount, @state, @remain ) ";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@hold_stock_info_id", model.hold_stock_info.id));
            Paramter.Add(new MySqlParameter("@commission_price", model.commission_price));
            Paramter.Add(new MySqlParameter("@direction", model.direction));
            Paramter.Add(new MySqlParameter("@commission_amount", model.commission_amount));
            Paramter.Add(new MySqlParameter("@state", model.state));
            Paramter.Add(new MySqlParameter("@remain", model.remain));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }

        //修改股东持有股票的可使用股票数量
        public void UpdateAmountUseable(int quantity, string stock_code, int stock_holder_id)
        {
            string sql = "update t_hold_stock_info set amount_useable = @quantity where stock_holder_id = @stock_holder_id and stock_code = @stock_code";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@quantity", quantity));
            Paramter.Add(new MySqlParameter("@stock_holder_id", stock_holder_id));
            Paramter.Add(new MySqlParameter("@stock_code", stock_code));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }
    }
    
}
