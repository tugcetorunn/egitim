using System.Text.Json;

namespace MarmarayOdeme
{
    class Program
    {
        static void Main(string[] args)
        {
            int kisiNo, gunlukYolcu = 0;
            double gunlukKazanc = 0;
            double bakiye = 100;
            double kayitBakiye;
            string kisiIsim, kayitAdSoyad;

            List<string> duraklar = new List<string>{"Gebze", "Osmangazi", "Fatih", "Çayırova", "Tuzla", "İçmeler",
                "Aydıntepe", "Güzelyalı", "Tersane", "Kaynarca", "Pendik", "Yunus", "Kartal", "Başak", "Atalar", "Cevizli",
                "Maltepe", "Süreyya Plajı", "İdealtepe", "Küçükyalı", "Bostancı", "Suadiye", "Erenköy", "Göztepe",
                "Feneryolu", "Söğütlüçeşme", "Ayrılık Çeşmesi", "Üsküdar", "Sirkeci", "Yenikapı", "Kazlıçeşme",
                "Fişekhane", "Yenimahalle", "Bakırköy", "Ataköy", "Yeşilyurt", "Yeşilköy", "Florya Akvaryum",
                "Florya", "Küçükçekmece", "Mustafa Kemal", "Halkalı" };

            //Dictionary<int, string> dicDuraklar = duraklar.ToDictionary();
            Dictionary<int, string> kisiler = new Dictionary<int, string>();
            kisiler.Add(1, "ahmet");
            kisiler.Add(2, "mehmet");
            kisiler.Add(3, "ali");
            kisiler.Add(4, "veli");
            kisiler.Add(5, "burak");

            Dictionary<int, double> bakiyeler = new Dictionary<int, double>();
            bakiyeler.Add(1, bakiye);
            bakiyeler.Add(2, bakiye);
            bakiyeler.Add(3, bakiye);
            bakiyeler.Add(4, bakiye);
            bakiyeler.Add(5, bakiye);

            DateTime bugun = DateTime.Now;
            Console.WriteLine(bugun);

            Console.WriteLine("1- Giriş \n 2- Kayıt ol");
            string girisSecim = Console.ReadLine();

            switch (girisSecim)
            {
                case "1":
                    Console.WriteLine("Numaranızı giriniz: ");
                    kisiNo = int.Parse(Console.ReadLine());
                    kisiIsim = kisiler[kisiNo];
                    Console.WriteLine("Merhaba " + kisiIsim);
                    break;
                case "2":
                    Console.WriteLine("Adınız soyadınız: ");
                    kayitAdSoyad = Console.ReadLine();
                    kisiler.Add((kisiler.Keys.Count + 1), kayitAdSoyad);
                    Console.WriteLine("Kayıt oldunuz " + kayitAdSoyad);
                    Console.WriteLine("Bakiyenizi giriniz: ");
                    kayitBakiye = Convert.ToDouble(Console.ReadLine());
                    bakiyeler.Add((bakiyeler.Keys.Count + 1), kayitBakiye);
                    break;
                default:
                    Console.WriteLine("Geçerli seçim yapınız...");
                    break;
            }

            Console.WriteLine("1- Nereden bindiniz?");
            for (int i = 0; i < duraklar.Count; i++)
            {
                Console.WriteLine($"{i + 1}. durak: {duraklar[i]}");
            }

            int binilenDurak = int.Parse(Console.ReadLine());

            Console.WriteLine("2- Nerede ineceksiniz?");

            int inilecekDurak = int.Parse(Console.ReadLine());

            int mesafe = inilecekDurak - binilenDurak;

            double tutar = DuraklarArasiTutarHesaplama(mesafe);
            Console.WriteLine($"Mesafe: {mesafe} durak \n Tutar: {tutar} tl");

            bakiyeler[kisiNo] = bakiyeler[kisiNo] - tutar;

            Console.WriteLine("İade alacak mısınız? e/h");

            string iadeSecim = Console.ReadLine();
            double iade = 0;

            if (iadeSecim == "e")
            {
                iade = IadeHesaplama(mesafe);
                bakiyeler[kisiNo] = bakiyeler[kisiNo] + iade;
            }
            else
            {
                Console.WriteLine("İade istemediniz.");
            }

            var marmarayInfo = new MarmarayInfo();

            marmarayInfo.Bugun = bugun;
            marmarayInfo.KisiNo = kisiNo;
            marmarayInfo.AdSoyad = kisiler[kisiNo];
            marmarayInfo.BinilenDurak = duraklar[binilenDurak];
            marmarayInfo.İnilenDurak = duraklar[inilecekDurak];
            marmarayInfo.Ucret = tutar - iade;

            string fileName = "MarmarayInfo.json";
            string jsonString = JsonSerializer.Serialize(marmarayInfo);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(jsonString));
        }


        private static double IadeHesaplama(int mesafe)
        {
            double iade = 0;
            if (mesafe < 15 && mesafe > 0)
            {
                iade = 25.04;
            }
            else if (mesafe < 22 && mesafe > 14)
            {
                iade = 19.68;
            }
            else if (mesafe < 29 && mesafe > 21)
            {
                iade = 13.54;
            }
            else if (mesafe < 36 && mesafe > 30)
            {
                iade = 5.77;
            }
            else if (mesafe > 35)
            {
                iade = 0;
            }
            else
            {
                Console.WriteLine("Geçersiz mesafe");
            }

            return iade;
        }
        private static double DuraklarArasiTutarHesaplama(int mesafe)
        {
            double tutar = 0;
            if (mesafe < 8 && mesafe > 0)
            {
                tutar = 27;
            }
            else if (mesafe < 15 && mesafe > 7)
            {
                tutar = 34.72;
            }
            else if (mesafe < 22 && mesafe > 14)
            {
                tutar = 40.08;
            }
            else if (mesafe < 29 && mesafe > 21)
            {
                tutar = 46.22;
            }
            else if (mesafe < 36 && mesafe > 28)
            {
                tutar = 53.99;
            }
            else if (mesafe < 44 && mesafe > 35)
            {
                tutar = 59.76;
            }
            else
            {
                Console.WriteLine("Geçersiz mesafe");
            }

            return tutar;
        }
    }

    public class MarmarayInfo
    {
        public DateTime Bugun { get; set; }
        public int KisiNo { get; set; }
        public string AdSoyad { get; set; }
        public string BinilenDurak { get; set; }
        public string İnilenDurak { get; set; }
        public double Ucret { get; set; }
        
    }
}