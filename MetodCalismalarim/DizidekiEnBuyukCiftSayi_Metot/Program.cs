namespace DizidekiEnBuyukCiftSayi_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //20 elemanlı bir diziye 0-100 arası rastgele sayılar atarak bu dizi içinde bulunan en büyük çift sayıyı metot kullanarak bulacağız. Değer girme ve dizi elemanlarını yazdırma işlemini ana programda, en büyük çift sayıyı bulma işlemini metot kullanarak gerçekleştireceğiz.

            Random rnd= new Random();

            int[] sayilar= new int[20];

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(1, 100);
                Console.WriteLine(sayilar[i]);
            }
            Console.WriteLine("En buyuk cift sayi: " +EnBuyukCiftSayi(sayilar));
        }

        static int EnBuyukCiftSayi(int[] number)
        {
            int enbuyuk = 0;
            for (int i = 0; i < number.Length; i++)
            {
                
                if (enbuyuk < number[i] && number[i] % 2 == 0)
                {
                    enbuyuk = number[i];
                }
            }
            return enbuyuk;
        }
    }
}