using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock
{
    class Users_Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=BEDIRHANERKıLıÇ\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;       
        public SqlDataReader kullanıcı(TextBox Email,TextBox Sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from users where Email='"+Email.Text+"'";
            read = komut.ExecuteReader();

            if (read.Read()==true)
            {
                if (Sifre.Text==read["Password"].ToString())
                {
                    MessageBox.Show("Giriş Yapıldı");
                    frmanasayfa üyeol = new frmanasayfa();
                    üyeol.Show();
                   

                }
                else
                {
                    MessageBox.Show("Sifrenizi kontrol ediniz", "Hata1");
                }
            }
            else
            {
                MessageBox.Show("Bilgileriniz kontrol ediniz", "Hata2");
            }
            baglanti.Close();
            return read;
        }
        public void yenikullanıcı(TextBox Name,TextBox Surname,TextBox Email,TextBox Password, TextBox PasswordAgain,GroupBox grup)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=BEDIRHANERKıLıÇ\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
            baglanti.Open();
            string usersEmailQuery = "select Email from Users";
            SqlCommand cmd = new SqlCommand(usersEmailQuery, baglanti);
            SqlDataReader dr = cmd.ExecuteReader();

            bool exist = false;
            while (dr.Read())
            {
                int i = 0;
                if (Email.Text.ToString() == dr.GetValue(i).ToString())
                {
                    MessageBox.Show("Böyle Bir kullanıcı var");
                    exist = true;
                }
                i = i + 1;
            }
            baglanti.Close();

            if (exist ==false)
            {
                if (Password.Text == PasswordAgain.Text  )
                {
 
                    baglanti.Open();
                    komut = new SqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "insert into Users values('" + Name.Text.ToString() + "','" + Surname.Text.ToString() + "','" + Email.Text.ToString() + "','" + Password.Text.ToString() + "')";
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("New User");
                    foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";
                  
                }
                else
                {
                    MessageBox.Show("Sifreler uyusmuyor", "Hata");
                }
            }

        }
    }
}
