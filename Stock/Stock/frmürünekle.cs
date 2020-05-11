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
    public partial class frmürünekle : Form
    {
        public frmürünekle()
        {
            InitializeComponent();
        }
        //Users_Form u = new Users_Form();
        SqlConnection baglanti = new SqlConnection("Data Source=BEDIRHANERKıLıÇ\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtalışfiyatı.Text == "" || txtsatışfiyatı.Text == "" || txtadet.Text == "")
            {
                MessageBox.Show("Lütfen Değerlerinizi giriniz");
                return;
            }
           
           /* u.yeniürün(txtbarkod, txtstokkodu, txtstokadı, cmboxmiktartipi, txtkatagori,txtmarka,txtalışfiyatı,txtsatışfiyatı )*/;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Ürünekle1(Barkod,StokKodu,StokAdı,MiktarTipi,Katagori,Marka,AlısFiyat,SatisFiyat) values(@Barkod,@StokKodu,@StokAdı,@MiktarTipi,@Katagori,@Marka,@AlısFiyat,@SatisFiyat)", baglanti);
            SqlCommand komut2 = new SqlCommand("insert into Inventory(Barkod,Adet) values(@Barkod,@Adet)", baglanti);
            string Ürünekle1EmailQuery = "select Barkod from Ürünekle1";
            
            SqlCommand cmd = new SqlCommand(Ürünekle1EmailQuery, baglanti);
            
            SqlDataReader dr = cmd.ExecuteReader();
            
            string Barcode = txtbarkod.Text.ToString();
            bool exist = false;
            while (dr.Read())
            {
                int i = 0;
                if (Barcode == dr.GetValue(i).ToString())
                {
                    MessageBox.Show("Böyle bir barkod var");
                    exist = true;
                }
                i = i + 1;
            }
            baglanti.Close();
            if (exist == false)
            {
                baglanti.Open();
                komut.Parameters.AddWithValue("@Barkod", txtbarkod.Text);
                komut.Parameters.AddWithValue("@StokKodu", txtstokkodu.Text);
                komut.Parameters.AddWithValue("@StokAdı", txtstokadı.Text);
                komut.Parameters.AddWithValue("@MiktarTipi", cmboxmiktartipi.Text);
                komut.Parameters.AddWithValue("@Katagori", txtkatagori.Text);
                komut.Parameters.AddWithValue("@Marka", txtmarka.Text);
                komut.Parameters.AddWithValue("@AlısFiyat", double.Parse(txtalışfiyatı.Text));
                komut.Parameters.AddWithValue("@SatisFiyat", double.Parse(txtsatışfiyatı.Text));
                
                komut2.Parameters.AddWithValue("@Barkod", txtbarkod.Text);
                komut2.Parameters.AddWithValue("@Adet", double.Parse(txtadet.Text));
               
                komut.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                baglanti.Close();


                MessageBox.Show("Ürün eklendi");

            }

          
         
                    }

        private void txtbarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtkatagori_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 