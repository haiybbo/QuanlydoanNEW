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
    public partial class frmsearchdoan : Form
    {
        public frmsearchdoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmsinhvienmain yourthesis = new Frmsinhvienmain();
            yourthesis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmstudentprofile sp = new frmstudentprofile();
            sp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmdanhsachgiangvien f = new Frmdanhsachgiangvien();
            f.Show();
        }

        private void frmsearchdoansinhvien_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
