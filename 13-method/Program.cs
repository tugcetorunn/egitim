using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_method
{
    public class Program
    {
        static void Main(string[] args)
        {
            EkranaYaziYaz(); // static olmadan çalıştırılmaz.
            EkranaIsimYaz("Tuğçe", 20);
            string fullName = AdSoyadBirlestir();
            Console.WriteLine(fullName);
            string[] mail = Ayristirici("tugce@hotmail.com,  torun@bilgeadam.com; halkbank@hotmail.com,ttorun@hotmail.com");

            foreach(string mailItem in mail)
            {
                Console.WriteLine(mailItem);
            }

            int res = Topla(45, 16);
            Console.WriteLine(res);

            double res2 = Bolme(14, 20);
            Console.WriteLine(res2);

            Console.WriteLine(CiftMi(77));
        }

        private static void EkranaYaziYaz()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("hellooo");
            Console.BackgroundColor = ConsoleColor.Blue;
        }

        private static void EkranaIsimYaz(string isim, int yas)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(isim);
            Console.WriteLine("Yaş: " + yas);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        private static string AdSoyadBirlestir()
        {
            return "Tugce" + " " + "Toker";
        }

        private static string[] Ayristirici(string mails)
        {
            return mails.Split(',', ';');
        }

        // topla isminde bir metod oluşturun iki tane int parametre alsın. geriye int döndürsün.

        private static int Topla(int x, int y) 
        {
            return x + y;
        }

        // bölme isminde bir metod oluşturun içerisine double iki parametre alsın ve double döndürsün.

        private static double Bolme(double x, double y)
        {
            if (x != 0 || y != 0)
            {
                return x / y;
            }
            else
            {
                Console.WriteLine("geçersiz sayı girdiniz");
                return 0;
            }
            
        }

        // çiftmi isminde int parametre alan metod yazın geriye bool döndürsün.

        private static bool CiftMi(int x)
        {
            return x % 2 == 0;
        }


    }
}
