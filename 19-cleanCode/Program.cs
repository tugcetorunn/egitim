using System;
using System.Text.Json;

namespace _19_cleanCode
{
    class Program
    {
        static void Main(string[] args)
        {

            #region clean code
            // mantıklı isimlendirme
            // camelCase, PascalCase
            // metotlara ayırma
            // classlara ayırma
            // yorum satırı kullanma
            // summary kullanma
            // boşluk kullanımı
            // hata yönetimi

            // 1- isimlendirme
            // değişken ve metod isimleri kısa ve anlamlı olmalıdır.

            //int a = 10; // kötü

            //int ogrenciSayisi = 20;

            //// 2- metot uzunluğu
            //// metodları olabildiğince kısa tutalım. birinci sorumluluk üzerine odaklanın.

            //// 3- yorumlar
            //// kodun hedefine odaklanan yorumlar yazın.

            //// 4- boşluk kullanımı
            //for (int i=0;i<5;i++) 
            //{
            //    // kötü
            //}

            //// 5- hata yönetimi
            //// kötü
            //try
            //{
            //    // istisna fırlatılacak kodlarımız
            //}
            //catch (Exception)
            //{
            //    // özel bir işlem olmadan tüm istisnaları yakalar.
            //    throw;
            //}

            //// iyi
            //try
            //{
            //    // sadece hata olabilme ihtimali olan kodlar
            //}
            //catch (OverflowException ex)
            //{
            //    // belirli durumlkarda hata fırlat
            //    throw;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    throw;
            //}
            //catch (NullReferenceException ex)
            //{
            //    throw;
            //}
            //catch (FormatException ex)
            //{
            //    throw;
            //}
            //catch(Exception ex)
            //{
            //    throw;
            //} 
            #endregion

            #region best practices

            //int sayi, sayac = 0, maksimumSayi = 0, ciftMaksimumSayi = 0;

            //bool sayiMi = KullanicidanSayiAl(out sayi);

            //if (sayiMi && sayi >= 0 && sayi != 1)
            //{
            //    DegerleriBul(out ciftMaksimumSayi, out maksimumSayi, sayi, out sayac);
            //    DegerleriEkranaYaz(maksimumSayi, ciftMaksimumSayi, sayac);
            //}
            //else if(!sayiMi)
            //{
            //    Console.WriteLine("Girilen değer bir sayı değil.");
            //}
            //else if(sayi < 0)
            //{
            //    Console.WriteLine("Sayı negatif.");
            //}
            //else if(sayi == 1)
            //{
            //    Console.WriteLine("Sayıyı 1 girdiniz.");
            //}
            #endregion

            // Console.WriteLine("Ne işlem yapmak istiyorsunuz: ");

            //    int kisiNo, gunlukYolcu = 0;
            //    double gunlukKazanc = 0; 
            //    double bakiye = 100; 
            //    double kayitBakiye;
            //    string kisiIsim, kayitAdSoyad;

            //    var marmarayInfo = new MarmarayInfo();
            //    string fileName = "MarmarayInfo.json";
            //    string jsonString = JsonSerializer.Serialize(marmarayInfo);


            //    List<string> duraklar = new List<string>{"Gebze", "Osmangazi", "Fatih", "Çayırova", "Tuzla", "İçmeler",
            //        "Aydıntepe", "Güzelyalı", "Tersane", "Kaynarca", "Pendik", "Yunus", "Kartal", "Başak", "Atalar", "Cevizli",
            //        "Maltepe", "Süreyya Plajı", "İdealtepe", "Küçükyalı", "Bostancı", "Suadiye", "Erenköy", "Göztepe",
            //        "Feneryolu", "Söğütlüçeşme", "Ayrılık Çeşmesi", "Üsküdar", "Sirkeci", "Yenikapı", "Kazlıçeşme",
            //        "Fişekhane", "Yenimahalle", "Bakırköy", "Ataköy", "Yeşilyurt", "Yeşilköy", "Florya Akvaryum",
            //        "Florya", "Küçükçekmece", "Mustafa Kemal", "Halkalı" };

            //    //Dictionary<int, string> dicDuraklar = duraklar.ToDictionary();
            //    Dictionary<int, string> kisiler = new Dictionary<int, string>();
            //    kisiler.Add(1, "ahmet");
            //    kisiler.Add(2, "mehmet");
            //    kisiler.Add(3, "ali");
            //    kisiler.Add(4, "veli");
            //    kisiler.Add(5, "burak");

            //    Dictionary<int, double> bakiyeler = new Dictionary<int, double>();
            //    bakiyeler.Add(1, bakiye);
            //    bakiyeler.Add(2, bakiye);
            //    bakiyeler.Add(3, bakiye);
            //    bakiyeler.Add(4, bakiye);
            //    bakiyeler.Add(5, bakiye);

            //    DateTime bugun = DateTime.Now;
            //    Console.WriteLine(bugun);

            //    Console.WriteLine("1- Giriş \n 2- Kayıt ol");
            //    string girisSecim = Console.ReadLine();

            //    switch (girisSecim)
            //    {
            //        case "1":
            //            Console.WriteLine("Numaranızı giriniz: ");
            //            kisiNo = int.Parse(Console.ReadLine());
            //            kisiIsim = kisiler[kisiNo];
            //            Console.WriteLine("Merhaba " + kisiIsim);
            //            break;
            //        case "2":
            //            Console.WriteLine("Adınız soyadınız: ");
            //            kayitAdSoyad = Console.ReadLine();
            //            kisiler.Add((kisiler.Keys.Count + 1), kayitAdSoyad);
            //            Console.WriteLine("Kayıt oldunuz " + kayitAdSoyad);
            //            Console.WriteLine("Bakiyenizi giriniz: ");
            //            kayitBakiye = Convert.ToDouble(Console.ReadLine());
            //            bakiyeler.Add((bakiyeler.Keys.Count + 1), kayitBakiye);
            //            break;
            //        default:
            //            Console.WriteLine("Geçerli seçim yapınız...");
            //            break;
            //    }



            //    Console.WriteLine("1- Nereden bindiniz?");
            //    for (int i = 0; i < duraklar.Count; i++)
            //    {
            //        Console.WriteLine($"{i+1}. durak: {duraklar[i]}");
            //    }

            //    int binilenDurak = int.Parse(Console.ReadLine());

            //    Console.WriteLine("2- Nerede ineceksiniz?");

            //    int inilecekDurak = int.Parse(Console.ReadLine());

            //    int mesafe = inilecekDurak - binilenDurak;

            //    double tutar = DuraklarArasiTutarHesaplama(mesafe);
            //    Console.WriteLine($"Mesafe: {mesafe} durak \n Tutar: {tutar} tl");

            //    bakiyeler[kisiNo] = bakiyeler[kisiNo] - tutar;

            //    Console.WriteLine("İade alacak mısınız? e/h");

            //    string iadeSecim = Console.ReadLine();
            //    double iade = 0;

            //    if (iadeSecim == "e")
            //    {
            //        iade = IadeHesaplama(mesafe);
            //        bakiyeler[kisiNo] = bakiyeler[kisiNo] + iade;
            //    }
            //    else
            //    {
            //        Console.WriteLine("İade istemediniz.");
            //    }


            //}

            // marmaray ödeme sist. console
            // kartid, ad soyad
            // ne işlem yapılacak
            // 1-nereden bindiniz liste 50 tl kesildi // marmaray karttan düşme
            // 2-nerede ineceksin liste
            // 2.1-nerede indiyse iade tutarı (web ten) // iade alacak mısınız sorulacak // marmaray karta ekleme
            // 3-z raporu - günlük kazanç raporu kaç kişi bindi, kaç para kazandık
            // 4-kart bakiyesi öğrenme bonus
            // 5-karta bakiye yükleme bonus

            // öğrenci, tam, 65 yaş üstü

            // kazanımlar
            // karar yapıları, döngüler
            // collections, list, dictionary
            // io - json formatında kaydedilecek
            // clean code
            // metotlar
            // hata yönetimi
            // extra - bonuslar

            //private static void GunlukKazancTutari()
            //{

            //}

            //private static double IadeHesaplama(int mesafe)
            //{
            //    double iade = 0;
            //    if (mesafe < 15 && mesafe > 0)
            //    {
            //        iade = 25.04;
            //    }
            //    else if (mesafe < 22 && mesafe > 14)
            //    {
            //        iade = 19.68;
            //    }
            //    else if (mesafe < 29 && mesafe > 21)
            //    {
            //        iade = 13.54;
            //    }
            //    else if (mesafe < 36 && mesafe > 30)
            //    {
            //        iade = 5.77;
            //    }
            //    else if (mesafe > 35)
            //    {
            //        iade = 0;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Geçersiz mesafe");
            //    }

            //    return iade;
            //}
            //private static double DuraklarArasiTutarHesaplama(int mesafe)
            //{
            //    double tutar = 0;
            //    if (mesafe < 8 && mesafe > 0)
            //    {
            //        tutar = 27;
            //    }
            //    else if (mesafe < 15 && mesafe > 7)
            //    {
            //        tutar = 34.72;
            //    }
            //    else if (mesafe < 22 && mesafe > 14)
            //    {
            //        tutar = 40.08;
            //    }
            //    else if (mesafe < 29 && mesafe > 21)
            //    {
            //        tutar = 46.22;
            //    }
            //    else if (mesafe < 36 && mesafe > 28)
            //    {
            //        tutar = 53.99;
            //    }
            //    else if (mesafe < 44 && mesafe > 35)
            //    {
            //        tutar = 59.76;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Geçersiz mesafe");
            //    }

            //    return tutar;
            //}
            #region best practices
            /// <summary>
            /// 
            /// 
            /// </summary>
            /// <param name="maksimumSayi"></param>
            /// <param name="ciftMaksimumSayi"></param>
            /// <param name="sayac"></param>
            /// <exception cref="NotImplementedException"></exception>
            //private static void DegerleriEkranaYaz(int maksimumSayi, int ciftMaksimumSayi, int sayac)
            //{
            //    Console.WriteLine("Bu işlem sırasında ulaşılan maks sayı: {0}", maksimumSayi);
            //    Console.WriteLine("Bu işlem sırasında sürekli çift olarak 1e ulaşılan maks sayı: {0}", ciftMaksimumSayi);
            //    Console.WriteLine("Bu işlem bitene kadarki adım sayısı: {0}", sayac);
            //}

            /// <summary>
            /// Gerekli döngüyü kullanarak değerleri bulur.
            /// </summary>
            /// <param name="ciftMaksimumSayi">ciftMaksimumSayi değerini alır</param>
            /// <param name="maksimumSayi">maksimumSayi değerini alır</param>
            /// <param name="sayi">sayi değerini alır</param>
            /// <param name="sayac">sayac değerini alır</param>
            /// <exception cref="NotImplementedException"></exception>
            //private static void DegerleriBul(out int ciftMaksimumSayi, out int maksimumSayi, int sayi, out int sayac)
            //{
            //    ciftMaksimumSayi = maksimumSayi = sayac = 0; // out la geldikleri için değer alması gerekiyor.

            //    while (sayi >= 2)
            //    {
            //        sayac++;

            //        if (sayi % 2 == 1)
            //        {
            //            sayi = (sayi * 3) + 1;
            //            sayac++;
            //            ciftMaksimumSayi = 0;
            //        }

            //        ciftMaksimumSayi = ciftMaksimumSayi < sayi ? sayi : ciftMaksimumSayi;

            //        sayi /= 2;
            //    }

            //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sayi"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        //private static bool KullanicidanSayiAl(out int sayi)
        //{
        //    Console.WriteLine("Pozitif bir sayı giriniz: ");
        //    //sayi = int.Parse(Console.ReadLine());

        //    //if (sayi % 1 == sayi)
        //    //{
        //    //    return true;
        //    //}

        //    //return false;

        //    return int.TryParse(Console.ReadLine(), out sayi);
        //} 
        #endregion
    }

        //public class MarmarayInfo
        //{
        //    public DateTime Bugun { get; set; }
        //    public int KisiNo { get; set; }
        //    public string AdSoyad { get; set; }
        //    public string BinilenDurak { get; set; }
        //    public string İnilenDurak { get; set; }
        //    public double Ucret { get; set; }
        //}
    }
}
