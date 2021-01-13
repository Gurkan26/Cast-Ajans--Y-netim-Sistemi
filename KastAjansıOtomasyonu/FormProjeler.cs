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
    public partial class FormProjeler : Form
    { Database vt = new Database();
        public FormProjeler()
        {
            InitializeComponent();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Ekle();
        }
        void Ekle()
        {
           
          
            vt.baglanti.Open();
            try
            {
                SqlCommand komutOB = new SqlCommand("insert into tblProjeBilgi (projeadı,ülke,[Başrol Erkek],[Başrol Kadın],projetipi,projekategorisi,yazar,yönetmen,yapımcı,maliyet,başlangıçtarihi,bitiştarihi,projekonusu) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)", vt.baglanti);
                komutOB.Parameters.AddWithValue("@p1", txtprojeisim.Text);
                komutOB.Parameters.AddWithValue("@p3", lookUpEdit1.Text);
                komutOB.Parameters.AddWithValue("@p4", lookUpEdit2.Text);
                komutOB.Parameters.AddWithValue("@p5", cmbboxtip.SelectedItem);
                komutOB.Parameters.AddWithValue("@p6", cmbbox_kategori.SelectedItem);
                komutOB.Parameters.AddWithValue("@p7", txtyazar.Text);
                komutOB.Parameters.AddWithValue("@p8", txtyonetmen.Text);
                komutOB.Parameters.AddWithValue("@p9", txtyapimci.Text);
                komutOB.Parameters.AddWithValue("@p10", txtmaliyet.Text);
                komutOB.Parameters.AddWithValue("@p11", dateTimePicker1.Value);
                komutOB.Parameters.AddWithValue("@p12", dateTimePicker2.Value);
                komutOB.Parameters.AddWithValue("@p13", txt_konu.Text);
                komutOB.Parameters.AddWithValue("@p2",txtülke.Text);

                komutOB.ExecuteNonQuery();
                MessageBox.Show("Proje Başarıyla Eklendi.");

            }
            catch (ArgumentNullException a)
            {
                MessageBox.Show("Hata"+a);
                
            }
            finally
            {
                vt.baglanti.Close();
            }
        }
       
            

        private void FormProjeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'castAjansVeriTabaniDataSet4.tblOyuncuBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblOyuncuBilgiTableAdapter.Fill(this.castAjansVeriTabaniDataSet4.tblOyuncuBilgi);
         
        }

       
    }
}
