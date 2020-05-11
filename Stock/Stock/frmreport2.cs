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
using excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Net.Mail;
using System.Net;
using System.IO;


namespace Stock
{
    public partial class frmreport2 : Form
    {
        public frmreport2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BEDIRHANERKıLıÇ\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
        private void frmreport2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {

                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                myRange.Value = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 1; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 1, i + 1];
                    myRange.Value = dataGridView1[i, j].Value;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from Report2 where Barkod=@Barkod";
            komut.Parameters.AddWithValue("@Barkod", textBox1.Text);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                this.dataGridView1.Rows[0].Cells[0].Value = oku["Barkod"];
                this.dataGridView1.Rows[0].Cells[1].Value = oku["Adet"];
                this.dataGridView1.Rows[0].Cells[2].Value = oku["SatisFiyat"];
                this.dataGridView1.Rows[0].Cells[3].Value = oku["AlısFiyat"];
                this.dataGridView1.Rows[0].Cells[4].Value = oku["StokAdı"];
                this.dataGridView1.Rows[0].Cells[5].Value = oku["Katagori"];
                this.dataGridView1.Rows[0].Cells[6].Value = oku["Marka"];
                dataGridView1.Rows.Insert(0);

            }

            baglanti.Close();
        }
    }
}
