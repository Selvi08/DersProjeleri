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
    public partial class BiletEkrani : Form {
        BiletSatis biletSatis = null;
        public BiletEkrani(BiletSatis biletSatis) {
            InitializeComponent();
            this.biletSatis = biletSatis;
            Random random = new Random();
            lblReferansNo.Text = random.Next().ToString();
            lblNereden.Text = ((Durak)biletSatis.cmbNereden.SelectedItem).durakAdi;
            lblNereye.Text = ((Durak)biletSatis.cmbNereye.SelectedItem).durakAdi;
            lblSecilenBiletSayisi.Text = ((int)(biletSatis.cmbBiletAdet.SelectedItem)).ToString();
            GetComboBoxInformation();
        }

        public void GetComboBoxInformation() {

            int durak1 = (int)biletSatis.cmbNereye.SelectedValue;
            int durak2 = (int)biletSatis.cmbNereden.SelectedValue;
            int durakFark = 0;
            if ( durak2 - durak1 != 0 ) {

                durakFark = durak2 - durak1;
                decimal durakFark2 = Decimal.Parse(durakFark.ToString().Replace( "-", "" ).Trim());
                
                if ( durakFark2 <= 5  ) {

                    lblUcret.Text = 3 + " " + "TL";
                }
                else if ( 5 < durakFark2 && durakFark2 <= 10 ) {
                    lblUcret.Text = 3.25 + " " + "TL" ;
                }
                else if ( durakFark2 < 10 && durakFark2 <= 15 ) {
                    lblUcret.Text = 3.50 + " " + "TL";
                }
                else if ( durakFark2 < 15 && durakFark2 <= 20 ) {
                    lblUcret.Text = 3.70 + " " + "TL";
                }
                else if ( durakFark2 < 20 && durakFark2 <= 25 ) {
                    lblUcret.Text = 3.75 + " " + "TL";
                }
                else if ( durakFark2 < 25 && durakFark2 <= 30 ) {
                    lblUcret.Text = 4 + " " + "TL";
                }
                else if ( durakFark2 < 30 && durakFark2 <= 35 ) {
                    lblUcret.Text = 4.25 + " " + "TL";
                }
                else if ( durakFark2 < 35 && durakFark2 <= 40 ) {
                    lblUcret.Text = 4.50 + " " + "TL";
                }
                else {
                    lblUcret.Text = 4.75 + " " + "TL";
                }
                decimal ucret = Decimal.Parse( lblUcret.Text.Replace( "TL", "" ));
                decimal biletSayisi = Decimal.Parse( lblSecilenBiletSayisi.Text );
                decimal toplamUcret = ucret * biletSayisi;
                lblToplamUcret.Text = toplamUcret.ToString() + " " + "TL";

            }

        }

        private void btnKapat_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
