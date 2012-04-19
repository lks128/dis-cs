using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_PZ_8_4
{
    class Program
    {
        static int СчитатьЧисло()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            bool b_работать = true;
            Счетчик v_счетчик = null;

            Console.WriteLine("Показать меню - пустой ввод.");

            while (b_работать)
            {
                Console.Write("\nВаш выбор: ");

                try
                {
                    switch (Console.ReadLine())
                    {
                        case "":
                            Console.WriteLine(@"1 - Установить начальное значение счетчика 
2 - Установить заданное значение счетчика 
3 - Увеличить значение счетчика на n
4 - Уменьшить значение счетчика на n
5 - Отобразить состояние счетчика
6 - Завершение работы");
                            break;
                        case "1":
                            v_счетчик = new Счетчик();
                            Console.WriteLine(v_счетчик);
                            break;
                        case "2":
                            Console.Write("Введите начальное значение счетчика: ");
                            v_счетчик = new Счетчик(СчитатьЧисло());
                            Console.WriteLine(v_счетчик);
                            break;
                        case "3":
                            Console.Write("Увеличить значение счетчика на: ");
                            int n = СчитатьЧисло();

                            if (v_счетчик.МожноУвеличитьНа(n))
                            {
                                for (int i = 0; i < n; i++)
                                {
                                    v_счетчик.Увеличить();
                                }
                            }
                            else
                            {
                                throw new ApplicationException("Значение счетчика не должно превышать 9999");
                            }

                            Console.WriteLine(v_счетчик);
                            break;
                        case "4":
                            Console.Write("Уменьшить значение счетчика на: ");
                            int k = СчитатьЧисло();

                            if (v_счетчик.МожноУменьшитьНа(k))
                            {
                                for (int i = 0; i < k; i++)
                                {
                                    v_счетчик.Уменьшить();
                                }
                            }
                            else
                            {
                                throw new ApplicationException("Значение счетчика не должно быть меньше 0");
                            }

                            Console.WriteLine(v_счетчик);
                            break;
                        case "5":
                            Console.WriteLine(v_счетчик);
                            break;
                        case "6":
                            b_работать = false;
                            break;
                        default:
                            throw new ApplicationException("Введен неверный пункт меню.");
                    }
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine("Произошла ошибка: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Произошел сбой программы: {0}", e.Message);
                }
            }
        }
    }
}
