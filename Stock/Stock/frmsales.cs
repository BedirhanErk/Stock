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
using System.Globalization;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace Stock
{
    public partial class frmsales : Form
    {
        public frmsales()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BEDIRHANERKıLıÇ\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");


        private void frmsales_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=BEDIRHANERKıLıÇ\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Users";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Name"] + " " + dr["Surname"]);

            }
            baglanti.Close();




        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1 && dataGridView1.CurrentCell.RowIndex >= 1)
            {
                var b = dataGridView1.CurrentCell.RowIndex;
                var a = dataGridView1.Rows[b].Cells[2].Value.ToString();
                var d = +1;
                var a1 = double.Parse(a.ToString());
                var d1 = double.Parse(d.ToString());
                var c = a1 + d1;
                this.dataGridView1.Rows[b].Cells[2].Value = c.ToString();
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            var b = dataGridView1.CurrentCell.RowIndex;
            var a = dataGridView1.Rows[b].Cells[2].Value.ToString();
            var d = -1;
            var a1 = double.Parse(a.ToString());
            var d1 = double.Parse(d.ToString());
            var c = a1 + d1;
            this.dataGridView1.Rows[b].Cells[2].Value = c.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.RowCount > 1 && dataGridView1.CurrentCell.RowIndex >= 1)
            {
                var b = dataGridView1.CurrentCell.RowIndex;
                var a = dataGridView1.Rows[b].Cells[2].Value.ToString();
                var d = 0.ToString();
                var a1 = double.Parse(a.ToString());
                var d1 = double.Parse(d.ToString());
                var c = a1 * d1;
                this.dataGridView1.Rows[b].Cells[2].Value = c.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into OrdersSummary(Price,SalesType,Customer,SalesDate,TotalPiece) values(@Price,@SalesType,@Customer,@SalesDate,@TotalPiece)", baglanti);
            komut.Parameters.AddWithValue("@Price", double.Parse(label3.Text));
            komut.Parameters.AddWithValue("@SalesType", 10);
            komut.Parameters.AddWithValue("@Customer", DBNull.Value);
            komut.Parameters.AddWithValue("@SalesDate", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));
            komut.Parameters.AddWithValue("@TotalPiece", label6.Text);

            komut.ExecuteNonQuery();

            MessageBox.Show("Satış eklendi");

            baglanti.Close();

            SqlCommand komut2 = new SqlCommand();
            baglanti.Open();
            komut2.Connection = baglanti;
            komut2.CommandText = "select top 1 * from OrdersSummary  order by Id desc ";
            komut2.ExecuteNonQuery();
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                label7.Text = dr2["Id"].ToString();
                
            }
            baglanti.Close();
            
          
            string firstQuery = "insert into Orders values ";
            string secondQuery = "";
            
            string[,] datagvw = new string[dataGridView1.RowCount, 5];

            for (int i = 1; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    datagvw[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    
                }
            }

            for (int i = 1; i < dataGridView1.RowCount; i++)
            {
                baglanti.Open();
                komut2.Connection = baglanti;
                string a= "select AlısFiyat from Ürünekle1 where Barkod =";
                a = a + datagvw[i,0];
                komut2.CommandText= a;
                komut2.ExecuteNonQuery();
                SqlDataReader dr4 = komut2.ExecuteReader();

                dr4.Read();
                string doo = dr4["AlısFiyat"].ToString();
                
                string[] abc;
                abc = doo.Split(',');
                doo = abc[0] + "." + abc[1];

                string[] ef;
                ef = datagvw[i, 3].Split(',');
                datagvw[i,3]=ef[0]+"."+ef[1];
                                                   
                secondQuery = secondQuery + "(" +label7.Text +","+datagvw[i, 0] + "," + datagvw[i, 2] + "," +datagvw[i, 3]+ "," +doo+ ")"+",";
                baglanti.Close();
                baglanti.Open();
                komut.Connection = baglanti;
                string q = "select Adet from Inventory where Barkod=";
                q = q + datagvw[i, 0];
                komut.CommandText = q;
                string w = " update Inventory set Adet=Adet-";
                w = w + datagvw[i, 2];
                w = w + "where Barkod=";
                w=w+ datagvw[i, 0];
                komut.CommandText = w;
                komut.ExecuteNonQuery();
                
                baglanti.Close();

                
            }            
           
            baglanti.Open();
            char[] charsToTrim = { ',' };
            string cleanString = secondQuery.TrimEnd(charsToTrim);
            SqlCommand komut3 = new SqlCommand(firstQuery  + " " + cleanString, baglanti);
            SqlDataReader orderekle = komut3.ExecuteReader();

            baglanti.Close();



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                SqlCommand komut = new SqlCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.Parameters.AddWithValue("@Barkod", textBox1.Text);
                komut.CommandText = "Select StokAdı,SatisFiyat from Ürünekle1 where Barkod=@Barkod";
                komut.ExecuteNonQuery();
                SqlDataReader oku = komut.ExecuteReader();


                if (oku.Read())
                {
                    string a = oku["StokAdı"].ToString();
                    var c = double.Parse(oku["SatisFiyat"].ToString());
                    var b = c * 1;
                    this.dataGridView1.Rows[0].Cells[0].Value = textBox1.Text;
                    this.dataGridView1.Rows[0].Cells[1].Value = a;
                    this.dataGridView1.Rows[0].Cells[2].Value = 1;
                    this.dataGridView1.Rows[0].Cells[3].Value = oku["SatisFiyat"];
                    this.dataGridView1.Rows[0].Cells[4].Value = b.ToString();
                    dataGridView1.Rows.Insert(0);
                    label2.Text = oku["SatisFiyat"].ToString();

                }
                else
                {
                    MessageBox.Show("Böyle bir ürün yok");
                }

                baglanti.Close();

            }

        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal xooo = 0;
            for(int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                xooo += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);

            }
            label6.Text = xooo.ToString();


            if (dataGridView1.RowCount > 1 && dataGridView1.CurrentCell.RowIndex >= 1)
            {
                var b = dataGridView1.CurrentCell.RowIndex;

                var a = dataGridView1.Rows[b].Cells[2].Value.ToString();
                var c = dataGridView1.Rows[b].Cells[3].Value.ToString();
                var e1 = double.Parse(a.ToString());
                var e2 = double.Parse(c.ToString());
                var d = e1 * e2;
                this.dataGridView1.Rows[b].Cells[4].Value = d.ToString();

            }

            decimal sum = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);

            }
            label3.Text = sum.ToString();

        }
       
        private void button8_Click_4(object sender, EventArgs e)
        {
            var b = dataGridView1.CurrentCell.RowIndex;
            var a = dataGridView1.Rows[b].Cells[2].Value.ToString();
            var d = textBox2.Text;
            var a1 = double.Parse(a.ToString());
            var d1 = double.Parse(d.ToString());
            var c = a1 * d1;
            this.dataGridView1.Rows[b].Cells[2].Value = c.ToString();

            textBox2.Clear();
        }
 

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1 && dataGridView1.CurrentCell.RowIndex >= 1)
            {
                var b = dataGridView1.CurrentCell.RowIndex;
                var d = 1;
                var d1 = double.Parse(d.ToString());
                var c = d1;
                this.dataGridView1.Rows[b].Cells[2].Value = c.ToString();
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1 && dataGridView1.CurrentCell.RowIndex >= 1)
            {
                var b = dataGridView1.CurrentCell.RowIndex;
                var d = 2;
                var d1 = double.Parse(d.ToString());
                var c = d1;
                this.dataGridView1.Rows[b].Cells[2].Value = c.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1 && dataGridView1.CurrentCell.RowIndex >= 1)
            {
                var b = dataGridView1.CurrentCell.RowIndex;
                var d = 3;
                var d1 = double.Parse(d.ToString());
                var c = d1;
                this.dataGridView1.Rows[b].Cells[2].Value = c.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1 && dataGridView1.CurrentCell.RowIndex >= 1)
            {
                var b = dataGridView1.CurrentCell.RowIndex;
                var d = 4;
                var d1 = double.Parse(d.ToString());
                var c = d1;
                this.dataGridView1.Rows[b].Cells[2].Value = c.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1 && dataGridView1.CurrentCell.RowIndex >= 1)
            {
                var b = dataGridView1.CurrentCell.RowIndex;
                var d = 5;
                var d1 = double.Parse(d.ToString());
                var c = d1;
                this.dataGridView1.Rows[b].Cells[2].Value = c.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1 && dataGridView1.CurrentCell.RowIndex >= 1)
            {
                var b = dataGridView1.CurrentCell.RowIndex;
                var d = 6;
                var d1 = double.Parse(d.ToString());
                var c = d1;
                this.dataGridView1.Rows[b].Cells[2].Value = c.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1 && dataGridView1.CurrentCell.RowIndex >= 1)
            {
                var b = dataGridView1.CurrentCell.RowIndex;
                var d = 7;
                var d1 = double.Parse(d.ToString());
                var c = d1;
                this.dataGridView1.Rows[b].Cells[2].Value = c.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1 && dataGridView1.CurrentCell.RowIndex >= 1)
            {
                var b = dataGridView1.CurrentCell.RowIndex;
                var d = 8;
                var d1 = double.Parse(d.ToString());
                var c = d1;
                this.dataGridView1.Rows[b].Cells[2].Value = c.ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1 && dataGridView1.CurrentCell.RowIndex >= 1)
            {
                var b = dataGridView1.CurrentCell.RowIndex;
                var d = 9;
                var d1 = double.Parse(d.ToString());
                var c = d1;
                this.dataGridView1.Rows[b].Cells[2].Value = c.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into OrdersSummary(Price,SalesType,Customer,SalesDate,TotalPiece) values(@Price,@SalesType,@Customer,@SalesDate,@TotalPiece)", baglanti);
            komut.Parameters.AddWithValue("@Price", double.Parse(label3.Text));
            komut.Parameters.AddWithValue("@SalesType", 30);
            komut.Parameters.AddWithValue("@Customer", DBNull.Value);
            komut.Parameters.AddWithValue("@SalesDate", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"));
            komut.Parameters.AddWithValue("@TotalPiece", label6.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("Satış eklendi");
            baglanti.Close();


            SqlCommand komut2 = new SqlCommand();
            baglanti.Open();
            komut2.Connection = baglanti;
            komut2.CommandText = "select top 1 * from OrdersSummary  order by Id desc ";
            komut2.ExecuteNonQuery();
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                label7.Text = dr2["Id"].ToString();

            }
            baglanti.Close();


            string firstQuery = "insert into Orders values ";
            string secondQuery = "";

            string[,] datagvw = new string[dataGridView1.RowCount, 5];

            for (int i = 1; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    datagvw[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                }
            }
            for (int i = 1; i < dataGridView1.RowCount; i++)
            {
                baglanti.Open();
                komut2.Connection = baglanti;
                string a = "select AlısFiyat from Ürünekle1 where Barkod =";
                a = a + datagvw[i, 0];
                komut2.CommandText = a;
                komut2.ExecuteNonQuery();
                SqlDataReader dr4 = komut2.ExecuteReader();

                dr4.Read();
                string doo = dr4["AlısFiyat"].ToString();

                string[] abc;
                abc = doo.Split(',');
                doo = abc[0] + "." + abc[1];

                string[] ef;
                ef = datagvw[i, 3].Split(',');
                datagvw[i, 3] = ef[0] + "." + ef[1];
               
                secondQuery = secondQuery + "(" + label7.Text + "," + datagvw[i, 0] + "," + datagvw[i, 2] + "," + datagvw[i, 3] + "," + doo + ")" + ",";

                baglanti.Close();
                baglanti.Open();
                komut.Connection = baglanti;
                string q = "select Adet from Inventory where Barkod=";
                q = q + datagvw[i, 0];
                komut.CommandText = q;
                string w = " update Inventory set Adet=Adet-";
                w = w + datagvw[i, 2];
                w = w + "where Barkod=";
                w = w + datagvw[i, 0];
                komut.CommandText = w;
                komut.ExecuteNonQuery();

                baglanti.Close();

            }
            baglanti.Open();
            char[] charsToTrim = { ',' };
            string cleanString = secondQuery.TrimEnd(charsToTrim);
            SqlCommand komut3 = new SqlCommand(firstQuery + " " + cleanString, baglanti);
            SqlDataReader orderekle = komut3.ExecuteReader();

            baglanti.Close();

           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İptal etmek istediğnizden emin misniz?");
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into OrdersSummary(Price,SalesType,Customer,SalesDate,TotalPiece) values(@Price,@SalesType,@Customer,@SalesDate,@TotalPiece)", baglanti);
            komut.Parameters.AddWithValue("@Price", double.Parse(label3.Text));
            komut.Parameters.AddWithValue("@SalesType", 20);
            komut.Parameters.AddWithValue("@Customer", comboBox1.Text);
            komut.Parameters.AddWithValue("@SalesDate", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff "));
            komut.Parameters.AddWithValue("@TotalPiece", label6.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("Veresiye Satış Eklendi");
            baglanti.Close();

            SqlCommand komut2 = new SqlCommand();
            baglanti.Open();
            komut2.Connection = baglanti;
            komut2.CommandText = "select top 1 * from OrdersSummary  order by Id desc ";
            komut2.ExecuteNonQuery();
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                label7.Text = dr2["Id"].ToString();

            }
            baglanti.Close();



            string firstQuery = "insert into Orders values ";
            string secondQuery = "";

            string[,] datagvw = new string[dataGridView1.RowCount, 5];

            for (int i = 1; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    datagvw[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                }
            }
            for (int i = 1; i < dataGridView1.RowCount; i++)
            {
                baglanti.Open();
                komut2.Connection = baglanti;
                string a = "select AlısFiyat from Ürünekle1 where Barkod =";
                a = a + datagvw[i, 0];
                komut2.CommandText = a;
                komut2.ExecuteNonQuery();
                SqlDataReader dr4 = komut2.ExecuteReader();

                dr4.Read();
                string doo = dr4["AlısFiyat"].ToString();

                string[] abc;
                abc = doo.Split(',');
                doo = abc[0] + "." + abc[1];

                string[] ef;
                ef = datagvw[i, 3].Split(',');
                datagvw[i, 3] = ef[0] + "." + ef[1];

                secondQuery = secondQuery + "(" + label7.Text + "," + datagvw[i, 0] + "," + datagvw[i, 2] + "," + datagvw[i, 3] + "," + doo + ")" + ",";
                baglanti.Close();
                baglanti.Open();
                komut.Connection = baglanti;
                string q = "select Adet from Inventory where Barkod=";
                q = q + datagvw[i, 0];
                komut.CommandText = q;
                string w = " update Inventory set Adet=Adet-";
                w = w + datagvw[i, 2];
                w = w + "where Barkod=";
                w = w + datagvw[i, 0];
                komut.CommandText = w;
                komut.ExecuteNonQuery();

                baglanti.Close();

                
            }
            baglanti.Open();
            char[] charsToTrim = { ',' };
            string cleanString = secondQuery.TrimEnd(charsToTrim);
            SqlCommand komut3 = new SqlCommand(firstQuery + " " + cleanString, baglanti);
            SqlDataReader orderekle = komut3.ExecuteReader();
            baglanti.Close();

        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
