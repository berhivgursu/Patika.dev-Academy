using System;

namespace While_Foreach
{
    class Program
    {
        static void Main()
        {
            // While

            Console.WriteLine("Bir sayı giriniz:");

            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);
                character++;
            }

            // Foreach

            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};
            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
    }
}
