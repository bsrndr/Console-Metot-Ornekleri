namespace DikdortgenAlanHesabı_1yontem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DikdortgenAlanHesabı();
        }

        static void DikdortgenAlanHesabı() // geriye değer döndürmeyen ve parametresiz
        {
            Console.WriteLine("Lütfen kısa kenarı giriniz");
            int kisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen uzun kenarı giriniz");
            int uzunKenar = Convert.ToInt32(Console.ReadLine());
            int sonuc = kisaKenar * uzunKenar;
            Console.WriteLine($"Dikdörtgenin alanı: {sonuc}");
        }
    }
}