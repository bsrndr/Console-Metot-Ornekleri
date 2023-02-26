namespace Deneme2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# ile bir sayının asal olup olmadığını Metot kullanarak bulan bir örnek gerçekleştireceğiz. Örneğimizde kullanıcının girdiği sayının asal olup olmadığını ekranda yazdıracağız ve bu sayıdan sonraki 5 tane asal sayının hangisi olduğunu bularak yazdıracağız.

            Console.WriteLine("Lütfen bir sayı giriniz");
            int GirilenSayi=Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            if (AsalSayimi(GirilenSayi)==true)
            {
                Console.WriteLine("Girilen sayı asal sayıdır:" + GirilenSayi);
            }
            else
            {
                Console.WriteLine("Asal sayı değildir:" + GirilenSayi);
            }

            Console.WriteLine("Sonraki 5 asal sayı:");

            while (true)
            {
                GirilenSayi++;
                if (AsalSayimi(GirilenSayi))
                {
                    sayac++;
                    Console.WriteLine("Sıradaki asal sayı:" +GirilenSayi);
                    if (sayac==5)
                    {
                        break;
                    }
                }
            }
        }

        static bool AsalSayimi (int asalSayi)
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
                durum =true;
            }
            return durum;   
        }

    }
}