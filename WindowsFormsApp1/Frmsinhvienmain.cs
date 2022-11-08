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
    public partial class Frmsinhvienmain : Form
    {
        public Frmsinhvienmain()
        {
            InitializeComponent();
        }

        private void Frmdoancuaban_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmstudentprofile sp = new frmstudentprofile();
            sp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmsearchdoan search = new frmsearchdoan();
            search.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmdanhsachgiangvien f = new Frmdanhsachgiangvien();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmtrogiupsinhvien f = new Frmtrogiupsinhvien();
            f.Show();
        }
    }
}
