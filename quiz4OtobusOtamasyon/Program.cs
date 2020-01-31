using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otobusOtomasyon
{
    class Program
    {
        static Otobus[] otobus = new Otobus[34];
        static int koltuk=0;
       
        static void Main(string[] args)
        {
            do
            {
           menu:Console.Write("Çıkmak için >> 1\nDevam İçin >> 2\nBoş Koltuk Listesi İçin >> 3\nBütün Yolcu Listesi İçin >> 4\nYolcu Silme >> 5\n>>");
                string bak = Console.ReadLine();
                switch (bak)
                {
                    case "1": Environment.Exit(0); break;
                    case "2": YolcuKayit(); break;
                    case "3": BosKoltukListesi(); break;
                    case "4": YolcuListesi(); break;
                    case "5": YolcuSil(); break;
                    default: Console.Clear(); goto menu;
                }
            } while (true);
        }

        private static void YolcuSil()
        {
            Console.Clear();
            Console.Write("Silmek İstediğiniz Yolcunun Koltuk Numarası:");
            int no = int.Parse(Console.ReadLine());
            if ( otobus[no-1] != null)
            {
                otobus[no - 1] = null;
                Console.WriteLine("Seçilen Koltuk Siliniyor...");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                return;
            }
            else
            {
                Console.WriteLine("Seçilen Koltuk Zaten BOŞ !");
                System.Threading.Thread.Sleep(1000);
            }
          
            Console.Clear();
        }

        private static void YolcuListesi()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("{0,10} Koltuk No {1,5} Yolcu Adı {2,5} Koltuk No {3,5} Yolcu Adı", "", "", "", "");
            Console.WriteLine("{0,10} --------- {1,5} --------- {2,5} --------- {1,5} ---------", "", "", "", "");
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < otobus.Length; i++)
            {
                if (otobus[i]!=null)
                {
                    if (i < 9)
                    {

                        if ((i + 1) % 2 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" {0,12}" + (i + 1) + ". {1,10}"+ otobus[i].ad, "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" {0,10}" + (i + 1) + ". {1,10}"+ otobus[i].ad, "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        if ((i + 1) % 2 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("{0,12}" + (i + 1) + ". {1,10}" + otobus[i].ad, "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("{0,10}" + (i + 1) + ". {1,10}" + otobus[i].ad, "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                        }
                    }

                }
                else
                {
                    if (i < 9)
                    {

                        if ((i + 1) % 2 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" {0,12}" + (i + 1) + ". {1,10} BOŞ", "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" {0,10}" + (i + 1) + ". {1,10} BOŞ", "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        if ((i + 1) % 2 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("{0,12}" + (i + 1) + ". {1,10} BOŞ", "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("{0,10}" + (i + 1) + ". {1,10} BOŞ", "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                        }
                    }

                }

            }
        }

        private static void BosKoltukListesi()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("{0,10} Koltuk No {1,5} Yolcu {2,5} Koltuk No {3,5} Yolcu","","","","");
            Console.WriteLine("{0,10} --------- {1,5} ----- {2,5} --------- {1,5} -----", "", "", "", "");
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < otobus.Length; i++)
            {
                if (otobus[i] != null)
                {
                    if (i <9)
                    {

                        if ((i+1) % 2 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" {0,12}" + (i + 1) + ". {1,10} DOLU", "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" {0,10}" + (i + 1) + ". {1,10} DOLU", "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                        } 
                    }
                    else
                    {
                        if ((i + 1) % 2 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("{0,12}" + (i + 1) + ". {1,10} DOLU", "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("{0,10}" + (i + 1) + ". {1,10} DOLU", "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                        } 
                    }
                 
                }
                else
                {
                    if (i<9)
                    {

                        if ((i + 1) % 2 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" {0,12}" + (i + 1) + ". {1,10} BOŞ", "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" {0,10}" + (i + 1) + ". {1,10} BOŞ", "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                        } 
                    }
                    else
                    {
                        if ((i + 1)  % 2 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("{0,12}" + (i + 1) + ". {1,10} BOŞ", "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("{0,10}" + (i + 1) + ". {1,10} BOŞ", "", "");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                        } 
                    }
                
                }
               
            }
        }
       static int kayitSayisi = 0;
        private static void YolcuKayit()
        {
            Console.Clear();
            Console.WriteLine("---->Devam Ediliyor");
            Console.Write("Adı Giriniz:");
            string ad = Console.ReadLine();
            Console.Write("Soyad Giriniz:");
            string soyAd = Console.ReadLine();
     koltuk:Console.Write("Koltuğu Giriniz (1-34):");
            koltuk = int.Parse(Console.ReadLine());
            if (koltuk >=1 && koltuk <=34)
            {
               if (KoltukKontrol(koltuk - 1)==false)
	            {
		             otobus[koltuk - 1] = new Otobus(ad, soyAd);
                     kayitSayisi++;
	            }
               else
               {
                   
                   BosKoltukListesi();
                   Console.WriteLine("Seçtiğiniz Koltuk Dolu !");
                   goto koltuk;
               }
               
            }
            else
            {
                Console.WriteLine("Koltuk Sayısını 1 ile 34 arasında olmalı");
                goto koltuk;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(otobus[koltuk - 1].ad + " " + otobus[koltuk - 1].soyad+"Kişiye '"+koltuk+"' Numaralı Koltuk Tahsis Edilmiştir...");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Menü Aktarılıyor...");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();

        }
        
        private static bool KoltukKontrol(int p)
        {
            if (otobus[p]!=null)
            {
                return true;
            }
            return false;
        }
    }
}
