using System;

namespace DiziToplaveOrtBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ana programda oluşturacağımız dizi 20 elemanlı olacak ve içine 1-100 arası rastgele değerler  girilmiş olacak. Topla isimli metodumuz dizi türünden parametre alarak int türünden değer döndürecek. Yine aynı şekilde Ortalama isimli metodumuzda dizi türünde parametre alarak geriye farklı olarak double türünde bir değer döndürecek.

            Random rnd = new Random();
            int[] sayilar = new int[20];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(1, 100);
                Console.WriteLine(sayilar[i]);
            }
            Console.WriteLine("Sayıların Toplamı: "+ Topla(sayilar));
            Console.WriteLine("Sayıların Ortalaması: " + Ortalama(sayilar));
        }

        static int Topla(int[] number)
        {
            int sonuc = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sonuc = sonuc + number[i];
            }
            return sonuc;
        }

        static double Ortalama(int[] number2)
        {
            double sonuc2 = 0;
            double ort = 0;

            for (int i = 0; i < number2.Length; i++)
            {
                sonuc2 += number2[i];
                
            }
            ort = sonuc2 / number2.Length;
            return ort;
        }
    }
}