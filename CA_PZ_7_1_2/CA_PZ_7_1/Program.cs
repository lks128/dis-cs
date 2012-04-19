﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_PZ_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b_работать = true;
            Часы1 v_часы = null;

            while (b_работать)
            {
                Console.Write("\nВведите пункт меню (5 - вывод меню): ");

                try
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Write("Введите количество часов: ");
                            v_часы = new Часы1(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine(v_часы);
                            break;
                        case "2":
                            if (v_часы == null)
                            {
                                throw new ApplicationException("Экземпляр часов не был инициализирован.");
                            }

                            Console.Write("Введите новое количество часов [{0}]: ", v_часы.Час);
                            string r = Console.ReadLine();
                            if (r != "") { v_часы.Час = Convert.ToInt32(r); }
                            Console.WriteLine(v_часы);
                            break;
                        case "3":
                            if (v_часы == null)
                            {
                                throw new ApplicationException("Экземпляр часов не был инициализирован.");
                            }

                            Console.Write("Часов вперед: ");
                            string r2 = Console.ReadLine();
                            v_часы.ПеревестиВперед(Convert.ToInt32(r2));
                            Console.WriteLine(v_часы);
                            break;
                        case "4":
                            Console.WriteLine("Количество обращений к конструктору: {0}",
                                Часы1.КоличествоОбращений);
                            Console.WriteLine("Название: {0}", Часы1.S_Название);

                            if (v_часы == null)
                            {
                                throw new ApplicationException("Экземпляр часов не был инициализирован.");
                            }

                            Console.WriteLine(v_часы);
                            break;
                        case "5":
                            Console.WriteLine("Меню:\n" +
                                "  1 - Создать объект класса Часы\n" +
                                "  2 - Установить значение часа\n" +
                                "  3 - Перевести на n часов вперед\n" +
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
