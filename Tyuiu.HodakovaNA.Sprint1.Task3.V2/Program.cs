using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovaNA.Sprint1.Task3.V2.Lib;

// ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.
//Объявите необходимые переменные и напишите программу вычисления стоимости покупки, состоящей из нескольких тетрадей и карандашей. 
//Предполагается, что пользователь будет вводить данные о каждой составляющей покупки в отдельной строке: сначала цену, затем количество.

namespace Tyuiu.HodakovaNA.Sprint1.Task3.V2
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
            Console.WriteLine("* Задание #3                                                                                      *");
            Console.WriteLine("* Вариант #2                                                                                      *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУб-23-1                                             *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет               *");
            Console.WriteLine("* указанные расчёты и печатает результат на экране.                                               *");
            Console.WriteLine("*                                                                                                 *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            double priceNotebook;
            Console.WriteLine("Введите цену за одну тетрадь:                                                                     *");
            priceNotebook = Convert.ToInt32(Console.ReadLine());

            int amountNotebook;
            Console.WriteLine("Введите количество купленных тетрадей:                                                            *");
            amountNotebook = Convert.ToInt32(Console.ReadLine());

            double pricePencil;
            Console.WriteLine("Введите цену за одну ручку:                                                                       *");
            pricePencil = Convert.ToInt32(Console.ReadLine());

            int amountPencil;
            Console.WriteLine("Введите количество купленных ручек:                                                               *");
            amountPencil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИТОГОВАЯ СТОИМОСТЬ:                                                                             *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("К оплате:" + ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil) + " руб.");
            Console.ReadLine();

        }
    }
}
