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

namespace KastAjansıOtomasyonu
{
    public partial class Login : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        Database vt = new Database();
        public Login()
        {
            InitializeComponent();
            Init_Data();
        }
      
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şifreni mi unuttun ");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giriş başarılı ");

        }

        private void labelControl1_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void labelControl1_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
         MessageBox.Show("SQL SERVER hizmetini aktif etmeyi unutmayınız.\n Aksi halde hata ile karşılaşabilirsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Save_Data();
            string kad = textEdit1.Text;
            string sifre = textEdit2.Text;
            kad.Trim(); sifre.Trim();
           if(kad.Equals("") || sifre.Equals(""))
            {

                MessageBox.Show("Lütfen istenen kutucukları doldurun.");

            }
            else
            {
                kontrol(kad,sifre);
            }






        }

        private void textEdit1_Enter(object sender, EventArgs e)
        {
         
        }

        private void textEdit1_Leave(object sender, EventArgs e)
        {
            
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            FormSifreUnuttum frsifreunuttum = new FormSifreUnuttum();
            frsifreunuttum.Show();
        }

        void kontrol(string kAd,string password)
        {

            
            try
            {
                vt.baglanti.Open();

                SqlCommand komut = new SqlCommand("Select * from tblKullanıcıIslemleri where kullaniciAdı=@kAd and sifre=@password", vt.baglanti);
                komut.Parameters.AddWithValue("@kAd", kAd);
                komut.Parameters.AddWithValue("@password",password);
                komut.ExecuteNonQuery();
                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    MainPage anasayfa = new MainPage();
                    anasayfa.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyin.");


                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu. Lütfen Yazılım yöneticisi ile iletişime geçiniz."+ex);

                throw;
            }
            finally { vt.baglanti.Close(); }
           
        


        }
        private void Init_Data() {
            if (Properties.Settings.Default.UserName!=string.Empty) {

                if (Properties.Settings.Default.Remember == true)
                {
                    textEdit1.Text = Properties.Settings.Default.UserName;
                    checkEdit1.Checked = true;

                }
                else
                {
                    textEdit1.Text = Properties.Settings.Default.UserName;
                }
            }
        }
        private void Save_Data() {
            if (checkEdit1.Checked)
            {
                Properties.Settings.Default.UserName = textEdit1.Text.Trim();
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();


            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();

            }
        
        }
     

    }
}
