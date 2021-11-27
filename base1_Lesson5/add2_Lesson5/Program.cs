using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add2_Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region // объявление и инициализация переменных, констант
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            int max, min, summ;
            int[] arrayMax = new int[n]; 
            int [] arrayMin = new int[n];
            #endregion
            Console.WriteLine(" Элементам массива присвоены значения случайных образом! ");// Преамбула
            #region //Ввод массива случайным образом
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("  {0}  ", array[i]);
                arrayMax [i] = array[i]; // Дубликаты массивов для опред.макс
                arrayMin [i] = array[i]; // Дубликаты массивов для опред. мин
            }
            #endregion
            Console.WriteLine();
            min = array[1];// Принимаем за макс 1 элемент массива
            max = array[1];// Принимаем за мин 1 элемент массива
            foreach (int a in arrayMax)
            {
                if (a > max)
                {
                    max = a;
                }
            }
            Console.WriteLine(" Максимальный элемент массива = {0}.", max);
            foreach (int a in arrayMin)
            {
                if (a < min)
                {
                    min = a;
                }
            }
            Console.WriteLine(" Минимаьлный элемент массива = {0}.", min);
            summ = max + min;
                Console.WriteLine(" Сумма максимального и минимального элемента массива = {0}", summ);
            Console.ReadKey();
        }
    }
}
