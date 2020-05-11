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
    public partial class frmreportb : Form
    {
        public frmreportb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmreport2 üyeol = new frmreport2();
            üyeol.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmreport sales = new frmreport();
            sales.Show();
            this.Hide();
        }
    }
}
