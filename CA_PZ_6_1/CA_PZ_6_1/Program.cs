using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_PZ_6_1
{
    public class Program
    {

        public static void cosh_taylor(out double d_результат, out int i_количествоИтераций,
            double x, double d_точность, int i_максимумИтераций)
        {
            double d_элемент = 1;
            int i_итерация = 0;
            int n = 0;

            d_результат = 1;

            while ((d_элемент > d_точность) && (i_итерация <= i_максимумИтераций))
            {
                d_элемент *= x * x / (2 * n + 1) / (2 * n + 2);
                d_результат += d_элемент;
                i_итерация += 1;
                n += 1;
            }

            i_количествоИтераций = i_итерация;

            if(i_итерация > i_максимумИтераций) 
            {
                d_результат = Double.NaN;
            }
        }
      
        static void Main(string[] args)
        {
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
                                double d_результат;
                                int i_количествоИтераций;

                                cosh_taylor(out d_результат, out i_количествоИтераций,
                                    x, d_точность, i_максимумИтераций);

                                Console.WriteLine("{0:F2}\t{1:F4}\t{2:F4}\t{3:D}",x, d_результат, Math.Cosh(x),
                                    Math.Abs(d_результат - Math.Cosh(x)), i_количествоИтераций);
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
