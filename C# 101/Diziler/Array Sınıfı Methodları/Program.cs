using System;

namespace Array_Sınfı_Methodları
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = {23, 12, 4, 86, 72, 3, 11, 17};

            // Sırasız Dizi
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            // Sıralı Dizi
            Array.Sort(sayiDizisi);
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            // Clear
            Array.Clear(sayiDizisi, 2, 2);
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            // sayiDizisi elemanlarını kullanarak 2. indexten itibaren iki tane elemanı sıfırlar.
            
            // Reverse
            Array.Reverse(sayiDizisi);
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            // IndexOf
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            // Resize
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);
        }
    }
}
