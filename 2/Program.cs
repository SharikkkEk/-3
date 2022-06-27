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
        static void MyMassiveP() 
        {
            Console.Clear();
            Console.WriteLine("Введите количество столбиков");
            int x = int.Parse(Console.ReadLine());
            int[][] s_massive = new int[x][];
            for (int i = 0; i < s_massive.Length; i++)
            {
                Console.WriteLine($"Введите длину {i + 1} строки");
                int y = int.Parse(Console.ReadLine());
                s_massive[i] = new int[y];
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine($"Введите {j + 1} элемент");
                    s_massive[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < s_massive.Length; i++)
            {
                for (int j = 0; j < s_massive[i].Length; j++)
                {
                    Console.Write(s_massive[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите x");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Все числа массива, что меньше x и выше побочной диагонали: ");
            for (int i = 0; i < s_massive.Length - 1; i++)
            {
                for (int l = 0; l < s_massive[i].Length - 1 - i; l++)
                {
                    if (s_massive[i][l] < k)
                    {
                        Console.Write(s_massive[i][l] + " ");
                    }
                }
            }
            ContinueSMassive();
        }
        static void MyMassiveG() 
        {
            Console.Clear();
            Console.WriteLine("Введите количество столбиков");
            int x = int.Parse(Console.ReadLine());
            int[][] s_massive = new int[x][];
            for (int i = 0; i < s_massive.Length; i++)
            {
                Console.WriteLine($"Введите длину {i+1} строки");
                int y = int.Parse(Console.ReadLine());
                s_massive[i] = new int[y];
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine($"Введите {j+1} элемент");
                    s_massive[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < s_massive.Length; i++)
            {
                for (int j = 0; j < s_massive[i].Length; j++)
                {
                    Console.Write(s_massive[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите x");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < s_massive.Length - 1; i++)
            {
                for (int l = s_massive[i].Length - 1; l > i; l--)
                {
                    if (s_massive[i][l] < k)
                    {
                        s_massive[i][l] = 0;
                    }
                }
            }
            Console.WriteLine("Обнулены все элементы массива, что меньше x и выше главной диагонали");
            for (int i = 0; i < s_massive.Length; i++)
            {
                for (int j = 0; j < s_massive[i].Length; j++)
                {
                    Console.Write(s_massive[i][j] + " ");
                }
                Console.WriteLine();
            }
            ContinueSMassive();
        }
        static void ContinueSMassive()
        {
            Console.WriteLine("Что делать дальше?");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("1 - Cоздать свой массив и обнулить числа, которые меньше x и выше главной диагонали");
            Console.WriteLine("2 - Cоздать свой массив и вывести числа, которые меньше x и выше побочной диагонали");
            Console.WriteLine("3 - Вызвать изначальное меню");
            Console.WriteLine("=========================================================================");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    MyMassiveG();
                    break;
                case ConsoleKey.D2:
                    MyMassiveP();
                    break;
                case ConsoleKey.D3:
                    Main();
                    break;
                default:
                    Super_Massive();
                    break;
            }
        }
        static void Super_Massive() 
        {
            Console.Clear();
            Console.WriteLine("Что делать дальше?");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("1 - Cоздать свой массив и обнулить числа, которые меньше x и выше главной диагонали");
            Console.WriteLine("2 - Cоздать свой массив и вывести числа, которые меньше x и выше побочной диагонали");
            Console.WriteLine("=========================================================================");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    MyMassiveG();
                    break;
                case ConsoleKey.D2:
                    MyMassiveP();
                    break;
                default:
                    Super_Massive();
                    break;
            }
        }
        static void ContinueMMass()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Что делать дальше?");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("1 - Поменять местами 1-ую и 3-ю строку массива");
            Console.WriteLine("2 - Найти сумму всех двузначных элементов");
            Console.WriteLine("3 - Найти сумму всех элементов, кратных 5");
            Console.WriteLine("4 - Поменять местами элементы 1-го и 3-го столбцов");
            Console.WriteLine("5 - Обнулить элементы ниже главной диагонали");
            Console.WriteLine("6 - Обнулить элементы выше главной диагонали");
            Console.WriteLine("7 - Обнулить элементы ниже побочной диагонали");
            Console.WriteLine("8 - Обнулить элементы выше побочной диагонали");
            Console.WriteLine("9 - Вызов изначального меню");
            Console.WriteLine("=========================================================================");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    PomMestStroki();
                    break;
                case ConsoleKey.D2:
                    SumDvuzn();
                    break;
                case ConsoleKey.D3:
                    SumEl5();
                    break;
                case ConsoleKey.D4:
                    PomMestStolb();
                    break;
                case ConsoleKey.D5:
                    ObnNizhGl();
                    break;
                case ConsoleKey.D6:
                    ObnVishGl();
                    break;
                case ConsoleKey.D7:
                    ObnNizhPob();
                    break;
                case ConsoleKey.D8:
                    ObnVishPob();
                    break;
                case ConsoleKey.D9:
                    Main();
                    break;
                default:
                    ContinueMMass();
                    break;
            }
        }
        static void ObnVishPob()
        {
            Console.WriteLine("Оригинальный массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m_massive[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] m_massive_2 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m_massive_2[i, j] = m_massive[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2 - i; j++)
                {
                    m_massive_2[i, j] = 0;
                }
            }
            Console.WriteLine("Обнулены элементы выше побочной диагонали");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m_massive_2[i, j] + " ");
                }
                Console.WriteLine();
            }
            ContinueMMass();
        }
        static void ObnNizhPob()
        {
            Console.WriteLine("Оригинальный массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m_massive[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] m_massive_2 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m_massive_2[i, j] = m_massive[i, j];
                }
            }
            for (int i = 2; i > 0; i--)
            {
                for (int j = 2; j > 2 - i; j--)
                {
                    m_massive_2[i, j] = 0;
                }
            }
            Console.WriteLine("Обнулены элементы ниже побочной диагонали");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m_massive_2[i, j] + " ");
                }
                Console.WriteLine();
            }
            ContinueMMass();
        }
        static void ObnVishGl()
        {
            Console.WriteLine("Оригинальный массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m_massive[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] m_massive_2 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m_massive_2[i, j] = m_massive[i, j];
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 2; j > 0 + i; j--)
                {
                    m_massive_2[i, j] = 0;
                }
            }
            Console.WriteLine("Обнулены элементы выше главной диагонали");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m_massive_2[i, j] + " ");
                }
                Console.WriteLine();
            }
            ContinueMMass();
        }
        static void ObnNizhGl()
        {
            Console.WriteLine("Оригинальный массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m_massive[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] m_massive_2 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m_massive_2[i, j] = m_massive[i, j];
                }
            }
            for (int i = 2; i != 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    m_massive_2[i, j] = 0;
                }
            }
            Console.WriteLine("Обнулены элементы ниже главной диагонали");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m_massive_2[i, j] + " ");
                }
                Console.WriteLine();
            }
            ContinueMMass();
        }
        static void PomMestStolb()
        {
            Console.WriteLine("Оригинальный массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m_massive[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] m_massive_2 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m_massive_2[i, j] = m_massive[i, j];
                }
            }
            List<int> stolb_1 = new List<int>();
            List<int> stolb_3 = new List<int>();
            for (int i = 0; i < m_massive.GetLength(1); i++)
            {
                stolb_1.Add(m_massive[i, 0]);
            }
            for (int i = 0; i < m_massive.GetLength(1); i++)
            {
                stolb_3.Add(m_massive[i, 2]);
            }
            for (int i = 0; i < 3; i++)
            {
                m_massive_2[i, 2] = stolb_1[i];
            }
            for (int i = 0; i < 3; i++)
            {
                m_massive_2[i, 0] = stolb_3[i];
            }
            Console.WriteLine("Поменяты местами 1-ый и 3-ий столбы:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m_massive_2[i, j] + " ");
                }
                Console.WriteLine();
            }
            ContinueMMass();
        }
        static void SumEl5()
        {
            Console.WriteLine("Оригинальный массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m_massive[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sum_5 = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (m_massive[i, j] % 5 == 0)
                    {
                        sum_5 += m_massive[i, j];
                    }
                }
            }
            Console.WriteLine($"Cумма всъ элементов массива, кратных 5: {sum_5}");
            ContinueMMass();
        }
        static void SumDvuzn()
        {
            Console.WriteLine("Оригинальный массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m_massive[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (m_massive[i, j] > 9 && m_massive[i, j] < 100)
                    {
                        sum += m_massive[i, j];
                    }
                }
            }
            Console.WriteLine($"Сумма всех двузначных элементов массива: {sum}");
            ContinueMMass();
        }
        static void PomMestStroki()
        {
            Console.Clear();
            Console.WriteLine("Оригинальный массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m_massive[i, j] + " ");
                }   
                Console.WriteLine();
            }
            int[,] m_massive_2 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m_massive_2[i, j] = m_massive[i, j];
                }
            }
            List<int> strok_1 = new List<int>();
            List<int> strok_3 = new List<int>();
            for (int i = 0; i < m_massive.GetLength(1); i++)
            {
                strok_1.Add(m_massive[0, i]);
            }
            for (int i = 0; i < m_massive.GetLength(1); i++)
            {
                strok_3.Add(m_massive[2, i]);
            }
            for (int i = 0; i < 3; i++)
            {
                m_massive_2[2, i] = strok_1[i];
            }
            for (int i = 0; i < 3; i++)
            {
                m_massive_2[0, i] = strok_3[i];
            }
            Console.WriteLine("Поменяты местами 1-ая и 3-я строки:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m_massive_2[i, j] + " ");
                }
                Console.WriteLine();
            }
            ContinueMMass();
        }
        static void MnogomerniyMassGenerate() 
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m_massive[i, j] = random.Next(0, 20);
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
            Console.WriteLine("6 - Обнулить элементы выше главной диагонали");
            Console.WriteLine("7 - Обнулить элементы ниже побочной диагонали");
            Console.WriteLine("8 - Обнулить элементы выше побочной диагонали");
            Console.WriteLine("=========================================================================");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    PomMestStroki();
                    break;
                case ConsoleKey.D2:
                    SumDvuzn();
                    break;
                case ConsoleKey.D3:
                    SumEl5();
                    break;
                case ConsoleKey.D4:
                    PomMestStolb();
                    break;
                case ConsoleKey.D5:
                    ObnNizhGl();
                    break;
                case ConsoleKey.D6:
                    ObnVishGl();
                    break;
                case ConsoleKey.D7:
                    ObnNizhPob();
                    break;
                case ConsoleKey.D8:
                    ObnVishPob();
                    break;
                default:
                    MnogomerniyMass();
                    break;
            }
        }
        static void ContinueOMass()
        {
            Console.WriteLine();
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
                    Super_Massive();
                    break;
                default:
                    Main();
                    break;
            }
        }
    }
}
