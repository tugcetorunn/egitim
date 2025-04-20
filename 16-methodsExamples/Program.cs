namespace _16_methodsExamples
{
    class Program
    {
        static void Main(string[] args) 
        {

        }

        // bir metod yazın parametre olarak bir sayı dizisi alsın. en büyük sayıyı döndürsün

        private static int MaxNumber(int[] dizi)
        {
            if (dizi == null || dizi.Length == 0)
                throw new ArgumentException("Dizi boş veya null olamaz.");

            int enBuyuk = dizi[0];

            foreach (int sayi in dizi)
            {
                if (sayi > enBuyuk)
                    enBuyuk = sayi;
            }

            return enBuyuk;
        }

        // bir metod yazın, parametre olarak bir cümle ve bir harf alsın, bu cümeldeki belirtilen
        // harfin kaç kez geçtiğini döndürsün

        private static void KacKezGeciyor(char[] cumle, char harf)
        {
            int sayac = 0;
            foreach (var item in cumle)
            {
                if (item == harf)
                {
                    sayac++;
                }

                Console.WriteLine(sayac);
            }
        }

        // bir metod yazın, parametre olarak bir dizi alıp bu dizinin elemanlarını ters çevirip yeni dizi döndürsün.

        private static char[] TersineCevir(char[] cumle)
        {
            char[] yeni = new char[cumle.Length];
            for (int i = 0; i < cumle.Length; i++)
            {
                yeni[i] = cumle[cumle.Length - i];
            }

            return yeni;
        }
    }
}
