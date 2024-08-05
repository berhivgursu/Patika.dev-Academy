using System;

namespace ex_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            uint m = uint.Parse(Console.ReadLine());

            uint[] dizi = new uint[n];
            
            for (int i = 0; i < n; i++)
            {
                dizi[i] = uint.Parse(Console.ReadLine());
            }

            for (int j = 0; j < dizi.Length; j++)
            {
                if (dizi[j] == m || dizi[j] % m  == 0)
                    Console.WriteLine(dizi[j]);
            }
        }
    }
}
