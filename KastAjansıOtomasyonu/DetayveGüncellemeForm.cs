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
using System.IO;

namespace KastAjansıOtomasyonu
{
    public partial class DetayveGüncellemeForm : Form
    {
        Database vt = new Database();
        public string gelentc;
        public byte[] resimadres;
        public DetayveGüncellemeForm()
        {

            InitializeComponent();
       

        }

        private void DetayveGüncellemeForm_Load(object sender, EventArgs e)
        {

        gelentc = OyuncuIslemForm.Veritutucu;
            Listele(gelentc);
           

        }

        void Listele(string tcno) {

            try
            {
                vt.baglanti.Open();
                SqlCommand komut = new SqlCommand(" Select * from tblOyuncuBilgi, tblOyuncuIletisimBilgileri, tblOyuncuKisiselBilgiler where tblOyuncuBilgi.TCNO =@parametre and tblOyuncuKisiselBilgiler.TCNO = tblOyuncuBilgi.TCNO and tblOyuncuBilgi.TCNO=tblOyuncuIletisimBilgileri.TCNO", vt.baglanti);
                komut.Parameters.AddWithValue("@parametre", tcno);
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                dr.Read();
                txt_Tcno.Text = tcno;
                txt_Ad.Text = dr["Ad"].ToString();

                txt_Soyad.Text = dr["Soyad"].ToString();
                txt_Meslek.Text = dr["Meslek"].ToString();
                txt_dogumyeri.Text = dr["DogumYeri"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dr["DogumTarihi"]);
                txt_cepno.Text = dr["CepTel"].ToString();
                txt_evno.Text = dr["EvTel"].ToString();
                txt_mail.Text = dr["Email"].ToString();
                txt_adres.Text = dr["Adres"].ToString();
                txt_face.Text = dr["Facebook"].ToString();
                txt_insta.Text = dr["Instagram"].ToString();
                txt_kilo.Text = dr["KILO"].ToString(); ;
                txt_website.Text = dr["Website"].ToString();
                txt_özgecmis.Text = dr["OZGECMIS"].ToString();
                txt_boy.Text = dr["BOY"].ToString();
                cmbox_gözrengi.Text = dr["GOZRENGI"].ToString();
                cmbox_sacrengi.Text = dr["SACRENGI"].ToString();
                cmbox_Cinsiyet.Text = dr["Cinsiyet"].ToString();
                Byte[] data = new Byte[0];
                data = (Byte[])(dr["Fotograf"]);
                MemoryStream mem = new MemoryStream(data);
                pictureEdit1.Image = Image.FromStream(mem);
                resimadres = data;

                vt.baglanti.Close();
            }
            catch (ArgumentNullException hata)
            {

                MessageBox.Show("Lütfen Bir Satır Seçin ve Ardından Tekrar Deneyin :)"+ hata);
            }
 
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            vt.baglanti.Open();
            GüncelleOB();
            GüncelleKB();
            GüncelleIB();
            vt.baglanti.Close();
            MessageBox.Show("Güncelleme Başarıyla Tamamlandı.");
        }
        void GüncelleOB()
        {
        
            try
            {
                FileStream fs;
                BinaryReader br;
                byte[] resim;
                
                

                
                string resimpath = pictureEdit1.GetLoadedImageLocation();
               
                if (string.IsNullOrEmpty(resimpath)==false)
                {
                     fs = new FileStream(resimpath, FileMode.Open, FileAccess.Read);
                     br = new BinaryReader(fs);
                     resim = br.ReadBytes((int)fs.Length);
                     br.Close();
                     fs.Close();
                }
                else
                {
                    resim = resimadres;
                }
               
               

                SqlCommand komutOB = new SqlCommand("Update  tblOyuncuBilgi set AD=@p2,SOYAD=@p3,MESLEK=@p4,Dogumtarihi=@p5,Dogumyeri=@p6,fotograf=@p7 where TCNO=@p1", vt.baglanti);
                komutOB.Parameters.AddWithValue("@p1", txt_Tcno.Text);

                komutOB.Parameters.AddWithValue("@p2", txt_Ad.Text);
    
                komutOB.Parameters.AddWithValue("@p3", txt_Soyad.Text);
                komutOB.Parameters.AddWithValue("@p4", txt_Meslek.Text);
                komutOB.Parameters.AddWithValue("@p5", dateTimePicker1.Value);


               komutOB.Parameters.AddWithValue("@p6", txt_dogumyeri.Text);
               komutOB.Parameters.Add("@p7", SqlDbType.Image, resim.Length).Value = resim;
               komutOB.ExecuteNonQuery();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Üzgünüm bir hata meydana geldi. "+ex);
                
            }

        }
       void GüncelleKB() {
            SqlCommand komutOB = new SqlCommand("Update tblOyuncuKisiselBilgiler set boy=@p2,KILO=@p3,GOZRENGI=@p4,SACRENGI=@p5,OZGECMIS=@p6,cinsiyet=@p7 where TCNO=@p1", vt.baglanti);
            komutOB.Parameters.AddWithValue("@p1", txt_Tcno.Text);
            komutOB.Parameters.AddWithValue("@p2", txt_boy.Text);
            komutOB.Parameters.AddWithValue("@p3", txt_kilo.Text);
            komutOB.Parameters.AddWithValue("@p4", cmbox_gözrengi.SelectedItem.ToString());
            komutOB.Parameters.AddWithValue("@p5", cmbox_sacrengi.SelectedItem.ToString());
            komutOB.Parameters.AddWithValue("@p6", txt_özgecmis.Text);
            komutOB.Parameters.AddWithValue("@p7", cmbox_Cinsiyet.SelectedItem.ToString());
            komutOB.ExecuteNonQuery();
        }
       void GüncelleIB() {
            SqlCommand komutOB = new SqlCommand("Update tblOyuncuIletisimBilgileri set Email=@p2,Facebook=@p3,Instagram=@p4,Website=@p5,CepTel=@p6,Evtel=@p7,Adres=@p8 where TCNO=@p1", vt.baglanti);
            komutOB.Parameters.AddWithValue("@p1", txt_Tcno.Text);
            komutOB.Parameters.AddWithValue("@p2", txt_mail.Text);
            komutOB.Parameters.AddWithValue("@p3", txt_face.Text);
            komutOB.Parameters.AddWithValue("@p4", txt_insta.Text);
            komutOB.Parameters.AddWithValue("@p5", txt_website.Text);
            komutOB.Parameters.AddWithValue("@p6", txt_cepno.Text);
            komutOB.Parameters.AddWithValue("@p7", txt_evno.Text);
            komutOB.Parameters.AddWithValue("@p8", txt_adres.Text);
            komutOB.ExecuteNonQuery();
        }
    }
}
