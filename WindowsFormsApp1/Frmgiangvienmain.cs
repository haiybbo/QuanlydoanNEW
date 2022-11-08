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
    public partial class Frmgiangvienmain : Form
    {
        public Frmgiangvienmain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmprofilegiangvien f = new Frmprofilegiangvien();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmdanhsachsinhvien f = new Frmdanhsachsinhvien();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmsearchdoan f = new frmsearchdoan();
            f.Show();
        }
    }
}
