using System;
using System.Linq;
using System.Collections.Generic;

namespace Полный_проект
{
    class Program
    {
        public static void Main(string[] args)
        {
            // подождет 1с и вызовет SomeMethod 1 раз
            var t1 = new System.Threading.Timer(SomeWork, null, TimeSpan.FromSeconds(1), TimeSpan.Zero);
            // подождет 5с и будет вызывать SomeMethod раз в секунду
            var t2 = new System.Threading.Timer(SomeWork, null, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(1));
            Console.ReadKey();
        }

        public static void SomeWork(object state)
        {
            Console.WriteLine("work");
        }
    }
}
