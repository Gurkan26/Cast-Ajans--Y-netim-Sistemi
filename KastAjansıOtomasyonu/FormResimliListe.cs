using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KastAjansıOtomasyonu
{
    public partial class FormResimliListe : DevExpress.XtraEditors.XtraForm
    {
        public FormResimliListe()
        {
            InitializeComponent();
        }

        private void FormResimliListe_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'castAjansVeriTabaniDataSet3.tblOyuncuBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblOyuncuBilgiTableAdapter2.Fill(this.castAjansVeriTabaniDataSet3.tblOyuncuBilgi);


        }
    }
}