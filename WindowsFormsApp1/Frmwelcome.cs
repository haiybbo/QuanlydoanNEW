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
    public partial class Frmwelcome : Form
    {
        public Frmwelcome()
        {
            InitializeComponent();
        }

        private void Frmwelcome_Load(object sender, EventArgs e)
        {

        }

        private void btnsignup1_Click(object sender, EventArgs e)
        {

        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            Frmsignin frmsignin = new Frmsignin();
            frmsignin.Show();
            this.Close();
        }
    }
}
