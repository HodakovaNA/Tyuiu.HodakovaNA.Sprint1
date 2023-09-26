using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovaNA.Sprint1.Task4.V25.Lib;

namespace Tyuiu.PozhdinAA.Sprint1.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

        //Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле и печатает его на экране.
        //Ответ округлите до 3 знаков после запятой.
        //Формула: 1 - cos a
        //        -----------
        //          sin^2 a 



            Console.Title = "Спринт #1 | Выполнилf Ходакова Н.А. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                       *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                                                *");
            Console.WriteLine("* Задание #4                                                                                      *");
            Console.WriteLine("* Вариант #25                                                                                     *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУб-23-1                                             *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат     *");
            Console.WriteLine("* по формуле и печатает его на экране. Ответ округлите до 3 знаков после запятой.                 *");
            Console.WriteLine("* Формула: 1 - cos a                                                                              *");
            Console.WriteLine("*         -----------                                                                             *");
            Console.WriteLine("*           sin^2 a                                                                               *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            double a;
            Console.Write("Введите значение a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine("(1 - cos a) / (sin^2 a) = " + ds.Calculate(a));

            Console.ReadKey();


        }
    }
}