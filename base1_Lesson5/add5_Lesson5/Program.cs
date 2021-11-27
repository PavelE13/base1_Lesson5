using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add5_Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите целочисленное значение N для формирования 2-х мерного массива NxN");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            int[ , ] array = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(0, 2);
                    Console.Write(" {0,4} ", array[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}