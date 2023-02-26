namespace IkiSayininCarpimi_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            bool cevap1, cevap2=true;

            do
            {
                Console.WriteLine("birinci sayıyı giriniz:");
                cevap1 = int.TryParse(Console.ReadLine(), out sayi1);
                Console.WriteLine("ikinci sayıyı giriniz:");
                cevap2 = int.TryParse(Console.ReadLine(), out sayi2);

            } while (cevap1==false || cevap2==false);

            int cikti = Carpma(sayi1,sayi2); // başka bir int değerine atarak aşağıda yazdırabiliriz
            Console.WriteLine("İki sayinin carpimi: " + cikti); // int cikti

            CarpmaVoid(sayi1,sayi2); // void cikti
          
        }

        static int Carpma(int a, int b)
        {
            int IkiSayininCarpimi = a * b;
            return IkiSayininCarpimi;
        }

        static void CarpmaVoid (int a, int b) 
        { 
          int ikiSayininVoidCarpımı=a * b;
          Console.WriteLine("İki sayinin carpimi: "+ ikiSayininVoidCarpımı);
        }
    }
}