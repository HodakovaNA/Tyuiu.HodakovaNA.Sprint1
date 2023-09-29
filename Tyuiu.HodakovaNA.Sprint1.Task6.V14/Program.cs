using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovaNA.Sprint1.Task6.V14.Lib;

namespace Tyuiu.HodakovaNA.Sprint1.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            //Написать программу: пользователь вводит текст.
            //Проверить, что строка составлена только из строчных русских букв.

            Console.Title = "Спринт #1 | Выполнила Ходакова Н.А. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                       *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                                                *");
            Console.WriteLine("* Задание #6                                                                                      *");
            Console.WriteLine("* Вариант #14                                                                                     *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУб-23-1                                             *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                                                  *");
            Console.WriteLine("* Проверить, что строка составлена только из строчных русских букв.                               *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            string value;
            Console.WriteLine("* Введите текст:                                                                                *");
            value = Console.ReadLine();

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            bool res = ds.CheckLowerCaseRusLetters(value);
            Console.WriteLine(res);

            Console.ReadKey();


        }
    }
}