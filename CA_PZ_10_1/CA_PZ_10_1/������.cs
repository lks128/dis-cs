using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace CA_PZ_10_1
{
    class Вектор
    {
        private int[] ia_массив;
        private int i_начальныйИндекс;
        private int i_конечныйИндекс;
        private int i_минимальноеЗначение;
        private int i_максимальноеЗначение;

        public Вектор(int i_начальныйИндекс, int i_конечныйИндекс)
        {
            if (i_конечныйИндекс <= i_начальныйИндекс)
                throw new ApplicationException("Неверные значения индексов.");

            this.i_начальныйИндекс = i_начальныйИндекс;
            this.i_конечныйИндекс = i_конечныйИндекс;

            int m = i_конечныйИндекс - i_начальныйИндекс + 1;

            ia_массив = new int[m];
        }

        public int this[int i]
        {
            get
            {
                if ((i < НачальныйИндекс) || (i > КонечныйИндекс))
                    throw new ApplicationException("Индекс выходит за допустимые границы.");

                return ia_массив[i - i_начальныйИндекс];
            }

            set
            {
                if ((i < НачальныйИндекс) || (i > КонечныйИндекс))
                    throw new ApplicationException("Индекс выходит за допустимые границы.");

                ia_массив[i - НачальныйИндекс] = value;
            }
        }

        public int МинимальноеЗначение
        {
            get
            {
                return i_минимальноеЗначение;
            }
        }

        public int МаксимальноеЗначение
        {
            get
            {
                return i_максимальноеЗначение;
            }
        }

        public int Длина
        {
            get
            {
                return КонечныйИндекс - НачальныйИндекс + 1;
            }
        }

        public int НачальныйИндекс
        {
            get
            {
                return i_начальныйИндекс;
            }
        }

        public int КонечныйИндекс
        {
            get
            {
                return i_конечныйИндекс;
            }
        }

        public void ЗаполнитьСлучайными(int i_минимум, int i_максимум)
        {
            i_минимальноеЗначение = i_минимум;
            i_максимальноеЗначение = i_максимум;

            Random r = new Random();
            for (int i = НачальныйИндекс; i <= КонечныйИндекс; i++)
            {
                this[i] = r.Next(i_минимум, i_максимум + 1);
            }
        }

        public void Распечатать(string s_заголовок = "")
        {
            if (s_заголовок != "")
            {
                Console.WriteLine();
            }

            Console.WriteLine("=== {0}", s_заголовок);

            for (int i = НачальныйИндекс; i <= КонечныйИндекс; i++)
            {
                Console.WriteLine("--- вектор[{0:D2}] = {1}", i, this[i]);
            }

            Console.WriteLine();
        }

        public void Распечатать(int i_индекс)
        {
            Console.WriteLine("--- вектор[{0:D2}] = {1}", i_индекс, this[i_индекс]);
        }

        public static Вектор operator +(Вектор x, Вектор y)
        {
            if ((x.КонечныйИндекс != y.КонечныйИндекс) || (x.НачальныйИндекс != y.НачальныйИндекс))
                throw new ApplicationException("Несовместимые границы индексов операндов сложения.");

            Вектор v_результат = new Вектор(x.НачальныйИндекс, x.КонечныйИндекс);

            for (int i = x.НачальныйИндекс; i <= x.КонечныйИндекс; i++)
            {
                v_результат[i] = x[i] + y[i];
            }

            return v_результат;
        }

        public static Вектор operator -(Вектор x, Вектор y)
        {
            if ((x.КонечныйИндекс != y.КонечныйИндекс) || (x.НачальныйИндекс != y.НачальныйИндекс))
                throw new ApplicationException("Несовместимые границы индексов операндов вычитания.");

            Вектор v_результат = new Вектор(x.НачальныйИндекс, x.КонечныйИндекс);

            for (int i = x.НачальныйИндекс; i <= x.КонечныйИндекс; i++)
            {
                v_результат[i] = x[i] - y[i];
            }

            return v_результат;
        }

        public static Вектор operator *(Вектор x, int y)
        {
            Вектор v_результат = new Вектор(x.НачальныйИндекс, x.КонечныйИндекс);

            for (int i = x.НачальныйИндекс; i <= x.КонечныйИндекс; i++)
            {
                v_результат[i] = x[i] * y;
            }

            return v_результат;
        }

        public static Вектор operator /(Вектор x, int y)
        {
            Вектор v_результат = new Вектор(x.НачальныйИндекс, x.КонечныйИндекс);

            for (int i = x.НачальныйИндекс; i <= x.КонечныйИндекс; i++)
            {
                v_результат[i] = x[i] / y;
            }

            return v_результат;
        }
    }
}
