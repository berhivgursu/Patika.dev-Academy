using System;

namespace ex_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            string[] dizi = new string[n];

            for (int i = 0; i < dizi.Length; i++)
            {
               dizi[i] = Console.ReadLine(); 
            }

            for (int i = dizi.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(dizi[i]);
            }
        }
    }
}