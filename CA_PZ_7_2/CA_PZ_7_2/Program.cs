using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_PZ_7_2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool b_работать = true;
            Часы2 v_часы = new Часы2();

            while (b_работать)
            {
                Console.Write("\nВведите пункт меню (5 - вывод меню): ");

                try
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            v_часы = new Часы2();

                            Console.Write("Введите количество часов: ");
                            v_часы.Час = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Введите количество минут: ");
                            v_часы.Минута = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(v_часы);
                            break;
                        case "2":
                            Console.Write("Введите новое количество часов [{0}]: ", v_часы.Час);
                            v_часы.Час = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Введите новое количество минут [{0}]: ", v_часы.Минута);
                            v_часы.Минута = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(v_часы);
                            break;
                        case "3":
                            int h, m;

                            Console.Write("Часов вперед: ");
                            h = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Минут вперед: ");
                            m = Convert.ToInt32(Console.ReadLine());

                            v_часы.ПеревестиВперед(h, m);

                            Console.WriteLine(v_часы);
                            break;
                        case "4":
                            Console.WriteLine(v_часы);
                            break;
                        case "5":
                            Console.WriteLine("Меню:\n" +
                                "  1 - Создать объект класса Часы\n" +
                                "  2 - Установить значение часа и минуты\n" +
                                "  3 - Перевести на n часов и m минут вперед\n" +
                                "  4 - Отобразить время на часах\n" +
                                "  5 - Вывести меню\n" +
                                "  6 - Завершить работу");
                            break;
                        case "6":
                            b_работать = false;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Произошла ошибка: {0}", e.Message);
                }
            }

        }
    }
}
