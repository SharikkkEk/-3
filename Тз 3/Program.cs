using System;
using System.Linq;
using System.Collections.Generic;

namespace Простой_поиск
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 4, 5, 65, 78, 990, 99, 23, 34 };
            Console.Write("Изначальный массив - ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            List<int> all_even_numbers = new List<int>();
            List<int> all_not_even_numbers = new List<int>();
            int even_numbers = 0;
            int not_even_numbers = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] % 2) == 0)
                {
                    even_numbers += a[i];
                    all_even_numbers.Add(a[i]);
                }
                else
                {
                    not_even_numbers += a[i];
                    all_not_even_numbers.Add(a[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма нечётных чисел массива - {not_even_numbers}, Сумма чётных чисел массива - {even_numbers}");
            int max = a.Max();
            int min = a.Min();
            Zamena(max, min, a);
            Console.WriteLine();
            Console.Write("Минимальный и максимальный элементы поменяты местами: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            int max_not_even = all_not_even_numbers.Max();
            int min_not_even = all_not_even_numbers.Min();
            Console.WriteLine($"Максимальный нечетный элемент массива - {max_not_even}");
            Console.WriteLine();
            Console.WriteLine($"Минимальный нечетный элемент массива - {min_not_even}");
            Console.ReadKey();
        }
        static void Zamena(int max, int min, int[] c)
        {
            int g = Array.IndexOf(c, max);
            int j = Array.IndexOf(c, min);
            c[g] = min;
            c[j] = max;
        }
    }
}