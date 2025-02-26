namespace _18_methodRefOutParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // ref, out, params

            // ref metodlara veya metodlardan değer tiplerin referanslarını iletmek veya döndürmek için kullanılır.

            // diğer bir deyişle referans yoluyla iletilen bir değerde yapılan herhangi bir değişikliğin yalnızca
            // taşıdığı değeri değil, adresteki (referans) değerini de değiştirdiğiniz için bu değişikliği
            // yansıtacağı anlamına gelir.

            #region ref
            //int a = 10, b = 12;

            //Console.WriteLine($"İşlem öncesi a değişkeni: {a}");
            //Console.WriteLine($"İşlem öncesi b değişkeni: {b}");

            //ToplamDeger(a); // adres değil değer gönderiliyor.

            //Console.WriteLine($"İşlem sonrası a değişkeni: {a}"); // 10 - çünkü değer tipli

            //FarkDeger(ref b);

            //Console.WriteLine($"İşlem sonrası b değişkeni: {b}"); // aynı adreste değişiklik yapıldı. yeni bir şey oluşturulmadı.

            //int[] sayilar = new int[2];
            //Array.Resize(ref sayilar, sayilar.Length + 1); // ref pointer gibi??

            //sayilar[2] = 44;
            #endregion

            #region out
            // out ile bir metottan birden fazla değer döndürürüz.

            //int i = -10, j = -20;

            //Toplam(out i, out j);

            //Console.WriteLine("Toplam değer i: " + i);
            //Console.WriteLine("Toplam değer j: " + j);

            //int.TryParse(Console.ReadLine(), out int k);
            #endregion

            #region örnek
            //int x = 60, y = 90;

            //Bolum(155, 50, out int k);

            //Console.WriteLine(Fark(ref x, ref y));
            #endregion

            #region params

            //int dönenDeger1 = Topla(34, 54, 78, 12);
            //int dönenDeger2 = Topla(34, 54, 78, 12, -45, 30);
            //int dönenDeger3 = Topla(34, 54, 78, 12, -45, 30, 156);

            //Console.WriteLine(Birlestir("ahmet", "mehmet", "yusuf", "veli"));
            #endregion

            var date1 = DateTime.Now;
            var date2 = DateTime.Now.AddHours(2).AddMinutes(20);

            var fark = date2 - date1;
            var minute = fark.TotalMinutes;
        }

        #region recursive method (kendini çağıran metodlar)
        private static int Faktoriyel(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Faktoriyel(n - 1);
        } 
        #endregion

        #region params
        //private static string Birlestir(params string[] kelimeler)
        //{
        //    var sonuc = "";
        //    foreach (var item in kelimeler)
        //    {
        //        sonuc += kelimeler + " ";
        //    }
        //    return sonuc;
        //}

        //private static int Topla(params int[] sayilar)
        //{
        //    int toplam = 0;
        //    for (int i = 0; i < sayilar.Length; i++)
        //    {
        //        toplam += sayilar[i];
        //    }

        //    return toplam;
        //}
        #endregion

        #region out
        //private static void Toplam(out int p, out int q)
        //{
        //    //p = 30;
        //    //q = 40;
        //    p += p;
        //    q += q;

        //    //Console.WriteLine(p + " " + q);
        //} 
        #endregion


        #region ref
        //private static void FarkDeger(ref int x)
        //{
        //    x -= 5;
        //}

        //private static int ToplamDeger(int x) // ram de yeni a oluşturuluyor.
        //{
        //    return x += 10;
        //}
        #endregion

        #region örnek
        // fark isminde bir metod oluşturun. metod iki değer göndersin. metoddan ilk prmtr 60, 2. prmtr 90,
        // geri dönüş değeri de 30 gelsin.

        //private static int Fark(ref int x, ref int y)
        //{
        //    return x - y;
        //}

        //private static int Fark1(out int x, out int y)
        //{
        //    x = 60;
        //    y = 90;
        //    return 30;
        //}

        // bölüm isminde metod yazın. iki sayı alsın. bölümü double olarak parametre ile döndürsün. kalan varsa
        // onu da return etsin.

        //private static double Bolum(int bolunen, int bolum, out int kalan)
        //{
        //    double sonuc = bolunen / bolum;

        //    //if (bolunen % bolum != 0)
        //    //{
        //    //    kalan = bolunen % bolum;
        //    //}

        //    kalan = bolunen % bolum;

        //    return sonuc;
        //}

        //private static double Bolum(int x, int y, out double bolum)
        //{
        //    bolum = (double)x / y;
        //    return x % y;
        //} 
        #endregion
    }
}
