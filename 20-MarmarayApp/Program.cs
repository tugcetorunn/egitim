using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Text;

namespace _20_MarmarayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
            
        }

        private static void Menu()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: ");
            Console.WriteLine("1- Kişileri listele");
            Console.WriteLine("2- Kişi ekle");
            Console.WriteLine("3- Biniş İşlemi");
            Console.WriteLine("4- İniş İşlemi"); // iade buraya dahil edilecek.
            Console.WriteLine("5- Z Raporu");
            Console.WriteLine("6- Çıkış");
            Console.WriteLine("*******************************************");

            int gelenDeger = int.Parse(Console.ReadLine());

            switch (gelenDeger)
            {
                case 1:
                    KisiListele();
                    break;
                case 2:
                    KisiEkle();
                    break;
                case 3:
                    BinisIslemi();
                    break;
                case 4:
                    InisIslemi();
                    break;
                case 5:
                    ZRaporu();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Menü dışı seçim yaptınız.");
                    break;
            }

        }

        private static void ZRaporu()
        {
            string data = File.ReadAllText("YolcuKayitlari.json");
            List<YolcuBilgi> kayitlar = JsonConvert.DeserializeObject<List<YolcuBilgi>>(data);

            double toplam = 0;

            foreach (var item in kayitlar)
            {
                Console.WriteLine($"{item.Tarih} {item.KisiId} {item.AdSoyad} {durakListesi[item.BinisDurakId]} {durakListesi[item.InisDurakId]} {item.Ucret}");

                toplam += item.Ucret;
            }

            Console.WriteLine($"Toplam yolcu sayısı: {kayitlar.Count} Toplam ücret: {toplam}");
        }

        private static List<YolcuBilgi> JsonDosyadanVeriCekme()
        {
            string data = File.ReadAllText("YolcuKayitlari.json");
            List<YolcuBilgi> kayitlar = JsonConvert.DeserializeObject<List<YolcuBilgi>>(data);
            return kayitlar;
        }

        private static void InisIslemi()
        {
            // kişiyi seç
            KisiListele();
            int secilenKisi = int.Parse(Console.ReadLine());
            // durak seç // nerde inecek
            DurakListesi();
            int secilenDurak = int.Parse(Console.ReadLine());
            // iade alacak mı
            Console.WriteLine("İade almak istiyor musunuz? e/h");
            bool iadeEdilecekMi = Console.ReadLine().ToLower() == "e";

            double tutar = Hesapla(secilenKisi, secilenDurak, iadeEdilecekMi);
            // json ile dosyaya ekle
            DosyayaKaydet(secilenKisi, secilenDurak, tutar);
            // binenlerden sil
            binenlerListesi.Remove(secilenKisi);
            // todo: bakiye güncelleme
        }

        //static Dictionary<string, dynamic> yolcuBilgileri = new Dictionary<string, dynamic>();
        //string yolcuId = Guid.NewGuid().ToString();
        //yolcuBilgileri[yolcuId] = new {};

        private static void DosyayaKaydet(int secilenKisi, int secilenDurak, double tutar)
        {
            List<YolcuBilgi> yolcuBilgileri = JsonDosyadanVeriCekme();

            YolcuBilgi yolcuBilgi = new YolcuBilgi
            {
                Tarih = DateTime.Now,
                KisiId = secilenKisi,
                AdSoyad = kisiListesi[secilenKisi],
                BinisDurakId = binenlerListesi[secilenKisi],
                InisDurakId = secilenDurak,
                Ucret = tutar
            };

            yolcuBilgileri.Add(yolcuBilgi);

            string json = JsonConvert.SerializeObject(new
            {
                Tarih = DateTime.Now,
                KisiId = secilenKisi,
                AdSoyad = kisiListesi[secilenKisi],
                BinisDurakId = binenlerListesi[secilenKisi],
                InisDurakId = secilenDurak,
                Ucret = tutar
            }, Formatting.Indented);
            File.WriteAllText("YolcuKayitlari.json", json);

            //string json = JsonConvert.SerializeObject(new
            //{
            //    Tarih = DateTime.Now,
            //    KisiId = secilenKisi,
            //    AdSoyad = kisiListesi[secilenKisi],
            //    BinisDurakId = binenlerListesi[secilenKisi],
            //    InisDurakId = secilenDurak,
            //    Ucret = tutar
            //}, Formatting.Indented);
            //File.AppendAllText("YolcuKayitlari.json", json);
        }

        static List<double> tutarlar = new List<double> { 27, 34.72, 40.08, 46.22, 53.99, 59.76};
        private static double Hesapla(int kisiId, int inisDurakId, bool iadeEdilecekMi)
        {
            double tutar = tutarlar[tutarlar.Count - 1];

            if (iadeEdilecekMi)
            {
                binenlerListesi.TryGetValue(kisiId, out int binisDurakId); // binenlerListesi[secilenKisi] ile de alınır
                int durakSayisi = Math.Abs(binisDurakId - inisDurakId);

                if (durakSayisi < 8 && durakSayisi > 0)
                {
                    tutar = tutarlar[0];
                }
                else if (durakSayisi < 15 && durakSayisi > 7)
                {
                    tutar = tutarlar[1];
                }
                else if (durakSayisi < 22 && durakSayisi > 14)
                {
                    tutar = tutarlar[2];
                }
                else if (durakSayisi < 29 && durakSayisi > 21)
                {
                    tutar = tutarlar[3];
                }
                else if (durakSayisi < 36 && durakSayisi > 28)
                {
                    tutar = tutarlar[4];
                }
                else if (durakSayisi < 44 && durakSayisi > 35)
                {
                    tutar = tutarlar[5];
                }
            }
            
            return tutar;
        }

        // kisiId, durakId
        static Dictionary<int, int> binenlerListesi = new Dictionary<int, int>();
        static List<string> durakListesi = new List<string>{"Gebze", "Osmangazi", "Fatih", "Çayırova", "Tuzla", "İçmeler",
                "Aydıntepe", "Güzelyalı", "Tersane", "Kaynarca", "Pendik", "Yunus", "Kartal", "Başak", "Atalar", "Cevizli",
                "Maltepe", "Süreyya Plajı", "İdealtepe", "Küçükyalı", "Bostancı", "Suadiye", "Erenköy", "Göztepe",
                "Feneryolu", "Söğütlüçeşme", "Ayrılık Çeşmesi", "Üsküdar", "Sirkeci", "Yenikapı", "Kazlıçeşme",
                "Fişekhane", "Yenimahalle", "Bakırköy", "Ataköy", "Yeşilyurt", "Yeşilköy", "Florya Akvaryum",
                "Florya", "Küçükçekmece", "Mustafa Kemal", "Halkalı"};
        private static void BinisIslemi()
        {
            // kişileri listele
            KisiListele();
            // kişi seç (inmemiş kişiyi seçme)
            int secilenKisi = int.Parse(Console.ReadLine());
            bool kisiVarMi = binenlerListesi.ContainsKey(secilenKisi); // inince binenlerden silip kisilistesine tekrar eklenecek. ??
            // durak seç // nerde binecek
            DurakListesi();
            int secilenDurak = int.Parse(Console.ReadLine());
            // binenler listesine ekle
            if (!kisiVarMi)
            {
                binenlerListesi.Add(secilenKisi, secilenDurak);
            }
            // todo: bakiye kontrol

        }
        private static void DurakListesi()
        {
            Console.WriteLine("Durak Listesi");

            for (int i = 0; i < durakListesi.Count; i++)
            {
                Console.WriteLine($"{i+1} - {durakListesi[i]}");
            }
        }

        static Dictionary<int, string> kisiListesi = new Dictionary<int, string>(); // static olan kisilistele metodunda çalıştırmak için static yaptık.
        // listeyi global yaptık her yerden ulaşmamız gerekebilir.

        private static void KisiListele()
        {
            Console.WriteLine("Kişiler Listesi");
            foreach (var kisi in kisiListesi)
            {
                Console.WriteLine($"{kisi.Key}: {kisi.Value}");
            }
        }

        private static void KisiEkle()
        {
            Console.WriteLine("Eklemek istediğiniz kişinin Kart Id sini giriniz: ");
            int kartId = int.Parse(Console.ReadLine());
            Console.WriteLine("Eklemek istediğiniz kişinin adını soyadını giriniz: ");
            string adSoyad = Console.ReadLine();

            kisiListesi.Add(kartId, adSoyad);
            // todo: kişiyi kişiler listesi ismindeki json uzantılı dosyaya ekleyebilirsiniz.
        }
    }

    public class YolcuBilgi
    {
        public DateTime Tarih { get; set; }
        public int KisiId { get; set;}
        public string AdSoyad { get; set;}
        public int BinisDurakId { get; set;}
        public int InisDurakId { get; set;}
        public double Ucret { get; set;}
    }
}