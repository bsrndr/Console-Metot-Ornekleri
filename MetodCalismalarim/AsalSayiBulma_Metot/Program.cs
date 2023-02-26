namespace AsalSayiBulma_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# ile bir sayının asal olup olmadığını Metot kullanarak bulan bir örnek gerçekleştireceğiz. Örneğimizde kullanıcının girdiği sayının asal olup olmadığını ekranda yazdıracağız ve bu sayıdan sonraki 5 tane asal sayının hangisi olduğunu bularak yazdıracağız.

            Console.WriteLine("Lütfen bir sayı giriniz:");
            int GirilenSayi= Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            if (AsalSayiMi(GirilenSayi))
            {
                Console.WriteLine("Asal sayıdır: " + GirilenSayi);
            }
            else
            {
                Console.WriteLine("Asal sayı değildir: " + GirilenSayi);
            }

            Console.WriteLine("Sonraki 5 asal sayi: ");

            while (true)
            {
                GirilenSayi++;

                if (AsalSayiMi(GirilenSayi)==true)
                {
                    
                    Console.WriteLine($"Sıradaki asal sayı: {GirilenSayi}");
                    sayac++;
                    if (sayac==5)
                    {
                        break;
                    }
                }
            }
            
        }

        static bool AsalSayiMi(int asalsayi)
        {
            bool durum = false;
            int kontrol = 0;

            for (int i = 2; i < asalsayi; i++)
            {
                if (asalsayi%i==0)
                {
                    kontrol = 1;
                    break;
                }
               
            }
            if (kontrol==1)
            {
                durum = false;
            }
            else
            {
                durum= true;
            }
            return durum;
        }
    }
}