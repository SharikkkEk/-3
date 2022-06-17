using System;
using System.Linq;
using System.Collections.Generic;

namespace Простая_сортировка
{
    class Program
    {
        public static int length = 8;
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] original_massive = new int[length];
            for (int i = 0; i < length; i++)
            {
                original_massive[i] = random.Next(0, 20);
            }
            Console.WriteLine("Оригинальный массив -");
            for (int i = 0; i < length; i++)
            {
                Console.Write(original_massive[i] + " ");
            }
            Console.WriteLine();
            List<int> list = new List<int>();
            List<int> list2 = list;
            for (int i = 0; i < length; i++)
            {
                list.Add(original_massive[i]);
            }
            int[] vozrostanie_massive = new int[length];
            int[] ubyvanie_massive = new int[length];
            int[] even_not_massive = new int[length];
            SortVozr(vozrostanie_massive, list);
            Console.WriteLine();
            SortUbyv(ubyvanie_massive, list2);
        }
        static void SortVozr(int[] b, List<int> c)
        {
            for (int i = 0; i < length; i++)
            {
                b[i] = c.Min();
                c.Remove(c.Min());
            }
            Console.WriteLine("Отсортировано по возрастанию - ");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
        }
        static void SortUbyv(int[] l, List<int> p)
        {
            for (int i = 0; i < length; i++)
            {
                l[i] = p.Max();
                p.Remove(p.Max());
            }
            Console.WriteLine("Отсортировано по убыванию - ");
            for (int i = 0; i < l.Length; i++)
            {
                Console.Write(l[i] + " ");
            }
        }
    }
}