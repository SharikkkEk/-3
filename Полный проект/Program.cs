using System;
using System.Linq;
using System.Collections.Generic;

namespace Полный_проект
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 2; i > 0; i--)
            {
                for (int j = 2; j > 2 - i; j--)
                {
                    m_massive_2[i, j] = 0;
                }
            }
            for (int i = 2; i != 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    m_massive_2[i, j] = 0;
                }
            }
        }

        public static void SomeWork(object state)
        {
            Console.WriteLine("work");
        }
    }
}
