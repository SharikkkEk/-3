using System;

namespace Выборка_элементов
{
    class Program
    {
        public static int[] original_massive = new int[8];
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 8; i++)
            {
                original_massive[i] = random.Next(0, 20);
            }

            Console.WriteLine("Оригинальный массив -");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(original_massive[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("1 - вывод чётных элементов");
            Console.WriteLine("2 - вывод нечётных элементов");

            int choice = int.Parse(Console.ReadLine());

            Write(choice, original_massive);

            Console.WriteLine();

            zeroing(original_massive);
        }
        static void Write(int a, int[] b)
        {
            if (a == 1)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (b[i] % 2 == 0)
                    {
                        Console.Write(b[i] + " ");
                    }
                }
            }
            if (a == 2)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (b[i] % 2 != 0)
                    {
                        Console.Write(b[i] + " ");
                    }
                }
            }
        }
        static void zeroing(int[] a)
        {
            for (int i = 0; i < 8; i++)
            {
                if (a[i] >= 10 && a[i] <= 99)
                {
                    a[i] = 0;
                }
            }
            Console.WriteLine("Двузначные элементы массива обнулены - ");
            for (int i = 0; i < 8; i++)
            {
                    Console.Write(a[i] + " ");
            }
        }
    }
}
