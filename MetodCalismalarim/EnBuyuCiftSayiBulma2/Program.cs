namespace EnBuyuCiftSayiBulma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //20 elemanlı bir diziye 0-100 arası rastgele sayılar atarak bu dizi içinde bulunan en büyük tek sayıyı metot kullanarak bulacağız. Değer girme ve dizi elemanlarını yazdırma işlemini ana programda, en büyük tek sayıyı bulma işlemini metot kullanarak gerçekleştireceğiz.

            Random rnd = new Random();
            int[] sayilar = new int[20];

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(1, 100);
                Console.WriteLine(sayilar[i]);
            }
            Console.WriteLine("En büyük tek sayı: " +EnBuyukTek(sayilar));
        }

        static int EnBuyukTek(int[] number)
        {
            int enBuyuk = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (enBuyuk < number[i] && number[i]%2==1)
                {
                    enBuyuk = number[i];
                }
            }
            return enBuyuk;
        }
    }
}