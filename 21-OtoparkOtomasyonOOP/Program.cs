namespace _21_OtoparkOtomasyonOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // araç plakası, giriş saati, araç tipi, çıkış saati, ücret
            // mevcut araçlar, otopark kapasitesi = 20
            // çıkış yapmadan aynı plaka eklenemez.
            // ilk 15 dk ücretsiz
            // z raporu günlük giriş çıkış yapmış araç listesi saat ücret plaka
            // çıkış yapmamış araçlar
            while (true)
            {
                Menu();
            }
        }

        private static void Menu()
        {
            Console.WriteLine("Hoşgeldiniz, işlem seçiniz: ");
            Console.WriteLine("1- Kapasite bilgisi");
            Console.WriteLine("2- Araç girişi");
            Console.WriteLine("3- Araç çıkışı");

            string menuSecim = Console.ReadLine();
            string plaka = "";

            switch (menuSecim)
            {
                case "1":
                    KapasiteBilgisi();
                    break;
                case "2":
                    plaka = GirisIslemleri();
                    break;
                case "3":
                    CikisIslemleri(plaka);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim yaptınız.");
                    break;
            }
        }

        private static void CikisIslemleri(string plaka)
        {

            if (mevcutAraclar.Find(x => x.Plaka == plaka) != null)
            {
                var arac = mevcutAraclar.Find(x => x.Plaka == plaka);
                DateTime cikisSaati = arac.GirisSaati.AddHours(1);
                arac.CikisSaati = cikisSaati;
                UcretHesapla(plaka);
                // jsona kaydet
                mevcutAraclar.Remove(arac);
            }
            else
            {
                Console.WriteLine("Araç bulunamadı.");
            }

        }

        private static void DosyayaKaydet()
        {

        }

        List<double> motosikletUcretler = new List<double> { 40, 55, 65, 85, 105 }; // saat arası id, ücret
        static List<double> otomobilUcretler = new List<double> { 80, 110, 130, 170, 210 }; // saat arası id, ücret
        static List<double> otobusUcretler = new List<double> { 160, 220, 260, 340, 420 }; // saat arası id, ücret
        static List<double> minibusUcretler = new List<double> { 120, 165, 195, 255, 315 }; // saat arası id, ücret
        static Dictionary<AracTipi, List<double>> ucretler = new Dictionary<AracTipi, List<double>>();


        private static void UcretHesapla(string plaka)
        {
            ucretler.Add(AracTipi.Motosiklet, new List<double> { 40, 55, 70 });
            ucretler.Add(AracTipi.Otomobil, new List<double> { 50, 60, 70 });
            ucretler.Add(AracTipi.Minibüs, new List<double> { 50, 60, 70 });
            ucretler.Add(AracTipi.Otobüs, new List<double> { 50, 60, 70 });

            AracKayitlari arac = mevcutAraclar.Find(x => x.Plaka == plaka);

            double dakika = (arac.CikisSaati - arac.GirisSaati).TotalMinutes;
            double saat = dakika / 60;
            double tutar = 0;

            if (arac.AracTipi == aracTipleri[0])
            {
                if (saat > 4 && saat <= 5)
                {
                    tutar = otomobilUcretler[4] * 2;
                }
                else if (saat > 3 && saat <= 4)
                {
                    tutar = otomobilUcretler[3] * 2;
                }
                else if (saat > 2 && saat <= 3)
                {
                    tutar = otomobilUcretler[2] * 2;
                }
                else if (saat > 1 && saat <= 2)
                {
                    tutar = otomobilUcretler[1] * 2;
                }
                else if (saat > 0 && saat <= 1)
                {
                    tutar = otomobilUcretler[0] * 2;
                }
            }
            else if (arac.AracTipi == aracTipleri[1])
            {
                if (saat > 4 && saat <= 5)
                {
                    tutar = otobusUcretler[4] * 2;
                }
                else if (saat > 3 && saat <= 4)
                {
                    tutar = otobusUcretler[3] * 2;
                }
                else if (saat > 2 && saat <= 3)
                {
                    tutar = otobusUcretler[2] * 2;
                }
                else if (saat > 1 && saat <= 2)
                {
                    tutar = otobusUcretler[1] * 2;
                }
                else if (saat > 0 && saat <= 1)
                {
                    tutar = otobusUcretler[0] * 2;
                }
            }
            else if (arac.AracTipi == aracTipleri[2])
            {
                if (saat > 4 && saat <= 5)
                {
                    tutar = minibusUcretler[4] * 2;
                }
                else if (saat > 3 && saat <= 4)
                {
                    tutar = minibusUcretler[3] * 2;
                }
                else if (saat > 2 && saat <= 3)
                {
                    tutar = minibusUcretler[2] * 2;
                }
                else if (saat > 1 && saat <= 2)
                {
                    tutar = minibusUcretler[1] * 2;
                }
                else if (saat > 0 && saat <= 1)
                {
                    tutar = minibusUcretler[0] * 2;
                }
            }
            else if (arac.AracTipi == aracTipleri[3])
            {
                var list = ucretler[AracTipi.Motosiklet];

                for (int i = 0; i < 4; i++) // i=4 saat>i list teki i. elemanı al
                {
                    if (saat > i)
                    {
                        tutar = list[i];
                    }
                }

                //if (saat > 4 && saat <= 5) 
                //{
                //    tutar = motosikletUcretler[4] * 2;
                //}
                //else if (saat > 3 && saat <= 4)
                //{
                //    tutar = motosikletUcretler[3] * 2;
                //}
                //else if (saat > 2 && saat <= 3)
                //{
                //    tutar = motosikletUcretler[2] * 2;
                //}
                //else if (saat > 1 && saat <= 2)
                //{
                //    tutar = motosikletUcretler[1] * 2;
                //}
                //else if (saat > 0 && saat <= 1)
                //{
                //    tutar = motosikletUcretler[0] * 2;
                //}
            }

            arac.Ucret = tutar;
        }

        static List<string> aracTipleri = new List<string> { "Otomobil", "Otobüs", "Minibüs", "Motosiklet" };
        static List<AracKayitlari> mevcutAraclar = new List<AracKayitlari>();
        private static string GirisIslemleri()
        {
            // kapasite kontrolü - mevcut araçları getir sayısını kontrol et
            Console.WriteLine("Plakanızı giriniz: ");
            string gelenPlaka = Console.ReadLine();

            Console.WriteLine("Araç tipi seçiniz: ");
            for (int i = 0; i < aracTipleri.Count; i++)
            {
                Console.WriteLine($"{i + 1}- {aracTipleri[i]}");
            }
            int gelenAracTip = int.Parse(Console.ReadLine());

            mevcutAraclar.Add(new AracKayitlari
            {
                Plaka = gelenPlaka,
                AracTipi = aracTipleri[gelenAracTip],
                GirisSaati = DateTime.Now
            });

            // jsona kaydet

            return gelenPlaka;
        }

        private static void KapasiteBilgisi()
        {

        }
    }

    public class AracKayitlari
    {
        public string Plaka { get; set; }
        public DateTime GirisSaati { get; set; }
        public DateTime CikisSaati { get; set; }
        public string AracTipi { get; set; }
        public double Ucret { get; set; }
    }

    public enum AracTipi
    {
        Otomobil,
        Otobüs,
        Minibüs,
        Motosiklet
    }
}


