using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Soru_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList prime = new ArrayList();
            ArrayList non_prime = new ArrayList();
            
            int count = 0;

            while (count < 20)
            {
                Console.Write("Lütfen pozitif bir sayı giriniz: ");
                string input = Console.ReadLine();

                bool isNumeric = int.TryParse(input, out int number);
                if (number < 0 || !isNumeric)
                {
                    Console.WriteLine("HATA: LÜTFEN POZİTİF BİR SAYI GİRİNİZ");
                    continue;
                }

                if (IsPrime(number)) 
                    prime.Add(number);
                else 
                    non_prime.Add(number);
                
                count++;
            }
            Console.WriteLine("Asal Sayılar: ");
            PrintList(prime);

            Console.WriteLine("Asal Olmayan Sayılar: ");
            PrintList(non_prime);

            prime.Sort();
            prime.Reverse();
            
            non_prime.Sort();
            non_prime.Reverse();
            
            Console.WriteLine("Asal Sayıların Büyükten Küçüğe Sıralanışı: ");
            PrintList(prime);

            Console.WriteLine("Asal Olmayan Sayıların Büyükten Küçüğe Sıralanışı: ");
            PrintList(non_prime);
            
            int prime_total = 0;
            int non_prime_total = 0;
            
            double avg_prime;
            double avg_non_prime;

            foreach (int item in prime)
            {
                prime_total += item;
            }
            foreach (int item in non_prime)
            {
                non_prime_total += item;
            }

            avg_prime = prime_total / prime.Count;
            avg_non_prime = non_prime_total / non_prime.Count;

            Console.WriteLine("Asal Sayıların Eleman Sayısı: " + prime.Count);
            Console.WriteLine("Asal Olmayan Sayıların Eleman Sayısı: " + non_prime.Count);

            Console.WriteLine("Asal Sayıların Ortalaması: " + avg_prime);
            Console.WriteLine("Asal Olmayan Sayıların Ortalaması: " + avg_non_prime);
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;
            if (number == 2)
                return true;
            if ( number % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2) 
            {
                if (number % i == 0) 
                    return false;
            }

            return true;
        }

        static void PrintList(ArrayList list) 
        {
            foreach (int num in list) 
                Console.Write(num + " ");
        
            Console.WriteLine();
        }
    }
}