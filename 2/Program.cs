using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massives
{
    public class Program 
    {
        public static int[] o_massive = new int[8];
        public static Random random = new Random();
        public static int[,] m_massive = new int[3, 3];
        static void MnogomerniyMassGenerate() 
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m_massive[i, j] = random.Next();
                }
            }
        }
        static void MnogomerniyMass()
        {
            MnogomerniyMassGenerate();
            Console.WriteLine("Выберите паттерн действия");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("1 - Поменять местами 1-ую и 3-ю строку массива");
            Console.WriteLine("2 - Найти сумму всех двузначных элементов");
            Console.WriteLine("3 - Найти сумму всех элементов, кратных 5");
            Console.WriteLine("4 - Поменять местами элементы 1-го и 3-го столбцов");
            Console.WriteLine("5 - Обнулить элементы ниже главной диагонали");
            Console.WriteLine("6 - Выборка элементов");
            Console.WriteLine("7 - Выборка элементов");
            Console.WriteLine("8 - Выборка элементов");
            Console.WriteLine("=========================================================================");
        }
        static void ContinueOMass()
        {
            Console.WriteLine();
            Console.WriteLine("Что делать дальше?");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("1 - Простой поиск");
            Console.WriteLine("2 - Простая сортировка");
            Console.WriteLine("3 - Выборка элементов");
            Console.WriteLine("4 - Вызов изначального меню");
            Console.WriteLine("=========================================================================");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    SimpleSearch();
                    break;
                case ConsoleKey.D2:
                    SimpleSort();
                    break;
                case ConsoleKey.D3:
                    Viborka();
                    break;
                case ConsoleKey.D4:
                    Main();
                    break;
                default:
                    ContinueOMass();
                    break;
            }
        }
        static void Viborka()
        {
            Console.Clear();

            Console.WriteLine("Оригинальный массив -");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(o_massive[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("1 - вывод чётных элементов");
            Console.WriteLine("2 - вывод нечётных элементов");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    for (int i = 0; i < 8; i++)
                    {
                        if (o_massive[i] % 2 == 0)
                        {
                            Console.Write(o_massive[i] + " ");
                        }
                    }
                    break;
                case ConsoleKey.D2:
                    for (int i = 0; i < 8; i++)
                    {
                        if (o_massive[i] % 2 != 0)
                        {
                            Console.Write(o_massive[i] + " ");
                        }
                    }
                    break;
                default:
                    Console.Clear();
                    Viborka();
                    break;
            }

            Console.WriteLine();

            zeroing(o_massive);
            ContinueOMass();
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
        static void SimpleSort()
        {
            Console.Clear();
            Console.WriteLine("Оригинальный массив -");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(o_massive[i] + " ");
            }
            Console.WriteLine();
            List<int> list = new List<int>();
            RegenList(list);
            int[] vozrostanie_massive = new int[8];
            int[] ubyvanie_massive = new int[8];
            int[] even_not_massive = new int[8];
            SortVozr(vozrostanie_massive, list);
            Console.WriteLine();
            RegenList(list);
            SortUbyv(ubyvanie_massive, list);
            RegenList(list);
            Console.WriteLine();
            SortEven(even_not_massive, list);
            ContinueOMass();
        }
        static void SortVozr(int[] b, List<int> c)
        {
            for (int i = 0; i < 8; i++)
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
            for (int i = 0; i < 8; i++)
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
        static void RegenList(List<int> list)
        {
            for (int i = 0; i < 8; i++)
            {
                list.Add(o_massive[i]);
            }
        }
        static void SortEven(int[] l, List<int> p)
        {
            int a = 0;
            for (int i = 0; i < 8; i++)
            {
                if (p[i] % 2 == 0)
                {
                    l[a] = p[i];
                    a++;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (p[i] % 2 != 0)
                {
                    l[a] = p[i];
                    a++;
                }
            }
            Console.WriteLine("Отсортировано по чётным и нечётным числам");
            for (int i = 0; i < l.Length; i++)
            {
                Console.Write(l[i] + " ");
            }
        }
        static void Generate_Massive()
        {
            for (int i = 0; i < 8; i++)
            {
                o_massive[i] = random.Next(0, 20);
            }
            Console.Write("Изначальный массив - ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(o_massive[i] + " ");
            }
            Console.WriteLine();
        }
        static void Zamena(int max, int min, int[] c)
        {
            int g = Array.IndexOf(c, max);
            int j = Array.IndexOf(c, min);
            c[g] = min;
            c[j] = max;
        }
        public static void SimpleSearch()
        {
            Console.Clear();
            Console.Write("Изначальный массив - ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(o_massive[i] + " ");
            }
            Console.WriteLine();
            List<int> all_even_numbers = new List<int>();
            List<int> all_not_even_numbers = new List<int>();
            int even_numbers = 0;
            int not_even_numbers = 0;
            for (int i = 0; i < 8; i++)
            {
                if ((o_massive[i] % 2) == 0)
                {
                    even_numbers += o_massive[i];
                    all_even_numbers.Add(o_massive[i]);
                }
                else
                {
                    not_even_numbers += o_massive[i];
                    all_not_even_numbers.Add(o_massive[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма нечётных чисел массива - {not_even_numbers}, Сумма чётных чисел массива - {even_numbers}");
            int max = o_massive.Max();
            int min = o_massive.Min();
            Zamena(max, min, o_massive);
            Console.WriteLine();
            Console.Write("Минимальный и максимальный элементы поменяты местами: ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(o_massive[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            int max_not_even = all_not_even_numbers.Max();
            int min_not_even = all_not_even_numbers.Min();
            Console.WriteLine($"Максимальный нечетный элемент массива - {max_not_even}");
            Console.WriteLine();
            Console.WriteLine($"Минимальный нечетный элемент массива - {min_not_even}");
            ContinueOMass();
        }
        public static void OdnomerniyMassive()
        {
            Generate_Massive();
            Console.WriteLine("Выберите паттерн действия");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("1 - Простой поиск");
            Console.WriteLine("2 - Простая сортировка");
            Console.WriteLine("3 - Выборка элементов");
            Console.WriteLine("=========================================================================");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    SimpleSearch();
                    break;
                case ConsoleKey.D2:
                    SimpleSort();
                    break;
                case ConsoleKey.D3:
                    Viborka();
                    break;
                default:
                    Console.Clear();
                    OdnomerniyMassive();
                    break;
            }

        }
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("С каким массивом вы хотите работать?");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("                         W - Одномерный массив");
            Console.WriteLine("\nA - Двумерный массив(3-3)                     D - Двумерный массив(X-Y)");
            Console.WriteLine("=========================================================================");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.W:
                    Console.Clear();
                    OdnomerniyMassive();
                    break;
                case ConsoleKey.A:
                    Console.Clear();
                    MnogomerniyMass();
                    break;
                case ConsoleKey.D:
                    Console.WriteLine("D");
                    break;
                default:
                    Main();
                    break;
            }
        }
    }
}
