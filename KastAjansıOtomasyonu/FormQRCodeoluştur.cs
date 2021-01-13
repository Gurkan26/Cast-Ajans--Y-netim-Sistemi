using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
namespace KastAjansıOtomasyonu
{
    public partial class FormQRCodeoluştur : Form
    {
        public FormQRCodeoluştur()
        {
            InitializeComponent();
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            sfd.Title = "Kayıt";
            sfd.FileName = "Qr-Code";
            DialogResult sonuç = sfd.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName);//Böylelikle resmi istediğimiz yere kaydediyoruz.
            }
            MessageBox.Show("Qr Code Başarıyla Kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
   



      void qrkodolustur()
      {
        string qryap = OyuncuIslemForm.QrVeriTutucu;
        QRCodeEncoder encod = new QRCodeEncoder();
        pictureBox1.Image = encod.Encode(qryap);
      }

       private void FormQRCodeoluştur_Load(object sender, EventArgs e)
           {
             qrkodolustur();
           }

   
    
    
    }






}