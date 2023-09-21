﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovaNA.Sprint1.Task2.V13.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.
//Формулировка задания: Известно расстояние в милях. Вычислить расстояние в километрах.
//Что пользователь вводит? Расстояние в милях (целое число)
//Что программа печатает на экране? Расстояние в километрах (вещественное число)

namespace Tyuiu.HodakovaNA.Sprint1.Task2.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила Ходакова Н.А. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                       *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                                                *");
            Console.WriteLine("* Задание #2                                                                                      *");
            Console.WriteLine("* Вариант #13                                                                                     *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУб-23-1                                             *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет               *");
            Console.WriteLine("* указанные расчёты и печатает результат на экране.                                               *");
            Console.WriteLine("*                                                                                                 *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            int x;

            Console.WriteLine("Введите кол-во миль для конвертации в километры:                                                  *");
            
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("Конвертированное значение количества миль в километры: " + Convert.ToInt32(1609 * x) + " км.");
            Console.ReadLine();

        }
    }
}
