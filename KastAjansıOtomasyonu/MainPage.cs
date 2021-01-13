using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KastAjansıOtomasyonu
{
    public partial class MainPage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainPage()
        {
            InitializeComponent();
        }
        OyuncuIslemForm oif1;
        FormResimliListe frmlist;
        Ajanda ajanda;
        FormNotlar frmnot;
        FormProjeListesi projelist;
        FormHakkımda hakkımda;
        FormKullaniciIslemleri fki;
        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

      

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (oif1 == null || oif1.IsDisposed)
            { //Eğer oif formu açılmamışsa veya sekmesi açılıp kapanmışsa
                oif1 = new OyuncuIslemForm(); // oif1 adında yeni bir nesne türet;
                oif1.MdiParent = this; // ve türettiğin nesneyi bulunduğumuz ekrana getir.
                oif1.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ajanda == null || ajanda.IsDisposed)
             {
                ajanda = new Ajanda(); ajanda.MdiParent = this;
                ajanda.MdiParent = this;
                ajanda.Show();
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormResimliListe frm = new FormResimliListe();
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmlist == null || frmlist.IsDisposed)
            { 
                frmlist = new FormResimliListe(); 
                frmlist.MdiParent = this; 
                frmlist.Show();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmnot == null || frmnot.IsDisposed)
            {
                frmnot = new FormNotlar();
                frmnot.MdiParent = this;
                frmnot.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (projelist == null || projelist.IsDisposed)
            {
                projelist = new FormProjeListesi();
                projelist.MdiParent = this;
                projelist.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hakkımda == null || hakkımda.IsDisposed)
            {
                hakkımda = new FormHakkımda();
                hakkımda.MdiParent = this;
                hakkımda.Show();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fki == null || fki.IsDisposed)
            {
                fki = new FormKullaniciIslemleri();
                fki.Show();


            }
    
        
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
