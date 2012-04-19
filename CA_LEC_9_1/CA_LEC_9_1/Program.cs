using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ГенераторОдномерногоМассива v_генератор =
                new ГенераторОдномерногоМассива();

            bool b_работать = true;

            Console.WriteLine("Пустой ввод или 5 - вывод меню.");

            while (b_работать)
            {
                try
                {
                    Console.Write("\nВаш выбор: ");

                    switch (Console.ReadLine())
                    {
                        case "5":
                        case "":
                            Console.WriteLine(@"Меню:
  1-ввести размерность массива;
  2-ввести минимальное значение случайного числа;
  3-ввести максимальное значение случайного числа;
  4-сформировать массив и вывести на консоль;
  5-распечатка меню;
  6-завершение работы.
");
                            break;

                        case "1":
                            Console.Write("Введите размерность: ");
                            v_генератор.Размер = Convert.ToInt32(Console.ReadLine());
                            break;

                        case "2":
                            Console.Write("Введите минимальное значение: ");
                            v_генератор.Минимум = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "3":
                            // дублируем проверку из класса, чтобы получить сообщение об ошибке
                            // до начала ввода
                            if (Double.IsNaN(v_генератор.Минимум))
                                throw new ApplicationException("Введите сначала минимальное значение.");

                            Console.Write("Введите максимальное значение: ");
                            v_генератор.Максимум = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "4":
                            v_генератор.Сформировать();
                            v_генератор.ВывестиНаЭкран();
                            break;

                        case "6":
                            b_работать = false;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("ОШИБКА! ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

        }
    }
}
