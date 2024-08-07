using System;

namespace ex_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            string cumle = Console.ReadLine();
            
            int harf_sayac = 0;
            int kelime_sayac = 1;

             for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] == ' ')
                {
                    kelime_sayac++;
                }
                else
                {
                    harf_sayac++;
                }
            }

            Console.WriteLine("Harf Sayısı: " + harf_sayac);
            Console.WriteLine("Kelime Sayısı: " + kelime_sayac);
        }
    }
}
