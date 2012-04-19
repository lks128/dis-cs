using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Массив v_1 = new Массив(1, 2, 3, 4);
            Массив v_2 = new Массив(2, 3, 4, 5);

            Массив v_3 = v_1 + v_2;
            Массив v_4 = v_1 - v_2;
        }
    }
}
