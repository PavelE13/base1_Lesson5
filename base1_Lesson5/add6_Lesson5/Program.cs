using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add6_Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация переменных, массивов
            Console.WriteLine(" Введите целочисленное значение N для формирования 2-х мерного массива NxN");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            int[,] array = new int[n, m];
            int magNumber = 0; //сумма стороны квадрата, нач.знач
            //var summ3 = 0, summ4 = 0;
            bool flag = true;
            #region // Ввод матрицы с отображением в столбик
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" Значение  индекса {0},{1} = ", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.Write(" Массив введен! ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" {0,4} ", array[i, j]);
                }
                Console.WriteLine();
            }
            #endregion
            #region // Проверка магического квадрата
            // сумма первой строки
            for (int i = 0; i < n; i++)
                magNumber += array[i, 0];
            // сумма по строкам
            for (int i = 0; i < n; i++)
            {
                var summ1 = 0;
                for (int j = 0; j < m; j++)
                {
                    summ1 += array[i, j];
                }
                if (summ1 != magNumber)
                {
                    flag = false;
                }
            }
            // сумма по столбцам
            for (int j = 0; j < m; j++)
            {
                var summ2 = 0;
                for (int i = 0; i < n; i++)
                {
                    summ2 += array[i, j];
                }
                if (summ2 != magNumber)
                {
                    flag = false;
                }
            }
            // сумма по диагонали 1
            var summ3 = 0;
            for (int i = 0; i < n; i++)
            {
                summ3 += array[i, i];
            }
            if (summ3 != magNumber)
            {
                flag = false;
            }
            // сумма по диагонали 2
            var summ4 = 0;
            for (int i = 0; i < n; i++)
            {
                summ4 += array[i, n - i - 1];
            } 
            if (summ4 != magNumber)
            {
                flag = false;
            }
            #endregion
            if (flag)
            {
                Console.WriteLine(" Есть магический квадрат! {0}", flag);
            }
            else
            {
                Console.WriteLine(" Нет магического квадрата. {0}", flag);
            }
            Console.ReadKey();
        }
    }
}