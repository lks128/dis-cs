using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_PZ_8_2
{
    class Program
    {
        static void Рассчитать(double a, out double z1, out double z2)
        {
            z1 = Math.Cos(a) + Math.Sin(a) + Math.Cos(3 * a) + Math.Sin(3 * a);
            z2 = 1.0 / 4.0 - 1.0 / 4.0 * Math.Sin(5.0 / 2.0 * Math.PI - 8 * a);
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
                    double z1, z2;

                    Program.Рассчитать(a, out z1, out z2);

                    Console.WriteLine("Z1 = {0}\nZ2 = {0}", z1, z2);
                }
            }
        }
    }
}
