namespace _15_localFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            // metod içinde oluşturulan metodlardır.

            int[] sayilar = { 1, 2, 3 };

            Console.WriteLine(KarekokHesapla(sayilar));

            double KarekokHesapla(int[] sayilar)
            {
                // dizi içindeki sayıları topla, karekök al.
                int topla = 0;

                for (int i = 0; i < sayilar.Length; i++)
                {
                    topla += sayilar[i];
                }

                return Math.Sqrt(topla);
            }
        }
    }
}
