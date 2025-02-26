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
        // tc kimlik no doğrulama (kurallara bak)
    }
}