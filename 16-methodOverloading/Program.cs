namespace _16_methodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            EkranaYaz(5);
            EkranaYaz();
            EkranaYaz("tugce");
            EkranaYaz("tugce", "torun");

            Console.WriteLine(MailOlustur("tugce"));
            Console.WriteLine(MailOlustur("tugce", "torun"));
            Console.WriteLine(MailOlustur("tugce", "torun", "bilgeadam.com"));

            Console.WriteLine(IngilizceKaraktereDonustur("Adım Tuğçe Torun. Günaydın..."));

            string a = "Merhaba";
            string b = "Merhaba";
            Console.WriteLine(object.ReferenceEquals(a, b)); // true. string immutable dır. (değişmez)
        }

        static int EkranaYaz(int yas)
        {
            Console.WriteLine("Merhaba yaşınız: " + yas);
            return yas;
        }

        static void EkranaYaz()
        {
            Console.WriteLine("hellooo");
        }

        static void EkranaYaz(string ad)
        {
            Console.WriteLine("Merhaba " + ad);
        }

        static void EkranaYaz(string ad, string soyad)
        {
            Console.WriteLine(ad + " " + soyad);
        }

        static string MailOlustur(string isim)
        {
            return isim.ToLower() + "@bilgeadam.com";

        }

        static string MailOlustur(string isim, string soyisim)
        {
            return isim.ToLower() + "." + soyisim.ToLower() + "@bilgeadam.com";
        }

        static string MailOlustur(string isim, string soyisim, string domain)
        {
            return isim.ToLower() + "." + soyisim.ToLower() + "@" + domain.ToLower();
        }

        // türkçe karakterlerin ing karaktere dönmesi fonksiyonu

        static string IngilizceKaraktereDonustur(string metin)
        {
            char[] strDizi = metin.ToCharArray();
            string yeniMetin = "";
            string degisenItem = "";
            foreach (var item in strDizi)
            {
                yeniMetin += item;

                if (item == 'ı' || item == 'ö' || item == 'ü' || item == 'ş' || item == 'ç' || item == 'ğ')
                {
                    yeniMetin = yeniMetin.Substring(0, yeniMetin.Length - 1); // Türkçe karakteri sileriz.

                    degisenItem = item.ToString().ToLower(); // çünkü item iterasyon elemanı old için değer atayamayız.
                    switch (degisenItem)
                    {
                        case "ı":
                            degisenItem = "i";
                            break;
                        case "ö":
                            degisenItem = "o";
                            break;
                        case "ü":
                            degisenItem = "u";
                            break;
                        case "ş":
                            degisenItem = "s";
                            break;
                        case "ç":
                            degisenItem = "c";
                            break;
                        case "ğ":
                            degisenItem = "g";
                            break;
                        default:
                            break;
                    }

                    yeniMetin += degisenItem; // Türkçe karakteri ingilizce karaktere dönüştürüp ekliyoruz.
                }
            }
            return yeniMetin;
        }

        // tc kimlik no doğrulama (kurallara bak)
    }
}