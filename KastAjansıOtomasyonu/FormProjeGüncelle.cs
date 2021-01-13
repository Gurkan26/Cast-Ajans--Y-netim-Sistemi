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
    public partial class FormProjeGüncelle : Form
    {
        Database vt = new Database();
   
        public FormProjeGüncelle()
        {
            InitializeComponent();
        }
       
        private void FormProjeGüncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'castAjansVeriTabaniDataSet4.tblOyuncuBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblOyuncuBilgiTableAdapter.Fill(this.castAjansVeriTabaniDataSet4.tblOyuncuBilgi);
            string gelen = FormProjeListesi.Veritutucu;
            int cvr = Convert.ToInt32(gelen);
            Listele(cvr);
          
        }

        void Listele(int projeno)
        {

          

            vt.baglanti.Open();
            SqlCommand komut = new SqlCommand(" Select * from tblProjeBilgi where ProjeNo=@parametre", vt.baglanti);
            komut.Parameters.AddWithValue("@parametre", projeno);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            txtprojeisim.Text = dr["ProjeAdı"].ToString();
            
            lookUpEdit1.Text = dr["Başrol Erkek"].ToString();
            lookUpEdit2.Text = dr["Başrol Kadın"].ToString();
            cmbboxtip.Text = dr["ProjeTipi"].ToString();
            cmbbox_kategori.Text = dr["ProjeKategorisi"].ToString();
            txtyazar.Text = dr["Yazar"].ToString();
            txtyonetmen.Text = dr["yönetmen"].ToString();
            txtyapimci.Text = dr["yapımcı"].ToString();
            txtmaliyet.Text = dr["maliyet"].ToString();
            txtülke.Text = dr["ülke"].ToString();
            txt_konu.Text = dr["ProjeKonusu"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dr["BaşlangıçTarihi"]);
            dateTimePicker2.Value = Convert.ToDateTime(dr["BitişTarihi"]);
                
                
               
                vt.baglanti.Close();
            }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string gelen = FormProjeListesi.Veritutucu;
            int cvr = Convert.ToInt32(gelen);
            Güncelle(cvr);
        }
        void Güncelle(int projeno)
        {
            
            vt.baglanti.Open();
            try
            {
                MessageBox.Show(projeno.ToString());
                SqlCommand komutOB = new SqlCommand("update tblProjeBilgi set ülke=@p14,projeadı=@p1,[Başrol Erkek]=@p2,[Başrol Kadın]=@p3,projetipi=@p4,projekategorisi=@p5,yazar=@p6,yönetmen=@p7,yapımcı=@p8,maliyet=@p9,başlangıçtarihi=@p10,bitiştarihi=@p11,projekonusu=@p12 where Projeno=@parametre", vt.baglanti);
                komutOB.Parameters.AddWithValue("@parametre",projeno);
                komutOB.Parameters.AddWithValue("@p1", txtprojeisim.Text);
                komutOB.Parameters.AddWithValue("@p2", lookUpEdit1.Text);
                komutOB.Parameters.AddWithValue("@p3", lookUpEdit2.Text);
                komutOB.Parameters.AddWithValue("@p4", cmbboxtip.SelectedItem);
                komutOB.Parameters.AddWithValue("@p5", cmbbox_kategori.SelectedItem);
                komutOB.Parameters.AddWithValue("@p6", txtyazar.Text);
                komutOB.Parameters.AddWithValue("@p7", txtyonetmen.Text);
                komutOB.Parameters.AddWithValue("@p8", txtyapimci.Text);
                komutOB.Parameters.AddWithValue("@p9", txtmaliyet.Text);
                komutOB.Parameters.AddWithValue("@p10", dateTimePicker1.Value);
                komutOB.Parameters.AddWithValue("@p11", dateTimePicker2.Value);
                komutOB.Parameters.AddWithValue("@p12", txt_konu.Text);
                komutOB.Parameters.AddWithValue("@p14",txtülke.Text);
            
                komutOB.ExecuteNonQuery();
                MessageBox.Show("Güncelleme Başarıyla Tamamlandı.");
            }
            catch (ArgumentException a)
            {
                MessageBox.Show("Hata, Lütfen Girilen Resmin Boyutunu Küçültün."+a);

            }
            finally
            {
                vt.baglanti.Close();
            }


        }
    }
}
