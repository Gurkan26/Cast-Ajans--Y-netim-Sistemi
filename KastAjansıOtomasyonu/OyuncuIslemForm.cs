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
using DevExpress.XtraEditors;
namespace KastAjansıOtomasyonu
{
    public partial class OyuncuIslemForm : Form
    {
        public static string Veritutucu { get; set; }
        public static string QrVeriTutucu { get; set; }

        public OyuncuIslemForm()
        {
            InitializeComponent();
        }
        Database veritabanı = new Database();

        private void OyuncuIslemForm_Load(object sender, EventArgs e)
        {
            Listele();
            gridView1.OptionsBehavior.Editable = false;

        }
      public  void Listele() {
            SqlDataAdapter da = new SqlDataAdapter("Select tblOyuncuBilgi.TCNO, tblOyuncuBilgi.Ad, tblOyuncuBilgi.Soyad, tblOyuncuBilgi.Meslek, tblOyuncuBilgi.Dogumtarihi, tblOyuncuBilgi.dogumyeri, tblOyuncuIletisimBilgileri.Email, tblOyuncuIletisimBilgileri.CepTel, tblOyuncuIletisimBilgileri.EvTel, tblOyuncuIletisimBilgileri.Adres from tblOyuncuBilgi, tblOyuncuIletisimBilgileri where tblOyuncuBilgi.TCNO = tblOyuncuIletisimBilgileri.TCNO", veritabanı.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkleOyuncuForm ekleForm = new EkleOyuncuForm();
            ekleForm.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
           
            if (XtraMessageBox.Show(dr[0].ToString() + " TCNO'lu oyuncuyu silmek istediğine emin misin? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { 

            veritabanı.baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from tblOyuncuBilgi where TCNO=@p1",veritabanı.baglanti);
            komutsil.Parameters.AddWithValue("@p1",dr[0].ToString());
            komutsil.ExecuteNonQuery();
            MessageBox.Show("Silme işlemi başarılı.");
            veritabanı.baglanti.Close();
            Listele();
            }

        }

       

        private void detaylarıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetayveGüncellemeForm fr1 = new DetayveGüncellemeForm();
            fr1.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
          



        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
          
            Veritutucu = dr[0].ToString();
            QrVeriTutucu = "Ad: " + dr[1].ToString()+ "\n Soyad: " + dr[2].ToString()+ "\n Meslegi: " + dr[3].ToString()+ "\n Telefon Numarasi: " + dr[7].ToString();

        }

        private void tabloyuYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void qRCODEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQRCodeoluştur qr = new FormQRCodeoluştur();
            qr.Show();
        }
    }
}
