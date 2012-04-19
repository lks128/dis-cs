using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_PZ_6_2
{
    public class Program
    {

        public static double ln_taylor(double x, double d_точность, int i_максимумИтераций)
        {
            double ln = 1/x;
            double d_элемент = 1/x;
            int i_итерация = 0;
            int n = 0;

            while ((Math.Abs(d_элемент) > d_точность) && (i_итерация <= i_максимумИтераций))
            {
                d_элемент *= (2 * n + 1.0) / (2 * n + 3.0) / (x * x);
                ln += d_элемент;
                i_итерация += 1;
                n += 1;
            }

            return (i_итерация > i_максимумИтераций) ? Double.NaN : 2 * ln;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(ln_taylor(3, 0.0001, 1));
            //Console.WriteLine(Math.Log((3+1)/(3-1)));
            //return;

            bool b_работа = true;

            double d_минимум = Double.NaN;
            double d_максимум = Double.NaN;
            int i_максимумИтераций = 0;
            double d_шаг = Double.NaN;
            double d_точность = Double.NaN;

            Console.WriteLine("Вывод меню: пустой ввод, или ?");

            while (b_работа)
            {
                Console.Write("\n> ");

                try
                {
                    switch (Console.ReadLine())
                    {
                        case "":
                        case "?":
                            Console.WriteLine("Меню:\n" +
                                "  1 - ввод минимального значения x\n" +
                                "  2 - ввод максимального значения x\n" +
                                "  3 - ввод шага изменения x\n" +
                                "  4 - ввод максимального числа итераций n4\n" +
                                "  5 - ввод требуемой точности\n" +
                                "  6 - расчет значений функции\n" +
                                "  Q - Завершение работы\n");
                            break;
                        case "Q":
                        case "q":
                            b_работа = false;
                            break;

                        case "1":
                            Console.Write("Введите минимальное значение х: ");
                            d_минимум = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "2":
                            Console.Write("Введите максимальное значение х: ");
                            d_максимум = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "3":
                            Console.Write("Введите шаг изменения х: ");
                            d_шаг = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "4":
                            Console.Write("Введите максимальное число итераций: ");
                            i_максимумИтераций = Convert.ToInt32(Console.ReadLine());
                            break;

                        case "5":
                            Console.Write("Введите требуемую точность: ");
                            d_точность = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "6":
                            if (Double.IsNaN(d_максимум) || Double.IsNaN(d_минимум) ||
                                Double.IsNaN(d_шаг) || Double.IsNaN(d_точность))
                            {
                                throw new ApplicationException("Введены не все значения.");
                            }

                            Console.WriteLine("x\tmath\ttaylor");

                            for (double x = d_минимум; Math.Abs(x - d_максимум) > 1e-6; x += d_шаг)
                            {
                                Console.WriteLine("{0}\t{1}\t{2}", x, Math.Log((x+1)/(x-1)),
                                    ln_taylor(x, d_точность, i_максимумИтераций));
                            }

                            break;

                        default:
                            throw new ApplicationException("Введен неверный пункт меню.");
                    }
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine("Произошел сбой программы: {0}", e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неожиданный сбой: " + e.Message);
                    Console.WriteLine("Повторите попытку.");
                }

            }

        }
    }
}
