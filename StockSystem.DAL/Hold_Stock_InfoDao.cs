﻿using System;
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


    }
}
