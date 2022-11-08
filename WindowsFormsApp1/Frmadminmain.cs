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
    public partial class Frmadminmain : Form
    {
        //  et
        public Frmadminmain()
        {
            InitializeComponent();
        }

        private void Frmadminmain_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmdanhsachgiangvien f = new Frmdanhsachgiangvien();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmdanhsachsinhvien f = new Frmdanhsachsinhvien();
            f.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frmsearchdoan_admin f = new Frmsearchdoan_admin();
            f.Show();
        }

        private void lblchaomung_Click(object sender, EventArgs e)
        {

        }
    }
}
