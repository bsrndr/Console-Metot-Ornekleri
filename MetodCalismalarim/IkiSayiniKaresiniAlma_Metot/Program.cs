namespace IkiSayiniKaresiniAlma_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2;
            bool cevap1, cevap2;

            do
            {
                Console.WriteLine("Birinci sayiyi giriniz:");
                cevap1= double.TryParse(Console.ReadLine(), out sayi1);
                Console.WriteLine("İkinci sayiyi giriniz:");
                cevap2 = double.TryParse(Console.ReadLine(), out sayi2);
                if (cevap1==false || cevap2==false)
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                }

            } while (cevap1==false || cevap2==false);
            Console.WriteLine("İki sayının karesinin toplamı: " + IkiSayininKaresininToplamı(sayi1,sayi2));
            Console.WriteLine("İki sayının küpünün toplamı: " + IkiSayininKupununToplamı(sayi1,sayi2));
        }

        static double IkiSayininKaresininToplamı(double a, double b)
        {
            double sonucTopla= Math.Pow(a,2) + Math.Pow(b,2); //Math.Pow yöntemi double old için double tanımladım.
            return sonucTopla;
            
        }

        static double IkiSayininKupununToplamı(double k, double l)
        {
            double sonucTopla2= Math.Pow(k,3) + Math.Pow(l,3);
            return sonucTopla2;
        }


    }
}