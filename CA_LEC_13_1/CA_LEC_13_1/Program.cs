using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_13_1
{
    class Program
    {
        delegate void Делегат();

        static void Main(string[] args)
        {
            Методы v_методы = new Методы();
            Делегат v_делегат = new Делегат(v_методы.Метод2);

            v_делегат += v_методы.Метод3;
            v_делегат += Методы.Метод4;
            v_делегат += v_методы.Метод2;

            Console.WriteLine("**** Вызов делегата ****");
            if (v_делегат != null) v_делегат();

            Console.WriteLine("\n**** Вызов делегата с удаленным методом ****");
            v_делегат -= v_методы.Метод2;
            if (v_делегат != null) v_делегат();
        }
    }
}
