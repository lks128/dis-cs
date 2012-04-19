using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace CA_PZ_10_1
{
    class Program
    {
        private Вектор v_вектор;

        void РаспечататьМеню()
        {
            Console.WriteLine(@"Меню:
1-
2-
3-
4-");
        }

        void Инициализировать()
        {
            Console.Write("Введите начальный индекс: ");
        }

        void УстановитьЗначение()
        {
            Console.Write("Введите индекс элемента [{0}-{1}]: ",
                v_вектор.НачальныйИндекс, v_вектор.КонечныйИндекс);
        }

        static void Main(string[] args)
        {
            /*Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.AutoFlush = true;

            Вектор v_вектор = new Вектор(0, 10);
            v_вектор.ЗаполнитьСлучайными(-1,1);*/

            bool b_работать = true;
            Program p = new Program();

            Console.WriteLine("Пустой ввод - распечатка меню.");

            p.РаспечататьМеню();

            while (b_работать)
            {
                Console.Write("Ваш выбор: ");

                switch (Console.ReadLine())
                {
                    case "":
                        p.РаспечататьМеню();
                        break;

                    case "1":
                        p.Инициализировать();
                        break;
                }
            }
        }
    }
}
