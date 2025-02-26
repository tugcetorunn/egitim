
internal class Program
{
    private static void Main(string[] args)
    {
        do // devamlı işlem yaptırmak istiyoruz.
        {
            HesapMakinesi();
        } while (DevamMi());
    }

    private static double SayiAl()
    {
        double deger;
        bool res;
        do
        {
            Console.WriteLine("Bir sayı girin: ");
            res = double.TryParse(Console.ReadLine(), out deger);

            if (!res)
            {
                Console.WriteLine("değer uygun değil!");
            }

        } while (!res);

        return deger;
    }

    private static void BilgiVer()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("İşlem seçin [Topla (+) Çıkar (-) Çarp (*) Böl (/)]");
    }

    private static void HesapMakinesi()
    {
        BilgiVer();

        double x = SayiAl();

        Console.WriteLine("Bir işlem seçiniz: ");
        string secim = Console.ReadLine();

        double y = SayiAl();

        switch (secim)
        {
            case "+":
                Console.WriteLine("Toplam sonucu: " + Topla(x, y));
                break;

            case "-":
                Console.WriteLine("Çıkarma sonucu: " + Cikar(x, y));
                break;

            case "*":
                Console.WriteLine("Çarpma sonucu: " + Carp(x, y));
                break;

            case "/":
                Console.WriteLine("Bölme sonucu: " + Bol(x, y));
                break;

            default:

                break;
        }

    }

    private static double Topla(double x, double y)
    {
        return x + y;
    }

    private static double Cikar(double x, double y)
    {
        return x - y;
    }

    private static double Carp(double x, double y)
    {
        return x * y;
    }

    private static double Bol(double x, double y)
    {
        if (x != 0 || y != 0)
        {
            return x / y;
        }
        else
        {
            Console.WriteLine("sıfırdan farklı sayı giriniz");
            return 0;
        }
    }

    private static bool DevamMi()
    {
        Console.WriteLine("Devam etmek istiyorsanız 1 giriniz: ");
        return Convert.ToInt32(Console.ReadLine()) == 1;
    }
}