using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base4_Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region // объявление и инициализация переменных, констант
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            int s = 0;
            #endregion
            Console.WriteLine(" Элементам массива присвоены значения случайных образом! ");// Преамбула
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("  {0}  ", array[i]);
              
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (array[i]% 2==1)
                {
                    s++;
                    Console.WriteLine("  Нечетные элементы массива {  0  }", array[i]);
                }
            }

            Console.WriteLine("  Количество нечентных элементов массива {  0  }", s);
            Console.ReadKey();
        }
    }
}