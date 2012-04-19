using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_8
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Program p = new Program();

                do
                {
                    double a = p.ВвестиЧисло("а");
                    p.ВывестиРезультат(a);
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

        private void Z(double a, ref double z1, ref double z2)
        {
            double c = Math.Cos(a);
            double s = Math.Sin(a);

            z1 = (c + s) / (c - s);
            z2 = Math.Tan(2 * a) + 1.0 / Math.Pow(Math.Cos(a), 2);
        }

        public void ВывестиРезультат(double d_аргумент)
        {
            double z1 = 0;
            double z2 = 0;
            
            Z(d_аргумент, ref z1, ref z2);

            Console.WriteLine(">>> Значение функции z1 при a={0:F5} равно {1:F5}.",
                d_аргумент, z1);

            Console.WriteLine(">>> Значение функции z2 при a={0:F5} равно {1:F5}.",
                d_аргумент, z2);
        }
    }
}
