using System;
using System.Collections;

namespace Soru_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ArrayList vowels = new ArrayList();

            string vowels_character = "aeıioöuüAEIİOÖUÜ";

            foreach (char item in input)
            {
                if (vowels_character.Contains(item))
                    vowels.Add(item);
            }
            vowels.Sort();

            foreach (char item in vowels)
                Console.WriteLine(item + " ");

            if (vowels.Count == 0)
                Console.WriteLine("Cümlede sesli harf bulunamadı.");
            else
                Console.WriteLine("\nToplam sesli harf sayısı: " + vowels.Count);
        }
    }
}