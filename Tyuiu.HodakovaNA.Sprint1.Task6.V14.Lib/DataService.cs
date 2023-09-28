using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.HodakovaNA.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            var russianLetters = new HashSet<char>();
            for (int i = 1040; i < 1072; i++)
            {
                //russianLetters.Add((char)i); // верхний регистр
                russianLetters.Add((char)(i + 32)); // нижний регистр
            }
                //russianLetters.Add((char)1025); // Ё
            russianLetters.Add((char)1105); // ё

            var res = value.Any(x => russianLetters.Contains(x));

            return res;
        }
    }
}
