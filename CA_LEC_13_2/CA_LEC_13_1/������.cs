using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_13_1
{
    class Методы
    {
        public void Метод1(int i)
        {
            Console.WriteLine("Выполняется тело метода 1 с параметром {0}...", i);
        }

        public void Метод2(int i)
        {
            Console.WriteLine("Выполняется тело метода 2 с параметром {0}...", i);
        }

        public void Метод3(int i)
        {
            Console.WriteLine("Выполняется тело метода 3 с параметром {0}...", i);
        }

        public static void Метод4(int i)
        {
            Console.WriteLine("Выполняется тело метода 4 с параметром {0}...", i);
        }
    }
}
