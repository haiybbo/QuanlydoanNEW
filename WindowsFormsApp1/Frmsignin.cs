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
    public partial class Frmsignin : Form
    {
        //chỉnh cursor default
        public Frmsignin()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        Phanquyen phanquyen = new Phanquyen();
        private void btnsignin2_Click(object sender, EventArgs e)
        {
            string tentk = txtusername.Text;
            string matkhau = txtpassword.Text;
            if(tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }
            else
            {
                string query = "Select * from Taikhoan where tentaikhoan ='" + tentk + "' and matkhau = '" + matkhau + "'";
                if (modify.Taikhoans(query).Count !=0 )
                {
                    if (phanquyen.role(query)[0].Phanquyen == "1")
                    {
                        Frmsinhvienmain frmsinhvienmain = new Frmsinhvienmain();
                        frmsinhvienmain.Show();
                    }
                    else if (phanquyen.role(query)[0].Phanquyen == "2")
                    {
                        Frmgiangvienmain frmgiangvienmain = new Frmgiangvienmain();
                        frmgiangvienmain.Show();
                    }
                    else 
                    {
                        Frmadminmain frmadminmain = new Frmadminmain();
                        frmadminmain.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblquenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Quenmatkhau quenmatkhau = new Quenmatkhau();
            quenmatkhau.Show();
            this.Close();
        }
    }
}
