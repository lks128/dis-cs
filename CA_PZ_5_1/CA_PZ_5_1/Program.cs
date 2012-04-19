using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_PZ_5_1
{
    class Program
    {
        const double c_ДоверительныйИнтервал = 1e-6;

        static void Main(string[] args)
        {
            //---------------------------------- Объявление переменных
            bool b_работать = true;

            // так как числа еще не введены используем Double.NAN 
            double d_начальное = Double.NaN;
            double d_конечное = Double.NaN;
            double d_шаг = Double.NaN;

            string s_меню = "1 - ввод начального значения альфа\n" +
                "2 - конечного значения\n" +
                "3 - шага изменения\n" +
                "4 - вычисление заданных функций в заданном диапазоне и вывод в виде таблицы\n" +
                "5 - распечатка меню\n" +
                "6 - завершения работы программы\n";

            //---------------------------------- Цикл меню
            while (b_работать)
            {
                // Вывод приглашения на ввод пункта меню и ввод
                Console.WriteLine("Введите пункт меню. Распечатка меню - 5");
                string a = Console.ReadLine();

                // выполнение операций в зависимости от требуемого пункта
                switch (a)
                {
                    // Ввод начального значения
                    case "1":
                        Console.WriteLine("Введите начальное значение альфа: ");
                        d_начальное = Convert.ToDouble(Console.ReadLine());
                        break;

                    // Ввод конечного значения
                    case "2":
                        Console.WriteLine("Введите конечное значение альфа: ");
                        d_конечное = Convert.ToDouble(Console.ReadLine());
                        break;

                    // Ввод шага
                    case "3":
                        Console.WriteLine("Введите шаг значения альфа: ");
                        d_шаг = Convert.ToDouble(Console.ReadLine());
                        break;

                    // Рассчет таблицы
                    case "4":

                        // Проверка: были ли введены все требуемые значения
                        if (Double.IsNaN(d_конечное) ||
                            Double.IsNaN(d_начальное) ||
                            Double.IsNaN(d_шаг))
                        {
                            Console.WriteLine("Введены не все требуемые значения:\n"
                                + "d_минимум = {0}\n"
                                + "d_максимум = {1}\n"
                                + "d_шаг = {2}", d_начальное, d_конечное, d_шаг);
                            break;
                        }

                        // Подсчет значений функций и вывод на экран в виде таблицы
                        Console.WriteLine("a\t\tf1\t\tf2");
                        for (double d = d_начальное; d <= d_конечное + c_ДоверительныйИнтервал; d += d_шаг)
                        {
                            double f1 = Math.Cos(d) + Math.Sin(d) + Math.Cos(3*d) + Math.Sin(3*d);
                            double f2 = 2 * Math.Sqrt(2) * Math.Cos(d) * Math.Sin(Math.PI / 4 + 2 * d);
                            Console.WriteLine("{0:F4}\t\t{1:F4}\t\t{2:F4}", d, f1, f2);
                        }

                        break;

                    // Распечатка меню
                    case "5":
                        Console.WriteLine(s_меню);
                        break; 

                    // Реализация выхода из приложения
                    case "6":
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
