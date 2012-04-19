using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_PZ_8_1
{
    class Program
    {
        static double Z1(double a)
        {
            return Math.Cos(a) + Math.Sin(a) + Math.Cos(3 * a) + Math.Sin(3 * a);
        }

        static double Z2(double a)
        {
            return 1.0 / 4.0 - 1.0 / 4.0 * Math.Sin(5.0 / 2.0 * Math.PI - 8 * a);
        }

        static void Main(string[] args)
        {
            bool b_работать = true;

            while (b_работать)
            {
                Console.WriteLine("Введите значение аргумента. Пустой ввод, чтобы выйти.");
                Console.Write("аргумент = ");

                string s_ввод = Console.ReadLine();

                if (s_ввод == "")
                {
                    b_работать = false;
                }
                else
                {
                    double a = Convert.ToDouble(s_ввод);
                    Console.WriteLine("Z1 = {0}\nZ2 = {0}", Z1(a), Z2(a));
                }
            }
        }
    }
}
