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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }
        Users_Form u = new Users_Form();

        private void frmgiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            u.kullanıcı(txtemail,txtsifre);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmüyeol üyeol = new frmüyeol();
            üyeol.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmşifredeğiştir üyeol = new frmşifredeğiştir();
            üyeol.Show();
            this.Hide();
        }
    }
}
