using System;
using System.Collections;

namespace arraylist
{
    class Program
    {
        public static void Main(string[] args)
        {
            // System.Collections namespace

            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            // içerisinde verilere erişim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
                Console.WriteLine(item);
            

            // AddRange
            string[] renkler = {"kirmizi", "sari", "yesil"};
            List<int> sayilar = new List<int>(){1, 8, 3, 7, 9, 92, 5};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);
            
            // Sort
            liste.Sort();

            foreach (var item in liste)
                Console.WriteLine(item);

            // Binary Search
            Console.WriteLine(liste.BinarySearch(9));

            // Reverse
            liste.Reverse();

            foreach (var item in liste)
                Console.WriteLine(item);

            // Clear
            liste.Clear();

            foreach (var item in liste)
                Console.WriteLine(item);
        }
    }
}