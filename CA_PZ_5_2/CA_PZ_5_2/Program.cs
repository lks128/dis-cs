using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_PZ_5_2
{
    class Program
    {
        private const double c_ДоверительныйИнтервал = 1e-6;

        static void Main(string[] args)
        {
            //---------------------------------- Объявление переменных
            bool b_работать = true;

            double d_r, d_начало, d_конец, d_шаг;
            d_r = d_начало = d_конец = d_шаг = Double.NaN;

            string s_меню = "1 - Ввод значения R\n" +
                "2 - Ввод начального значения x\n" +
                "3 - Ввод конечного значения x\n" +
                "4 - Ввод шага изменения\n" +
                "5 - Вычисление заданных функций в заданном диапазоне и вывод в виде таблицы\n" +
                "6 - Рачпечатка меню\n" +
                "7 - Завершение работы программы\n";

            //---------------------------------- Цикл меню
            while (b_работать)
            {
                // Вывод приглашения на ввод пункта меню и ввод
                Console.Write("Введите пункт меню. Распечатка меню - 6\n> ");
                string a = Console.ReadLine();

                // выполнение операций в зависимости от требуемого пункта
                switch (a)
                {
                    // Ввод значения R,
                    case "1":
                        Console.WriteLine("Введите значение R: ");
                        d_r = Convert.ToDouble(Console.ReadLine());
                        break;
                    //ввод начального значения x,
                    case "2":
                        Console.WriteLine("Введите начальное значение Х: ");
                        d_начало = Convert.ToDouble(Console.ReadLine());
                        break;
                    //конечного значения x,
                    case "3":
                        Console.WriteLine("Введите конечное значение Х: ");
                        d_конец = Convert.ToDouble(Console.ReadLine());
                        break;
                    //шага изменения,
                    case "4":
                        Console.WriteLine("Введите шаг значения Х: ");
                        d_шаг = Convert.ToDouble(Console.ReadLine());
                        break;
                    //вычисление заданных функций в заданном диапазоне и вывод в виде таблицы, 
                    case "5":

                        // Проверка: были ли введены все требуемые значения
                        if (Double.IsNaN(d_начало) ||
                            Double.IsNaN(d_конец) ||
                            Double.IsNaN(d_шаг) ||
                            Double.IsNaN(d_r))
                        {
                            Console.WriteLine("Введены не все требуемые значения:\n"
                                + "d_r = {0}\n"
                                + "d_минимум = {1}\n"
                                + "d_максимум = {2}\n"
                                + "d_шаг = {3}", d_r, d_начало, d_конец, d_шаг);
                            break;
                        }

                        Console.WriteLine("a\t\tf");
                        // В неравенство стоит добавить +- Epsillon
                        for (double x = d_начало; x < d_конец + c_ДоверительныйИнтервал; x += d_шаг)
                        {
                            double f;
                                                       if (x < -6 - d_r)
                            {
                                f = Double.NaN;
                            } 
                            else if ((-6 - d_r <= x) && (x < -6))
                            {
                                double d = Math.Abs(x - (-6));
                                f = -Math.Sqrt(d_r * d_r - d * d);
                            }
                            else if ((x >= -6) && (x < -3))
                            {
                                f = x + 3;
                            }
                            else if((x >= -3) && (x < 0))
                            {
                                double d = Math.Abs(x);
                                f = Math.Sqrt(d_r * d_r - d * d);
                            }
                            else if ((x >= 0) && (x < 3))
                            {
                                f = -x + 3;
                            }
                            else
                            {
                                f = (x - 3) / 2;
                            }

                            Console.WriteLine("{0:F4}\t\t{1:F4}", x, f);
                        }

                        break;

                    // Распечатка меню
                    case "6":
                        Console.WriteLine(s_меню);
                        break;

                    // Выход
                    case "7":
                        b_работать = false;
                        break;

                    default:
                        Console.WriteLine("Неверный пункт меню.");
                        break;
                }
            }
        }
    }
}
