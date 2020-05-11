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
    public partial class frmstokgüncel : Form
    {
        public frmstokgüncel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BEDIRHANERKıLıÇ\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
        


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmstokgüncel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public string StokKodu { get; set; }
        public string StokAdı { get; set; }
        public string MiktarTipi { get; set; }
        public string Katagori { get; set; }
        public string Marka { get; set; }
        public string AlısFiyat { get; set; }
        public string SatısFiyat { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {


            DataTable dt = new DataTable();
            //SqlConnection baglanti = new SqlConnection("Data Source=BEDIRHANERKıLıÇ\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
            string birQuery = "UPDATE [dbo].[Ürünekle1] ";
            string ikiQuery = "";
            string uçQuery = "Where";
            
            bool bosk2 = false;
            bool bosa2 = false;
            bool bomt2 = false;
            bool boka2 = false;
            bool boma2 = false;
            bool boaf = false;
            bool bosf = false;

            if (stokkodutxt.Text.ToString() != "")
            {
                bosk2 = true;
            }
            if (stokadtxt.Text.ToString() != "")
            {
                bosa2 = true;
            }
            if (miktartxt.Text.ToString() != "")
            {
                boma2 = true;
            }
            if (katagoritxt.Text.ToString() != "")
            {
                boka2 = true;
            }
            if (markatxt.Text.ToString() != "")
            {
                boma2 = true;
            }
            if (alıştxt.Text.ToString() != "")
            {
                boaf = true;
            }
            if (satıştxt.Text.ToString() != "")
            {
                bosf = true;
            }
            if (bosk2 == true)
            {
                ikiQuery = ikiQuery + " Set StokKodu = '" + stokkodutxt.Text.ToString() + "'";
            }
            if (bosa2 == true)
            {
                if (ikiQuery != "")
                {
                    ikiQuery = ikiQuery + " , StokAdı =  '" + stokadtxt.Text.ToString() + "'";
                }
                else
                {
                    ikiQuery = ikiQuery + " Set StokAdı =  '" + stokadtxt.Text.ToString() + "'";
                }
            }
            if (bomt2 == true)
            {
                if (ikiQuery != "")
                {
                    ikiQuery = ikiQuery + " , MiktarTipi =  '" + miktartxt.Text.ToString() + "'";
                }
                else
                {
                    ikiQuery = ikiQuery + " Set MiktarTip =  '" + miktartxt.Text.ToString() + "'";
                }
            }
            if (boka2 == true)
            {
                if (ikiQuery != "")
                {
                    ikiQuery = ikiQuery + " , Katagori = '" + katagoritxt.Text.ToString() + "'";
                }
                else
                {
                    ikiQuery = ikiQuery + " Set Katagori =  '" + katagoritxt.Text.ToString() + "'";
                }
            }
            if (boma2 == true)
            {
                if (ikiQuery != "")
                {
                    ikiQuery = ikiQuery + " , Marka =  '" + markatxt.Text.ToString() + "'";
                }
                else
                {
                    ikiQuery = ikiQuery + " Set Marka =  '" + markatxt.Text.ToString() + "'";
                }
            }
            if (boaf == true)
            {
                if (ikiQuery != "")
                {
                    ikiQuery = ikiQuery + " , AlısFiyat =  '" + alıştxt.Text.ToString() + "'";
                }
                else
                {
                    ikiQuery = ikiQuery + " Set AlısFiyat =  '" + alıştxt.Text.ToString() + "'";
                }
            }
            if (bosf == true)
            {
                if (ikiQuery != "")
                {
                    ikiQuery = ikiQuery + " , SatisFiyat = '" + satıştxt.Text.ToString() + "'";
                }
                else
                {
                    ikiQuery = ikiQuery + " Set SatisFiyat =  '" + satıştxt.Text.ToString() + "'";
                }
            }
            uçQuery = label1.Text;

            //MessageBox.Show(birQuery + " " + ikiQuery + " " +uçQuery);

   

            if (bosk2 == true || bosa2 == true || bomt2 == true || boka2 == true || boma2 == true || boaf==true || bosf==true) 
            {

            baglanti.Open();
            SqlCommand komut = new SqlCommand(birQuery + " " + ikiQuery + " " + uçQuery, baglanti);
            SqlDataReader güncelle = komut.ExecuteReader();
           
                MessageBox.Show("Güncelleme Tamamlandı");
                baglanti.Close();
            }
            else
            {
                MessageBox.Show(" Lütfen güncellenecek alanları doldurunuz!");
            }
          
        }

        private void frmstokgüncel_Load(object sender, EventArgs e)
        {
           
            
            label1.Text = frmgüncelleme2.eQueryGönder;

        }
    }
}
