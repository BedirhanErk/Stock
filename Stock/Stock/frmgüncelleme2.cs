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
    public partial class frmgüncelleme2 : Form
    {
        public frmgüncelleme2()
        {
            InitializeComponent();
        }

          public static string eQueryGönder;
          public static string sayıGönder;



        SqlConnection baglanti = new SqlConnection("Data Source=BEDIRHANERKıLıÇ\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
    

            string sQuery = "SELECT [Barkod],[StokKodu],[StokAdı],[MiktarTipi],[Katagori],[Marka],[AlısFiyat],[SatisFiyat]FROM [dbo].[Ürünekle1] ";
            string eQuery = "";
           
            
           
            bool bobrk = false;
            bool bosk = false;
            bool bosa = false;
            bool bomt = false;
            bool boka = false;
            bool boma = false;

            if (textBox1.Text.ToString() != "")
            {
                bobrk = true;
            }
            if (textBox2.Text.ToString() != "")
            {
                bosk = true;
            }
            if (textBox3.Text.ToString() != "")
            {
                bosa = true;
            }
            if (textBox4.Text.ToString() != "")
            {
                bomt = true;
            }
            if (textBox5.Text.ToString() != "")
            {
                boka = true;
            }
            if (textBox6.Text.ToString() != "")
            {
                boma = true;
            }
            if (bobrk==true)
            {
                eQuery = eQuery + "Where Barkod like '%" + textBox1.Text.ToString() + "%'";

            }
            if (bosk==true)
            {
                if (eQuery!="")
                {
                    eQuery = eQuery + " and StokKodu like '%" + textBox2.Text.ToString()+"%'";
                }
                else
                {
                    eQuery = eQuery + "Where  StokKodu like '%" + textBox2.Text.ToString() + "%'";
                }
            }
            if (bosa == true)
            {
                if (eQuery != "")
                {
                    eQuery = eQuery + " and StokAdı like '%" + textBox3.Text.ToString() + "%'";
                }
                else
                {
                    eQuery = eQuery + "Where  StokAdı like '%" + textBox3.Text.ToString() + "%'";
                }
            }
            if (bomt == true)
            {
                if (eQuery != "")
                {
                    eQuery = eQuery + " and MiktarTipi like '%" + textBox4.Text.ToString() + "%'";
                }
                else
                {
                    eQuery = eQuery + "Where  MiktarTipi like '%" + textBox4.Text.ToString() + "%'";
                }
            }
            if (boka == true)
            {
                if (eQuery != "")
                {
                    eQuery = eQuery + " and Katagori like '%" + textBox5.Text.ToString() + "%'";
                }
                else
                {
                    eQuery = eQuery + "Where  Katagori like '%" + textBox5.Text.ToString() + "%'";
                }
            }
            if (boma == true)
            {
                if (eQuery != "")
                {
                    eQuery = eQuery + " and Marka like '%" + textBox6.Text.ToString() + "%'";
                }
                else
                {
                    eQuery = eQuery + "Where  Marka like '%" + textBox6.Text.ToString() + "%'";
                }
            }
            //MessageBox.Show(sQuery+" "+eQuery);

            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sQuery + " " + eQuery, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Barkod"].ToString();
                ekle.SubItems.Add(oku["StokKodu"].ToString());
                ekle.SubItems.Add(oku["StokAdı"].ToString());
                ekle.SubItems.Add(oku["MiktarTipi"].ToString());
                ekle.SubItems.Add(oku["Katagori"].ToString());
                ekle.SubItems.Add(oku["Marka"].ToString());
                ekle.SubItems.Add(oku["AlısFiyat"].ToString());
                ekle.SubItems.Add(oku["SatisFiyat"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
            eQueryGönder = eQuery;
           
            frmstokgüncel f2 = new frmstokgüncel();
       
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmgüncelleme2_Load(object sender, EventArgs e)
        {
                
        }
     

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count>0)
            {

                frmstokgüncel frm = new frmstokgüncel();
                frm.StokKodu = textBox2.Text;
                frm.StokAdı = textBox3.Text;
                frm.MiktarTipi = textBox4.Text;
                frm.Katagori = textBox5.Text;
                frm.Marka = textBox6.Text;
                frm.AlısFiyat = textBox7.Text;
                frm.SatısFiyat = textBox8.Text;
                frm.ShowDialog();

               
            }
            else
            {
                MessageBox.Show("Güncellenecek hiç ürün bulunamadı");
            }

            


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
