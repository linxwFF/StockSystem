using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockSystem
{
    public partial class Form_ProfitAndLoss : Form
    {
        public Form_ProfitAndLoss()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            string radio = string.Empty;
            switch (((RadioButton)sender).Text.ToString())
            {
                case "下跌减仓":
                    radio = "下跌减仓";
                    break;
                case "下跌加仓":
                    radio = "下跌加仓";
                    break;
                default:
                    break;
            }
            MessageBox.Show(radio);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            string radio = string.Empty;
            switch (((RadioButton)sender).Text.ToString())
            {
                case "盈利减仓":
                    radio = "盈利减仓";
                    break;
                case "盈利加仓":
                    radio = "盈利加仓";
                    break;
                default:
                    break;
            }
            MessageBox.Show(radio);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("提交");
        }


    }
}
