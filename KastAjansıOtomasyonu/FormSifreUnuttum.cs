using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace KastAjansıOtomasyonu
{
    public partial class FormSifreUnuttum : Form
    {
        Database vt = new Database();
        public FormSifreUnuttum()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            vt.baglanti.Open();
            string sifre = SifreDonen();
            vt.baglanti.Close();

            MailMessage eposta = new MailMessage();
            eposta.From = new MailAddress("deneyici1234@gmail.com");
            eposta.To.Add(textEdit2.Text);
            eposta.Subject = "Şifrenizi unuttunuz.";
            
            eposta.Body = "Şifreniz: '"+sifre+"' . Lütfen birdaha şifrenizi unutmayın. Zaten basit.";
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new System.Net.NetworkCredential("deneyici1234@gmail.com", "123gurkan123");
            smtp.Port = 587; ;
            
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            
            try
            {

                smtp.Send(eposta);
                MessageBox.Show("Mail başarıyla gönderildi.");
            }
            catch(SmtpException ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message,"Mail gönderme hatası");

            }


        
        }

        string SifreDonen()
        {
            
            string sifre;
            SqlCommand komut = new SqlCommand("Select sifre from tblKullanıcıIslemleri",vt.baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                sifre = dr[0].ToString();
                return sifre;
            }
            else { return null; }

          


        }
        private void FormSifreUnuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
