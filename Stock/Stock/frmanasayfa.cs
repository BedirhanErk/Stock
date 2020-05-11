using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class frmanasayfa : Form
    {
        public frmanasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmürünekle üyeol = new frmürünekle();
            üyeol.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmgüncelleme2 üyeol = new frmgüncelleme2();
            üyeol.Show();
           // this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmadetgüncelleme üyeol = new frmadetgüncelleme();
            üyeol.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmsales üyeol = new frmsales();
            üyeol.Show();
           // this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmreportb report = new frmreportb();
            report.Show();
           // this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void frmanasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
