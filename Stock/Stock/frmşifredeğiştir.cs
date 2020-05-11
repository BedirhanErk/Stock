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
using System.Net.Mail;
using System.Net;
using System.IO;


namespace Stock
{
    public partial class frmşifredeğiştir : Form
    {
        public frmşifredeğiştir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BEDIRHANERKıLıÇ\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
        Class1 u = new Class1();
        private void button1_Click(object sender, EventArgs e)
        {
            


            u.kullanıcı2(comboBox1).ToString();
            frmgiris yeni = new frmgiris();


            if (textBox1.Text == textBox2.Text && label5.Text == textBox3.Text)
            {

                baglanti.Open();
                SqlCommand komut4 = new SqlCommand("update Users set Password='" + textBox1.Text.ToString() + "'where Email=" + "'"+comboBox1.Text.ToString()+"'" + "", baglanti);
                komut4.ExecuteNonQuery();
                MessageBox.Show("Şifreniz Değiştirilmiştir");

                frmgiris üyeol = new frmgiris();
                üyeol.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmşyor");
            }
            baglanti.Close();
        }
        private void frmşifredeğiştir_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=BEDIRHANERKıLıÇ\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * from Users";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Email"]);
            }
            baglanti.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rsayı;
            Random r = new Random();
            rsayı = r.Next(10000, 99999);
            label5.Text = rsayı.ToString();

            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("stokprogram@outlook.com", "sifre123");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesaj.To.Add(comboBox1.Text);
            mesaj.From = new MailAddress("stokprogram@outlook.com");
            mesaj.Subject = label4.Text;
            mesaj.Body = label5.Text;
            istemci.Send(mesaj);
        }
    }
}
