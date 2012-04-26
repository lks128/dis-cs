using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CA_LEC_11_1;

namespace CA_LEC_12_1
{
    class ЧасовойМагазин
    {
        private СекундныеЧасы[] va_часы;

        public ЧасовойМагазин(int i_количество)
        {
            Random v_генератор = new Random();

            va_часы = new СекундныеЧасы[i_количество];

            for (int i = 0; i < va_часы.Length; i++)
            {
                va_часы[i] = СекундныеЧасы.СлучайныеЧасы();
            }

            Console.WriteLine("Инициализирован ЧасовойМагазин с {0} часами", i_количество);
        }

        public ЧасовойМагазин() : this(10) { }

        public void ПоказатьЧасы()
        {
            for (int i = 0; i < va_часы.Length; i++)
            {
                Console.Write("Часы [{0}] - ", i);
                va_часы[i].ВывестиВремя();
            }
        }

        public void Отсортировать(IComparer<СекундныеЧасы> v_сравнение = null)
        {
            if (v_сравнение == null) Array.Sort(va_часы);
            else Array.Sort(va_часы, v_сравнение);
        }
    }
}
