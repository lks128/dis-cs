using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CA_LEC_6
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                try
                {
                    Console.Write("\nМеню:\n" +
                        "  1 - Ввод данных\n" +
                        "  2 - Выход из программы\n\n" +
                        "Выберите пункт меню:\n" +
                        "> ");

                    string a = Console.ReadLine();

                    switch(a)
                    {
                        case "1":
                            Console.Write("\nВведите действительное число: ");
                            double f = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Данные введены успешно");
                            break;
                        case "2":
                            throw new ApplicationException("exit");
                        default:
                            throw new Exception(); // catch {} по умолчанию ловит исключения класса Exception
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введенные данные имеют неверный формат");
                }
                catch (ApplicationException e)
                {
                    if (e.Message == "exit")
                    {
                        Console.WriteLine("\nПолучен сигнал завершения работы");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("В программе произошел сбой. Пожалуйста, повторите попытку.");
                }

            }

        }
    }
}
