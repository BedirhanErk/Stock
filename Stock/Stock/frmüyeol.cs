using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stock
{
    public partial class frmüyeol : Form
    {
        public frmüyeol()
        {
            InitializeComponent();
        }
        Users_Form u = new Users_Form();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            u.yenikullanıcı(nametxt,surnametxt,emailtxt,passwordtxt,passwordagaintxt,groupBox1);
            frmgiris üyeol = new frmgiris();
            üyeol.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           SqlConnection baglanti = new SqlConnection("Data Source=BEDIRHANERKıLıÇ\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
            baglanti.Open();
            string usersEmailQuery = "select Email from Users";
            SqlCommand cmd = new SqlCommand(usersEmailQuery,baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            string a = "";
            while (dr.Read())
            {
                int i = 0;
                a = a + dr.GetValue(i).ToString()+";";
                i = i + 1;
            }
            baglanti.Close();
            
        }
    }
}
