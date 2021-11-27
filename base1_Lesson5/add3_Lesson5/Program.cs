using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add3_Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region // объявление и инициализация переменных, констант
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            int[] array5Up = new int[5];
            int[] array5Down = new int[5];
            #endregion
            Console.WriteLine(" Элементам массива присвоены значения случайных образом! ");// Преамбула
            Console.WriteLine();
            #region //Ввод массива случайным образом и создание дубликатов массива
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("  {0}  ", array[i]);
            }
            for (int i = 0; i < n-5; i++)
            {
                array5Up[i] = array[i]; // Дубликаты массивов для сортировки по возрастанию
            }
            for (int i = 0; i < n-5; i++)
            {
                array5Down[i] = array[i+4]; // Дубликаты массивов для сортировки по убыванию
            }
            #endregion
            Console.WriteLine();
            #region // Сравнение в дубликатах массивов array5Up и array5Down индексов и расстановка соответсвтвенно по возрастанию/убывнию
            for (int i = 0; i < n - 6; i++)
            {
                for (int k = i + 1; k < n - 5; k++)
                {
                    if (array5Up[i] > array5Up[k]) //условие по возрастанию
                    {
                        int t = array5Up[i];
                        array5Up[i] = array5Up[k];
                        array5Up[k] = t;
                    }
                    if (array5Down[i] < array5Down[k])//условие по убыванию
                    {
                        int q = array5Down[i];
                        array5Down[i] = array5Down[k];
                        array5Down[k] = q;
                    }
                }
            }
            #endregion
            #region // Вывод массивов отсортированных по возрастанию/убыванию
            Console.WriteLine();
            Console.WriteLine( " Первые 5 элементов по возрастанию ");
            for (int i = 0; i < n-5; i++) // по возрастанию
            {
                Console.Write("  {0}  ", array5Up[i]);
            }
            Console.WriteLine();
            Console.WriteLine(" Последние 5 элементов по убыванию ");
            for (int i = 0; i < n - 5; i++) // по убыванию
            {
                Console.Write("  {0}  ", array5Down[i]);
            }
            #endregion
            Console.ReadKey();
        }
    }
          
}
