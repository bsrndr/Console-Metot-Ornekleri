namespace DikdortgenAlan_VoidParametreli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kısa kenarı giriniz: ");
            int kisaKenar= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen uzun kenarı giriniz: ");
            int uzunKenar = Convert.ToInt32(Console.ReadLine());
            DikdortgenAlan(kisaKenar,uzunKenar);
        }

        static void DikdortgenAlan(int a, int b)
        {
            int alanSonuc = a * b;
            Console.WriteLine("Dikdörtgenin alanı:" + alanSonuc);
        }
    }
}