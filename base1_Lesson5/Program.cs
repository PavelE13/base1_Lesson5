using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base1_Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region // объявление и инициализация переменных, констант
            const int n = 7;
            int[] array = new int[n];
            float summ = 0 , midle;
            #endregion
            Console.WriteLine(" Введите последовательно 7 элементов массива. Ввод осуществляется нажатием клавиши ENTER");// Преамбула
            #region // Ввод массива пользователем
            for (int i = 0; i < n; i++)
            {
                Console.Write(" Значение  индекса {0} = ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
                summ += array[i]; //сумма накопления элементоа массива
            }
            #endregion
            midle = summ / n;//Расчет среднего значения
            Console.WriteLine(  );
            Console.WriteLine(" Среднее значение = {0:f3}", midle);//Вывод среднего значания с точностью до 3 значений после зап.
            Console.ReadKey();
        }
    }
}
