using System;

namespace _17_methodOverloadingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] calisanlar = { "ahmet deniz", "veli öztürk", "tuğçe torun", "talha torun", "zeynep toker" };

            double[] maaslar = new double[5];

            do
            {
                for (int i = 0; i < calisanlar.Length; i++)
                {
                    Console.WriteLine(i + " index li çalışan : " + calisanlar[i]);
                }

                Console.WriteLine("Maaşı hesaplanacak çalışanın index nosunu giriniz: ");
                int index = int.Parse(Console.ReadLine());

                Console.WriteLine("Maaş - " + calisanlar[index] + ": ");

                Console.WriteLine("Çalışanın çalışma saatini giriniz: ");
                int saat = int.Parse(Console.ReadLine());

                Console.WriteLine("Saatlik ücret: ");
                int ucret = int.Parse(Console.ReadLine());

                if (saat <= 270)
                {
                    maaslar[index] = MaasHesapla(saat, ucret);
                }
                else
                {
                    var mesai = MesaiHesapla(saat);
                    maaslar[index] = MaasHesapla(saat, ucret, mesai);
                }

                Console.WriteLine("Devam etmek istiyor musunuz: e/h");

            } while (Console.ReadLine().ToLower() == "e");
            

            for (int i = 0; i < calisanlar.Length; i++)
            {
                Console.WriteLine("Personel: " + calisanlar[i] + " Maaş: " + maaslar[i]);
            }
        }

        private static double MaasHesapla(int calisanSaat, double calisanMaas)
        {
            if (calisanSaat > 0)
            {
                return calisanSaat * calisanMaas;
            }
            else
            {
                throw new Exception("Çalışma saati 0 dan küçük olamaz.");
            }
            
        }

        private static double MaasHesapla(int calisanSaat, double calisanMaas, double mesai)
        {
            return MaasHesapla(calisanSaat, calisanMaas) + mesai;
        }

        private static double MesaiHesapla(int calisanSaat, double mesaiUcreti = 550)
        {
            return (calisanSaat - 270) * mesaiUcreti;
        }
    }
}
