using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Snap;
using DevExpress.Snap.Core.API;
using DevExpress.XtraPrinting;

namespace KastAjansıOtomasyonu
{
    public partial class FormNotlar : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormNotlar()
        {
            InitializeComponent();
        }
       
      
        private void fileSaveItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void FormNotlar_Load(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            snapControl1.ExportToPdf(@"C:\Users\gurka\OneDrive\Masaüstü\belge.pdf");
            MessageBox.Show("PDF başarıyla oluşturuldu. Lütfen Masaüstünü kontrol edin."+"Bilgilendirme"+MessageBoxButtons.OK);
        }
    }
}

