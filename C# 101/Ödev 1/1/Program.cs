using System;

namespace ex_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            uint[] dizi = new uint[n];
            
            int i = 0;
            while(i <= n - 1)
            {
                dizi[i] = uint.Parse(Console.ReadLine());
                i++;
            }

            int length = dizi.Length;
            for (int j = 0; j < length; j++)
            {
                if (dizi[j] % 2 == 0)
                    Console.WriteLine(dizi[j]);
            }
        }
    }
}
