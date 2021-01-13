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
using System.IO;

namespace KastAjansıOtomasyonu
{
    public partial class EkleOyuncuForm : Form
    {
        public string yol;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
         
        }

        private void cmbox_gözrengi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_kilo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_boy_TextChanged(object sender, EventArgs e)
        {
        }

        public EkleOyuncuForm()
        {
            InitializeComponent();
        }
        Database vt = new Database();
        public DateTime tarih;
      
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (VarMi(txt_Tcno.Text)!=0) {
                MessageBox.Show("Bu TC numara ile daha önce kayıt yapılmış.");
            }
            else { 
             vt.baglanti.Open();
                EkleOyuncuBilgi();
                EkleOyuncuİletisimBilgi();
                EkleKisiselBilgiler();
                XtraMessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); vt.baglanti.Close();
                OyuncuIslemForm of = new OyuncuIslemForm();
                of.Listele();
                vt.baglanti.Close();
            }

        }
        void EkleOyuncuBilgi() 
        {
            string resimpath = pictureEdit1.GetLoadedImageLocation();
            FileStream fs = new FileStream(resimpath,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            SqlCommand komutOB = new SqlCommand("insert into tblOyuncuBilgi (TCNO,AD,SOYAD,MESLEK,Dogumtarihi,Dogumyeri,fotograf) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",vt.baglanti);
            komutOB.Parameters.AddWithValue("@p1",txt_Tcno.Text);
            komutOB.Parameters.AddWithValue("@p2", txt_Ad.Text);
         
            komutOB.Parameters.AddWithValue("@p3", txt_Soyad.Text);
            komutOB.Parameters.AddWithValue("@p4", txt_Meslek.Text);
            komutOB.Parameters.AddWithValue("@p5", dateTimePicker1.Value);
       

            komutOB.Parameters.AddWithValue("@p6", txt_dogumyeri.Text);
            komutOB.Parameters.Add("@p7", SqlDbType.Image,resim.Length).Value=resim;
            komutOB.ExecuteNonQuery();
        }
        void EkleOyuncuİletisimBilgi() {
            SqlCommand komutOB = new SqlCommand("insert into tblOyuncuIletisimBilgileri (TCNO,Email,Facebook,Instagram,Website,CepTel,Evtel,Adres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",vt.baglanti);
            komutOB.Parameters.AddWithValue("@p1", txt_Tcno.Text);
            komutOB.Parameters.AddWithValue("@p2",txt_mail.Text);
            komutOB.Parameters.AddWithValue("@p3", txt_face.Text);
            komutOB.Parameters.AddWithValue("@p4",txt_insta.Text);
            komutOB.Parameters.AddWithValue("@p5", txt_website.Text);
            komutOB.Parameters.AddWithValue("@p6", txt_cepno.Text);
            komutOB.Parameters.AddWithValue("@p7", txt_evno.Text);
            komutOB.Parameters.AddWithValue("@p8", txt_adres.Text);
            komutOB.ExecuteNonQuery();


        }
        void EkleKisiselBilgiler() {
            SqlCommand komutOB = new SqlCommand("insert into tblOyuncuKisiselBilgiler (TCNO,boy,KILO,GOZRENGI,SACRENGI,OZGECMIS,cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", vt.baglanti);
            komutOB.Parameters.AddWithValue("@p1", txt_Tcno.Text);
            komutOB.Parameters.AddWithValue("@p2", txt_boy.Text);
            komutOB.Parameters.AddWithValue("@p3", txt_kilo.Text);
            komutOB.Parameters.AddWithValue("@p4", cmbox_gözrengi.SelectedItem.ToString());
            komutOB.Parameters.AddWithValue("@p5", cmbox_sacrengi.SelectedItem.ToString());
            komutOB.Parameters.AddWithValue("@p6", txt_özgecmis.Text);
            komutOB.Parameters.AddWithValue("@p7", cmbox_Cinsiyet.SelectedItem.ToString());


            komutOB.ExecuteNonQuery();
        }
        public int VarMi(string aranan)
        {
            int sonuc;
            SqlCommand komut;

            string sorgu = "Select COUNT(TCNO) from tblOyuncuBilgi WHERE TCNO='" + aranan + "'";
            komut = new SqlCommand(sorgu, vt.baglanti);
            vt.baglanti.Open();

            sonuc = Convert.ToInt32(komut.ExecuteScalar());

            vt.baglanti.Close();
            return sonuc;

        }
        private void labelControl16_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EkleOyuncuForm_Load(object sender, EventArgs e)
        {
            groupControl2.BackColor = Color.Transparent;
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            ToolTip acıklama = new ToolTip();
            acıklama.ToolTipTitle = "Bilgi";
            acıklama.ToolTipIcon = ToolTipIcon.Info;
            acıklama.IsBalloon = true;
            acıklama.SetToolTip(pictureEdit1, "Resimin üstüne sağ tık yaparak resim ekleyebilirsiniz.");
        }
    }
}
