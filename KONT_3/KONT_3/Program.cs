// Лякса Андрей
// Работа №3
// Вариант 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KONT_3
{
    class Program
    {
        static double СчитатьДействительноеЧисло()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        static int СчитатьЦелоеЧисло()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            bool b_работать = true;
            Комната v_комната = null;

            Console.WriteLine("1 - Распечатка меню");

            while (b_работать)
            {
                try
                {
                    Console.Write("\nВаш выбор: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine(@"
1 - Распечатать меню
2 - Создать комнату
3 - Выдать характеристики комнаты
4 - Завершение работы");
                            break;
                        case "2":
                            double d_длина, d_ширина, d_высота;
                            int i_количествоОкон;

                            Console.WriteLine("Введите параметры комнаты.");
                            Console.Write("  Длина: ");
                            d_длина = Program.СчитатьДействительноеЧисло();

                            Console.Write("  Ширина: ");
                            d_ширина = Program.СчитатьДействительноеЧисло();

                            Console.Write("  Высота: ");
                            d_высота = Program.СчитатьДействительноеЧисло();

                            Console.Write("  Количество окон: ");
                            i_количествоОкон = Program.СчитатьЦелоеЧисло();

                            v_комната = new Комната(d_длина, d_ширина, d_высота, i_количествоОкон);
                            break;
                        case "3":
                            if(v_комната == null)
                            {
                                throw new ApplicationException("Комната не была инициализирована.");
                            }

                            Console.WriteLine(v_комната.Паспорт());
                            break;
                        case "4":
                            b_работать = false;
                            break;
                        default:
                            throw new ApplicationException("Введен неверный пункт меню.");
                    }
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine("Произошла ошибка: {0}", e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Произошел сбой программы: {0}", e.Message);
                }
            }

        }
    }
}
