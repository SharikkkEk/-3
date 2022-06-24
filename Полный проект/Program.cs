using System;
using System.Linq;
using System.Collections.Generic;

namespace Полный_проект
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] a = { 3, 4, 5 };
            Console.WriteLine(a.Length);
        }

        public static void SomeWork(object state)
        {
            Console.WriteLine("work");
        }
    }
}
