using System;

namespace Tanımalama_Erişim_ve_Döngülerle_Dizi_Kullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi Tanımlama

            string[] renkler = new string[5];
            string[] hayvanlar = {"Kedi", "Köpek", "Köpek", "Maymun"};
            int[] dizi;
            dizi = new int [5];

            // Dizilerde Değer Atama ve Erişim

            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Döngülerle Dizi Kullanımı

            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayısı giriniz", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach(var sayi in sayiDizisi)
                    toplam += sayi;
            
            Console.WriteLine("Ortalama:" + toplam / diziUzunlugu);
        }   
    }
}
