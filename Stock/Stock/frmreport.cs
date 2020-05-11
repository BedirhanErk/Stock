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
    public partial class frmreport : Form
    {
        public frmreport()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BEDIRHANERKıLıÇ\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from Report where SalesDate BETWEEN @Date1 and @Date2";
            komut.Parameters.AddWithValue("@Date1",SqlDbType.DateTime).Value=dateTimePicker1.Value;
            komut.Parameters.AddWithValue("@Date2",SqlDbType.DateTime).Value = dateTimePicker2.Value;
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                this.dataGridView1.Rows[0].Cells[0].Value = oku["Barcode"];
                this.dataGridView1.Rows[0].Cells[1].Value = oku["Piece"];
                this.dataGridView1.Rows[0].Cells[2].Value = oku["SellingPrice"];
                this.dataGridView1.Rows[0].Cells[3].Value = oku["BuyingPrice"];
                this.dataGridView1.Rows[0].Cells[4].Value = oku["SalesType"];
                this.dataGridView1.Rows[0].Cells[5].Value = oku["Customer"];
                this.dataGridView1.Rows[0].Cells[6].Value = oku["SalesDate"];
                dataGridView1.Rows.Insert(0);

            }
            
            baglanti.Close();
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

    }
}
    