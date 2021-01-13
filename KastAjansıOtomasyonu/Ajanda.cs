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
    public partial class Ajanda : Form
    {
        public Ajanda()
        {
            InitializeComponent();
        }

        private void calendarControl1_Click(object sender, EventArgs e)
        {

        }

        private void Ajanda_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'castAjansVeriTabaniDataSet.Resources' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.resourcesTableAdapter.Fill(this.castAjansVeriTabaniDataSet.Resources);
            // TODO: Bu kod satırı 'castAjansVeriTabaniDataSet.Appointments' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.appointmentsTableAdapter.Fill(this.castAjansVeriTabaniDataSet.Appointments);
            
        }

        private void schedulerControl1_Click(object sender, EventArgs e)
        {

        }

        private void schedulerDataStorage1_AppointmentsChanged(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(castAjansVeriTabaniDataSet);  // Burada verilerde güncelleme olduğu zaman değişimi veritabanına da yansıtıyoruz
            castAjansVeriTabaniDataSet.AcceptChanges();
        }

        private void printPreviewItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void newRecurringAppointmentItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
