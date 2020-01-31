using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletSistemi {
    public partial class AnaEkran : Form {
        public AnaEkran() {
            InitializeComponent();
            lblTarih.Text = DateTime.Now.ToShortDateString();
            lblSaat.Text = DateTime.Now.ToShortTimeString();
        }

        public void btnBiletSatis_Click(object sender, EventArgs e) {

            using ( var biletSatis = new BiletSatis() ) {
                
                biletSatis.ShowDialog();
            }
        }

        public void btnKapat_Click(object sender, EventArgs e) {
            this.Close();
        }
        public void btnBiletIade_Click(object sender, EventArgs e) {
            MessageBox.Show( " İade Sisteminde Bulunan Teknik Bir Hatadan Dolayı İşlem Gerçekleştiremiyoruz. " );
        }
    }
}
