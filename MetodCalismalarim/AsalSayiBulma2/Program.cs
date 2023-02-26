namespace AsalSayiBulma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# ile bir sayının asal olup olmadığını Metot kullanarak bulan bir örnek gerçekleştireceğiz. Örneğimizde kullanıcının girdiği sayının asal olup olmadığını ekranda yazdıracağız ve bu sayıdan sonraki 5 tane asal sayının hangisi olduğunu bularak yazdıracağız.
            Console.Write("Lütfen bir sayı giriniz:");
            int girilenSayi=Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            if (AsalSayiMi(girilenSayi))
            {
                Console.WriteLine("Asal sayıdır:" +girilenSayi);
            }
            else
            {
                Console.WriteLine("Asal sayı değildir:" +girilenSayi);
            }

            Console.WriteLine("Sonraki 5 asal sayi:");

            while (true)
            {
                girilenSayi++;

                if (AsalSayiMi(girilenSayi))
                {
                    sayac++;
                    Console.WriteLine("Sonraki asal sayi:" +girilenSayi);
                    if (sayac==5)
                    {
                        break;
                    }
                }
            }

        }
        


        static bool AsalSayiMi(int asalSayi)
        {
            bool durum = false;
            int kontrol = 0;

            for (int i = 2; i < asalSayi; i++)
            {
                if (asalSayi%i==0)
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