using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovaNA.Sprint1.Task5.V5.Lib;

namespace Tyuiu.HodakovaNA.Sprint1.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            //Написать программу, которая решает следующую задачу:
            //Присвоить целой переменной d первую цифру из дробной части положительного
            //вещественного числа x(так, если x = 32.597, то d = 5).



            Console.Title = "Спринт #1 | Выполнила Ходакова Н.А. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                       *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                                                *");
            Console.WriteLine("* Задание #5                                                                                      *");
            Console.WriteLine("* Вариант #5                                                                                     *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУб-23-1                                             *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Присвоить целой переменной d первую цифру из дробной части положительного                       *");
            Console.WriteLine("* вещественного числа x (так, если x = 32.597, то d = 5).                                         *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ ( Вводить через ','):                                                           *");
            Console.WriteLine("***************************************************************************************************");

            double x;
            Console.Write("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine("d = " + ds.Calculate(x));

            Console.ReadKey();


        }
    }
}