using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock
{
    
    class Class1
    {
        SqlConnection baglanti2 = new SqlConnection("Data Source=BEDIRHANERKıLıÇ\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
        SqlCommand komut2;
        SqlDataReader read2;
        frmgiris yeni = new frmgiris();
        public SqlDataReader kullanıcı2(ComboBox Email)
        {
            baglanti2.Open();
            komut2 = new SqlCommand();
            komut2.Connection = baglanti2;
            komut2.CommandText = "select * from Users where Email='" + Email.Text + "'";
            read2 = komut2.ExecuteReader();
            if (read2.Read() == true)
            {
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz");
            }
            baglanti2.Close();
            return read2;
        }
    }
}
