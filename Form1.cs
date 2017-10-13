using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

using StockSystem.BLL;
using StockSystem.Model;

namespace StockSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.Class1 test = new BLL.Class1();
            DataTable dt = test.queryStockHolder();
            Stock_Holder sh = new Stock_Holder();
            sh = test.getStockHoderByID(2);

            Console.Write(sh.name);
        }
    }
}
