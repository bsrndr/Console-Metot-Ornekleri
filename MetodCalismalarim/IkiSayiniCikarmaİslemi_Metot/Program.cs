namespace IkiSayiniCikarmaİslemi_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            bool cevap = true;
            bool cevap2 = true;
            do
            {
                Console.WriteLine("Birinci sayiyi giriniz:");
                cevap = int.TryParse(Console.ReadLine(), out sayi1);
                Console.WriteLine("İkinci sayiyi giriniz:");
                cevap2 = int.TryParse(Console.ReadLine(), out sayi2);

            } while (cevap==false || cevap2==false);

            Console.WriteLine("İki sayinin farki: " + Cikarma(sayi1, sayi2));

        }

        static int Cikarma(int a, int b)
        {
            int cikar = a - b;
            return cikar;
        }


    }
}