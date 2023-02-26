namespace IfadeyiTerstenYazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // girilen string ifadeleri tersten yazan metod
            Console.WriteLine("Lütfen bir kelime yazınız");
            string girilenKelime = Console.ReadLine();

            Console.WriteLine(TerstenYazma(girilenKelime));

        }

        static string TerstenYazma(string tersyaz)
        {
            string basla = "";
            for (int i = tersyaz.Length - 1; i >= 0; i--)
            {
                basla += tersyaz[i];

            }
            return basla;
        }
    }
}