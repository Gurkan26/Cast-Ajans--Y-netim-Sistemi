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
    public partial class FormProjeListesi : Form
    {
        public static string Veritutucu { get; set; }
        public FormProjeListesi()
        {
            InitializeComponent();
        }
        Database vt = new Database();

        private void FormProjeListesi_Load(object sender, EventArgs e)
        {

            Listele();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProjeler frmp = new FormProjeler();
            frmp.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
           
                if (XtraMessageBox.Show(dr[0].ToString() + " no'lu projeyi silmek istediğine emin misin? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dr[0].ToString() != null)
                    {
                        vt.baglanti.Open();
                        SqlCommand komutsil = new SqlCommand("Delete from tblProjeBilgi where ProjeNo=@p1", vt.baglanti);
                        try
                        {

                            komutsil.Parameters.AddWithValue("@p1", dr[0].ToString());
                            komutsil.ExecuteNonQuery();
                            MessageBox.Show("Silme işlemi başarılı.");
                            Listele();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Beklenmedik bir hata meydana geldi. Lütfen işlemlerinizi kontrol edip tekrar deneyin.");
                        }
                        finally { vt.baglanti.Close(); }
                    }

                }

            
         

        }
        void Listele() {
            string sorgu = "Select * from tblProjeBilgi";
            vt.baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sorgu, vt.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            vt.baglanti.Close();

        }

       

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProjeGüncelle fpg = new FormProjeGüncelle();
            fpg.Show();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            Veritutucu = dr[0].ToString();
        }

        private void listeyiYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
