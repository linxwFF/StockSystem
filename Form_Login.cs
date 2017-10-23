using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StockSystem.BLL;

namespace StockSystem
{
    public partial class Form_Login : Form
    {
        private Stock_HolderService stock_holderService = new Stock_HolderService();
        private string username;
        private string password;

        public Form_Login()
        {
            InitializeComponent();
            this.txt_username.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Trim() == " " || txt_password.Text.Trim() == " ")
            {
                MessageBox.Show("请输入用户名或密码~");
                return;
            }
            else {
                this.username = txt_username.Text;
                this.password = txt_password.Text;
                //验证用户密码
                bool verifyResult = stock_holderService.verifyPassword(this.username, this.password);
                if (verifyResult)
                {
                    this.Hide();
                    Form_Main main = new Form_Main();
                    main.Show();
                }
                else {
                    MessageBox.Show("输入密码错误");
                    txt_password.Text = "";
                    txt_password.Focus();
                }
            }
        }
    }
}
