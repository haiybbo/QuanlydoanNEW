using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Quenmatkhau : Form
    {
        public Quenmatkhau()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui Lòng nhập email đã đăng kí trên hệ thống!"); }
            else
            {
                string query = "Select * from Taikhoan where email ='" + txtemail.Text + "'";
                if (modify.Taikhoans(query).Count != 0)
                {
                    lblketqua.ForeColor = Color.Blue;
                    lblketqua.Text = "Mật khẩu: " + modify.Taikhoans(query)[0].Matkhau;
                }
                else
                {
                    lblketqua.ForeColor = Color.Red;
                    lblketqua.Text = "Email này chưa được đăng kí";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Quenmatkhau_Load(object sender, EventArgs e)
        {

        }

        private void btnendfgp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                        Frmsignin frmsignin = new Frmsignin();
            frmsignin.Show();
        }
    }
}
