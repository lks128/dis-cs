using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_12_1
{
    class Program
    {
        static void Заголовок(string s_текст)
        {
            Console.WriteLine();
            Console.WriteLine("====== {0} ======", s_текст);
        }

        static void Main(string[] args)
        {
            // инициализация
            ЧасовойМагазин v_магазин = new ЧасовойМагазин();

            Заголовок("Сгенерированные часы");
            v_магазин.ПоказатьЧасы();


            // сортировка
            v_магазин.Отсортировать();

            Заголовок("Отсортированные часы");
            v_магазин.ПоказатьЧасы();
        }
    }
}
