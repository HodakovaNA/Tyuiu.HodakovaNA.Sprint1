using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovaNA.Sprint1.Task7.V12.Lib;

namespace Tyuiu.HodakovaNA.Sprint1.Task7.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            //Написать программу, которая вычисляет математическое выражение по исходным значениям данных,
            //вводимых пользователем. Ответ округлите до 3 знаков после запятой.

            Console.Title = "Спринт #1 | Выполнила Ходакова Н.А. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                       *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                                                *");
            Console.WriteLine("* Задание #7                                                                                      *");
            Console.WriteLine("* Вариант #12                                                                                     *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУб-23-1                                             *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных,    *");
            Console.WriteLine("* вводимых пользователем. Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("* Пример: z = ((x + 1)/(x - 1))^2 + 18 * x * y^2                                                   *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadKey();


        }
    }
}