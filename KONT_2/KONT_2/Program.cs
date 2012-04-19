/*
 * Номер контрольной работы: 2
 * Номер задачи: 1
 * Номер варианта: 2 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace KONT_2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool b_работать = true;

            while (b_работать)
            {
                // вывод меню
                Console.Write("Меню:\n" +
                    "  1 - Ввод с консоли\n" +
                    "  2 - Ввод из файла\n" +
                    "  3 - Выход\n" +
                    "Ваш выбор: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        // ввод числа и расчет значения функции
                        Console.Write("Введите число а: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        double y = Double.NaN;

                        if (a < 2.0)
                        {
                            y = 2 * Math.Sin(a);
                        }
                        else if ((a >= 2.0) && (a < 3.5))
                        {
                            y = Math.Tan(3 * a);
                        }
                        else if ((a >= 3.5) && (a <= 4.5))
                        {
                            y = Math.Pow(Math.Cos(a), 2) + Math.Pow(Math.Cos(a), 4);
                        }
                        else
                        {
                            y = Math.Pow(Math.Cos(a), 3) + Math.Pow(Math.Sin(a), 3);
                        }

                        // вывод результата
                        Console.WriteLine("Подсчитанное значение функции: {0}\n", y);

                        break;
                    case "2":
                        StreamReader sr = new StreamReader("../../input.txt");

                        Console.WriteLine("\ta\t\ty");

                        // ввод данных в цикле до тех пор, пока не будет
                        // достигнут конец файла
                        while(!sr.EndOfStream)
                        {
                            double a2 = Convert.ToDouble(sr.ReadLine());
                            double y2 = Double.NaN;

                            if (a2 < 2.0)
                            {
                                y2 = 2 * Math.Sin(a2);
                            }
                            else if ((a2 >= 2.0) && (a2 < 3.5))
                            {
                                y2 = Math.Tan(3 * a2);
                            }
                            else if ((a2 >= 3.5) && (a2 <= 4.5))
                            {
                                y2 = Math.Pow(Math.Cos(a2), 2) + Math.Pow(Math.Cos(a2), 4);
                            }
                            else
                            {
                                y2 = Math.Pow(Math.Cos(a2), 3) + Math.Pow(Math.Sin(a2), 3);
                            }

                            // вывод результата
                            Console.WriteLine("\t{0:F1}\t\t{1}", a2, y2);
                        }

                        sr.Close();
                        break;
                    case "3":
                        b_работать = false;
                        break;
                    default:
                        Console.WriteLine("Введите корректный пункт меню.\n");
                        break;
                }
                //// switch end

            }
            //// while end

        }
    }
}
