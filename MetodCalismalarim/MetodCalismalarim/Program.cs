namespace MetodCalismalarim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen birinci sayı giriniz:");
            int sayiGir1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayı giriniz:");
            int sayiGir2 = Convert.ToInt32(Console.ReadLine());
            Topla(sayiGir1,sayiGir2); // void cikti
            Console.WriteLine("Girilen sayının toplamı:" + Topla2(sayiGir1, sayiGir2)); // int cikti
        }

        static void Topla(int a, int b)
        {
            int topla1 = a + b;
            Console.WriteLine(topla1);
        }

        static int Topla2(int k, int l)
        {
            int topla2=k + l;
            return topla2;
        }

    }
}