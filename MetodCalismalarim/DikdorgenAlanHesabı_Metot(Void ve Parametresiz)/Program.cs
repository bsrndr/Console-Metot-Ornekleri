namespace DikdorgenAlanHesabı_Metot_Void_ve_Parametresiz_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DikdortgenAlanHesabı();
        }

        static void DikdortgenAlanHesabı()
        {
            Console.WriteLine("Lütfen kısa kenarı giriniz");
            int kisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen uzun kenarı giriniz");
            int uzunKenar = Convert.ToInt32(Console.ReadLine());
            int sonuc = kisaKenar * uzunKenar;
            Console.WriteLine(sonuc);
        }
    }
}