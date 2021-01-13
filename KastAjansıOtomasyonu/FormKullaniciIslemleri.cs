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
    public partial class FormKullaniciIslemleri : Form
    {
        Database vt = new Database();
        public FormKullaniciIslemleri()
        {
            InitializeComponent();
        }
        string kAdi;
        private void FormKullaniciIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'castAjansVeriTabaniDataSet5.tblKullanıcıIslemleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblKullanıcıIslemleriTableAdapter.Fill(this.castAjansVeriTabaniDataSet5.tblKullanıcıIslemleri);
            // TODO: Bu kod satırı 'castAjansVeriTabaniDataSet5.tblKullanıcıIslemleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblKullanıcıIslemleriTableAdapter.Fill(this.castAjansVeriTabaniDataSet5.tblKullanıcıIslemleri);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string eskisifre = vericek(kAdi);
            eskisifre = eskisifre.Trim();
            vt.baglanti.Close();
            string eskisifre2 = textEdit2.Text;
            eskisifre2 = eskisifre2.Trim();
            string yenisifre = textEdit1.Text;
            string yenisifre2 = textEdit3.Text;
            kAdi = kAdi.Trim();
            yenisifre = yenisifre.Trim();
            yenisifre2 = yenisifre2.Trim();
            int deger = string.Compare(eskisifre,eskisifre2);

            if (string.Compare(eskisifre,eskisifre2)==0)
            {
               if (string.Compare(yenisifre, yenisifre2) == 0)
                {
                    verigüncelle(yenisifre, kAdi);
                    MessageBox.Show("Güncelleme İşlemi Tamamlandı.");
                }
                else { MessageBox.Show("Yeni girilen şifreler uyumsuz."); }
               
            }
             else { MessageBox.Show("Eski şifrenizi  yanlış girdiniz."); }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
           kAdi = dr[0].ToString();
         



        }
        string vericek(string kullaniciadi)
        { 
            vt.baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sifre from tblKullanıcıIslemleri where kullaniciAdı=@parametre",vt.baglanti);
            komut.Parameters.AddWithValue("@parametre",kullaniciadi);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read()) {
                string sifresi = oku[0].ToString();
                
                return sifresi;
            }
            else { return null; }
            
        }
        void verigüncelle(string yenisifre,string kullaniciadi)
        {
            vt.baglanti.Open();
            SqlCommand komut = new SqlCommand("update tblKullanıcıIslemleri set sifre=@p1 where kullaniciAdı=@parametre", vt.baglanti);
            komut.Parameters.AddWithValue("@parametre", kullaniciadi);
            komut.Parameters.AddWithValue("@p1",yenisifre);
            komut.ExecuteNonQuery();
            vt.baglanti.Close();
        }
    }
}
