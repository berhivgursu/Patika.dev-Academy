using System;
using System.Collections;

namespace Soru_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            int total_b = 0;
            int total_l = 0;

            double avg_b;
            double avg_l;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Lütfen bir sayı giriniz: ");
                list.Add(int.Parse(Console.ReadLine()));
            }   
            
            Console.WriteLine("Sayılar: ");
            foreach (int item in list)
                Console.Write(item + " ");
            
            
            list.Sort();
            
            for (int i = 0; i < 3; i++)
                total_l += (int)list[i];

            avg_l = (double)total_l / 3;

            Console.WriteLine("\nEn Küçük 3 Sayının Ortalama Toplamları: " + total_l);
            Console.WriteLine("En Küçük 3 Sayının Ortalaması: " + avg_l);

            list.Reverse();
        
            for (int i = 0; i < 3; i++)
                total_b += (int)list[i];
            
            avg_b = (double)total_b / 3;

            Console.WriteLine("En Büyük 3 Sayının Ortalama Toplamları: " + total_b);
            Console.WriteLine("En Büyük 3 Sayının Ortalaması: " + avg_b);
        }
    }
}