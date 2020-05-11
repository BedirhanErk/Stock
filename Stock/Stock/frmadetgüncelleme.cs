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
    public partial class frmadetgüncelleme : Form
    {
        public frmadetgüncelleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BEDIRHANERKıLıÇ\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Update Inventory set Adet=@Adet where Barkod=@Barkod";
            komut.Parameters.AddWithValue("@Barkod", textBox1.Text);
            komut.Parameters.AddWithValue("@Adet", textBox2.Text);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            MessageBox.Show("Adet Güncellendi!");
          
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from ProductInventory where Barkod=@Barkod ";
            komut.Parameters.AddWithValue("@Barkod", textBox1.Text);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label2.Text = dr["StokAdı"].ToString() ;
                label3.Text = dr["Adet"].ToString();
                


            }
            else
            {
                MessageBox.Show("Böyle bir barkod yok!!!!!!!!");
            }
            
        
            baglanti.Close();
        }

        private void AdetGüncelleme_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
