using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.HodakovaNA.Sprint1.Task1.V.Lib
{
    public class DataService : ISprint1Task1V27
    {
        public double Calculate(double x, double y)
        {
            return (x + y) / 2;
        }
    }
}