namespace IkiSayiniBolumu_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2; // bölme işleminde ondalıklı bir sayı ihtimali için double girildi
            bool cevap1=true, cevap2 = true;
            do
            {
                Console.WriteLine("Birinci sayiyi giriniz");
                cevap1= double.TryParse(Console.ReadLine(), out sayi1);
                Console.WriteLine("İkinci sayiyi giriniz");
                cevap2 = double.TryParse(Console.ReadLine(), out sayi2);
                if (cevap1==false || cevap2==false)
                {
                    Console.WriteLine("Lütfen sayı giriniz!!"); // Uyarı yazısı eklendi
                }

            } while (cevap1==false || cevap2==false);
            Console.WriteLine("İki sayinin bölümü: " + BolmeIslemi(sayi1, sayi2));
        }

        static double BolmeIslemi(double a, double b)
        {
            double sonucBolme = a / b;
            return sonucBolme;
        }
    }
}