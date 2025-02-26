namespace _16_methodsExamples
{
    class Program
    {
        static void Main(string[] args) 
        {

        }

        // bir metod yazın parametre olarak bir sayı dizisi alsın. en büyük sayıyı döndürsün

        private static int MaxNumber(int[] numbers)
        {
            //int max = 0;
            int[] maxMi = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                maxMi[i] = numbers[i];
                if (numbers[i] > numbers[i-1])
            {

            }
            }

            
            
            //bool MaxMi(int number) { }
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
