using System;
using System.Linq;


namespace bebrus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 6, 5, 4, 3, 1, 0, 7, 10, 12, 54, 34, 100 };
            int max = 0;
            int min = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                max = mass[0];
                min = mass[0];
                if (mass[i] > max) { max = mass[i]; }
                if (mass[i] < min) { min = mass[i]; }
                for (int j=0; j< mass.Length - 1; j++)
                {
                    if (mass[j] > mass[j + 1])
                    {
                        int a = mass[j + 1];
                        mass[j + 1] = mass[j];
                        mass[j] = a;
                    }
                }
            }
            for (int i=0; i< mass.Length; i++)
            {
                Console.WriteLine($"{mass[i]}");
            }
            Console.WriteLine();
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
        }
    }
}