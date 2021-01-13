using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace KastAjansıOtomasyonu
{
    public partial class FormHakkımda : Form
    {
        public FormHakkımda()
        {
            InitializeComponent();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {

        }

        private void FormHakkımda_Load(object sender, EventArgs e)
        {
            müzikcal();

        }

        private void FormHakkımda_FormClosing(object sender, FormClosingEventArgs e)
        {
           müzikdur();
        }
        void müzikcal() {
            SoundPlayer ses = new SoundPlayer();
            //string dizin = Application.StartupPath + @"ses\müzik.wav";
            ses.SoundLocation = @"ses\müzik.wav";
            ses.Play();
            

        }
        void müzikdur() {
            SoundPlayer ses = new SoundPlayer();
           // string dizin = Application.StartupPath + @"ses\müzik.wav";
            ses.SoundLocation = @"ses\müzik.wav";
            ses.Stop();
        }
    }
}
