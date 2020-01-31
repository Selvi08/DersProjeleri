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
    public partial class BiletSatis : Form {
        public BiletSatis() {
            InitializeComponent();
            GetComboBoxValue();
        }

        //Bilet Oluşturma Butonu
        public void btnBiletYarat_Click(object sender, EventArgs e) {
            using ( BiletEkrani biletEkrani = new BiletEkrani( this ) ) {
                biletEkrani.ShowDialog();
            }
        }
        Durak[] duraks = new Durak[]
        {
            new Durak() { durakAdi = "Beylikdüzü Son Durak /  TÜYAP          " , durakSirasi = 1  },
            new Durak() { durakAdi = "Hadımköy                               " , durakSirasi = 2  },
            new Durak() { durakAdi = "Cumhuriyet Mahallesi                   " , durakSirasi = 3  },
            new Durak() { durakAdi = "Beylikdüzü Belediyesi                  " , durakSirasi = 4  },
            new Durak() { durakAdi = "Beylikdüzü                             " , durakSirasi = 5  },
            new Durak() { durakAdi = "Güzelyurt                              " , durakSirasi = 6  },
            new Durak() { durakAdi = "Haramidere                             " , durakSirasi = 7  },
            new Durak() { durakAdi = "Haramidere Sanayi                      " , durakSirasi = 8  },
            new Durak() { durakAdi = "Saadetdere Mahallesi                   " , durakSirasi = 9  },
            new Durak() { durakAdi = "Mustafa Kemal Paşa                     " , durakSirasi = 10 },
            new Durak() { durakAdi = "Cihangir Üniversite Mahallesi          " , durakSirasi = 11 },
            new Durak() { durakAdi = "Avcılar Merkez Üniversite Kampüsü      " , durakSirasi = 12 },
            new Durak() { durakAdi = "Şükrübey                               " , durakSirasi = 13 },
            new Durak() { durakAdi = "Büyükşehir Belediyesi  Sosyal Tesisleri" , durakSirasi = 14 },
            new Durak() { durakAdi = "Küçükçekmece                           " , durakSirasi = 15 },
            new Durak() { durakAdi = "Cennet Mahallesi                       " , durakSirasi = 16 },
            new Durak() { durakAdi = "Florya                                 " , durakSirasi = 17 },
            new Durak() { durakAdi = "Beşyol                                 " , durakSirasi = 18 },
            new Durak() { durakAdi = "Sefaköy                                " , durakSirasi = 19 },
            new Durak() { durakAdi = "Yenibosna                              " , durakSirasi = 20 },
            new Durak() { durakAdi = "Şirinevler (Ataköy)                    " , durakSirasi = 21 },
            new Durak() { durakAdi = "Bahçelievler                           " , durakSirasi = 22 },
            new Durak() { durakAdi = "İncirli (Ömür)                         " , durakSirasi = 23 },
            new Durak() { durakAdi = "Zeytinburnu                            " , durakSirasi = 24 },
            new Durak() { durakAdi = " Merter                                " , durakSirasi = 25 },
            new Durak() { durakAdi = " Cevizlibağ                            " , durakSirasi = 26 },
            new Durak() { durakAdi = " Topkapı                               " , durakSirasi = 27 },
            new Durak() { durakAdi = " Bayrampaşa – Maltepe                  " , durakSirasi = 28 },
            new Durak() { durakAdi = " Edirnekapı                            " , durakSirasi = 29 },
            new Durak() { durakAdi = " Ayvansaray – Eyüp Sultan              " , durakSirasi = 30 },
            new Durak() { durakAdi = " Halıcıoğlu                            " , durakSirasi = 31 },
            new Durak() { durakAdi = " Okmeydanı                             " , durakSirasi = 32 },
            new Durak() { durakAdi = " Darülaceze – Perpa                    " , durakSirasi = 33 },
            new Durak() { durakAdi = " Okmeydanı Hastane                     " , durakSirasi = 34 },
            new Durak() { durakAdi = " Çağlayan                              " , durakSirasi = 35 },
            new Durak() { durakAdi = " Mecidiyeköy                           " , durakSirasi = 36 },
            new Durak() { durakAdi = " Zincirlikuyu                          " , durakSirasi = 37 },
            new Durak() { durakAdi = " 15 Temmuz Şehitler Köprüsü            " , durakSirasi = 38 },
            new Durak() { durakAdi = " Burhaniye                             " , durakSirasi = 39 },
            new Durak() { durakAdi = " Altunizade                            " , durakSirasi = 40 },
            new Durak() { durakAdi = " Acıbadem                              " , durakSirasi = 41 },
            new Durak() { durakAdi = " Uzunçayır                             " , durakSirasi = 42 },
            new Durak() { durakAdi = " Fikirtepe                             " , durakSirasi = 43 },
            new Durak() { durakAdi = " Söğütlüçeşme                          " , durakSirasi = 44 }
        };

        Durak[] duraks2 = new Durak[] {
            new Durak() { durakAdi = "Beylikdüzü Son Durak /  TÜYAP          " , durakSirasi = 1  },
            new Durak() { durakAdi = "Hadımköy                               " , durakSirasi = 2  },
            new Durak() { durakAdi = "Cumhuriyet Mahallesi                   " , durakSirasi = 3  },
            new Durak() { durakAdi = "Beylikdüzü Belediyesi                  " , durakSirasi = 4  },
            new Durak() { durakAdi = "Beylikdüzü                             " , durakSirasi = 5  },
            new Durak() { durakAdi = "Güzelyurt                              " , durakSirasi = 6  },
            new Durak() { durakAdi = "Haramidere                             " , durakSirasi = 7  },
            new Durak() { durakAdi = "Haramidere Sanayi                      " , durakSirasi = 8  },
            new Durak() { durakAdi = "Saadetdere Mahallesi                   " , durakSirasi = 9  },
            new Durak() { durakAdi = "Mustafa Kemal Paşa                     " , durakSirasi = 10 },
            new Durak() { durakAdi = "Cihangir Üniversite Mahallesi          " , durakSirasi = 11 },
            new Durak() { durakAdi = "Avcılar Merkez Üniversite Kampüsü      " , durakSirasi = 12 },
            new Durak() { durakAdi = "Şükrübey                               " , durakSirasi = 13 },
            new Durak() { durakAdi = "Büyükşehir Belediyesi  Sosyal Tesisleri" , durakSirasi = 14 },
            new Durak() { durakAdi = "Küçükçekmece                           " , durakSirasi = 15 },
            new Durak() { durakAdi = "Cennet Mahallesi                       " , durakSirasi = 16 },
            new Durak() { durakAdi = "Florya                                 " , durakSirasi = 17 },
            new Durak() { durakAdi = "Beşyol                                 " , durakSirasi = 18 },
            new Durak() { durakAdi = "Sefaköy                                " , durakSirasi = 19 },
            new Durak() { durakAdi = "Yenibosna                              " , durakSirasi = 20 },
            new Durak() { durakAdi = "Şirinevler (Ataköy)                    " , durakSirasi = 21 },
            new Durak() { durakAdi = "Bahçelievler                           " , durakSirasi = 22 },
            new Durak() { durakAdi = "İncirli (Ömür)                         " , durakSirasi = 23 },
            new Durak() { durakAdi = "Zeytinburnu                            " , durakSirasi = 24 },
            new Durak() { durakAdi = " Merter                                " , durakSirasi = 25 },
            new Durak() { durakAdi = " Cevizlibağ                            " , durakSirasi = 26 },
            new Durak() { durakAdi = " Topkapı                               " , durakSirasi = 27 },
            new Durak() { durakAdi = " Bayrampaşa – Maltepe                  " , durakSirasi = 28 },
            new Durak() { durakAdi = " Edirnekapı                            " , durakSirasi = 29 },
            new Durak() { durakAdi = " Ayvansaray – Eyüp Sultan              " , durakSirasi = 30 },
            new Durak() { durakAdi = " Halıcıoğlu                            " , durakSirasi = 31 },
            new Durak() { durakAdi = " Okmeydanı                             " , durakSirasi = 32 },
            new Durak() { durakAdi = " Darülaceze – Perpa                    " , durakSirasi = 33 },
            new Durak() { durakAdi = " Okmeydanı Hastane                     " , durakSirasi = 34 },
            new Durak() { durakAdi = " Çağlayan                              " , durakSirasi = 35 },
            new Durak() { durakAdi = " Mecidiyeköy                           " , durakSirasi = 36 },
            new Durak() { durakAdi = " Zincirlikuyu                          " , durakSirasi = 37 },
            new Durak() { durakAdi = " 15 Temmuz Şehitler Köprüsü            " , durakSirasi = 38 },
            new Durak() { durakAdi = " Burhaniye                             " , durakSirasi = 39 },
            new Durak() { durakAdi = " Altunizade                            " , durakSirasi = 40 },
            new Durak() { durakAdi = " Acıbadem                              " , durakSirasi = 41 },
            new Durak() { durakAdi = " Uzunçayır                             " , durakSirasi = 42 },
            new Durak() { durakAdi = " Fikirtepe                             " , durakSirasi = 43 },
            new Durak() { durakAdi = " Söğütlüçeşme                          " , durakSirasi = 44 }
        };
        //Durakların Getirilmesi
        public void GetComboBoxValue() {
            cmbNereden.DataSource = duraks;
            cmbNereden.ValueMember = "durakSirasi";
            cmbNereden.DisplayMember = "durakAdi";

            cmbNereye.DataSource = duraks2;
            cmbNereye.ValueMember = "durakSirasi";
            cmbNereye.DisplayMember = "durakAdi";

            for ( int i = 1; i < 20; i++ ) {
                cmbBiletAdet.Items.Add( i );
            }
        }
        private void btnKapat_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
