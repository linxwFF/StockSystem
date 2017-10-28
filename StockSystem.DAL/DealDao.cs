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

        //添加交易记录
        public void AddDeal(Deal model)
        {
            string sql = "insert into t_deal ("
            + "hold_stock_id, stock_code, deal_price,direction,dealed_amount,dealed_value,buy_commission,sell_commission,time ) "
            + "values( @hold_stock_id, @stock_code, @deal_price, @direction, @dealed_amount, @dealed_value, @buy_commission, @sell_commission, now()) ";

            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("@hold_stock_id", model.hold_stock_id));
            Paramter.Add(new MySqlParameter("@stock_code", model.stock_code));
            Paramter.Add(new MySqlParameter("@deal_price", model.deal_price));
            Paramter.Add(new MySqlParameter("@direction", model.direction));
            Paramter.Add(new MySqlParameter("@dealed_amount", model.dealed_amount));
            Paramter.Add(new MySqlParameter("@dealed_value", model.dealed_value));
            Paramter.Add(new MySqlParameter("@buy_commission", model.buy_commission));
            Paramter.Add(new MySqlParameter("@sell_commission", model.sell_commission));

            DBHelperSQL.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }
       
    }
}
