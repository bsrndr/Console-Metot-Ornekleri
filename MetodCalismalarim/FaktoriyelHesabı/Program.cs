namespace FaktoriyelHesabı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faktoriyel hesabı yapan metodu yazınız

            Console.WriteLine("Bir sayı giriniz: ");
            int girilenSayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Faktoriyel(girilenSayi));
        }

        static int Faktoriyel(int sayi)
        {
            int sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }

    }
}