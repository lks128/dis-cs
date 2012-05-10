using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_13_1
{
    class Program
    {
        delegate void Делегат(int i);

        static void Main(string[] args)
        {
            Методы v_методы = new Методы();
            Делегат v_делегат = new Делегат(v_методы.Метод2);

            v_делегат += v_методы.Метод3;
            v_делегат += Методы.Метод4;
            v_делегат += v_методы.Метод2;

            Console.WriteLine("**** Вызов делегата с параметром i = 1 ****");
            if(v_делегат != null) v_делегат(1);

            Console.WriteLine("\n**** Вызов делегата с параметром i = 2 ****");
            if (v_делегат != null) v_делегат(2);

            Console.WriteLine("\n**** Вызов делегата с параметром i = 3 ****");
            if (v_делегат != null) v_делегат(3);
        }
    }
}
