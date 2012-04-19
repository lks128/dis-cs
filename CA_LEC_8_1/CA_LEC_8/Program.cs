using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_8
{
    class Program
    {
        // статичные методы

        static double Z1(double a)
        {
            double c = Math.Cos(a);
            double s = Math.Sin(a);

            return (c+s)/(c-s);
        }

        static double Z2(double a)
        {
            return Math.Tan(2 * a) + 1.0/Math.Pow(Math.Cos(a),2);
        }

        static void Main(string[] args)
        {
            try
            {
                Program p = new Program();

                do
                {
                    double a = p.ВвестиЧисло("а");
                    p.ВывестиРезультат(Z1, a, "z1");
                    p.ВывестиРезультат(Z2, a, "z2");
                }
                while (p.НадоПродолжать());
            }
            catch (FormatException)
            {
                Console.WriteLine("\n!!! Произошла ошибка\n!!! Неверный формат введенных данных.\n" +
                    ">>> Проверьте правильность написания и повторите попытку.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\n!!! Произошла ошибка\n!!! {0}", e.Message + "\n>>> Повторите попытку...\n");
            }
        }


        // Конструктор класса
        public Program() { }

        public double ВвестиЧисло(string name)
        {
            Console.WriteLine(">>> Введите значение для переменной {0}", name);
            Console.Write("<<< ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public bool НадоПродолжать()
        {
            while (true)
            {
                Console.WriteLine(">>> Продолжить работу программы?");
                Console.Write("<<< ");
                switch (Console.ReadLine().First<char>())
                {
                    case 'д':
                    case 'Д':
                        return true;

                    case 'н':
                    case 'Н':
                        return false;

                    default:
                        Console.WriteLine("!!! Вы должны ввести или слово ДА или слово НЕТ.");
                        break;
                }
            }

        }

        public void ВывестиРезультат(Func<double, double> f_функция, double d_аргумент, string s_имя)
        {
            Console.WriteLine(">>> Значение функции {0} при a={1:F5} равно {2:F5}.", s_имя,
                d_аргумент, f_функция(d_аргумент));
        }
    }
}
