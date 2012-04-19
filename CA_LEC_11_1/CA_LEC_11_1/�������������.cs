﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_11_1
{
    class СекундныеЧасы : МинутныеЧасы
    {
        private int i_секунда;

        public СекундныеЧасы() : base()
        {
            Секунда = 0;
        }

        public СекундныеЧасы(int i_час, int i_минута, int i_секунда)
            : base(i_час, i_минута)
        {
            Секунда = i_секунда;
        }


        public int Секунда
        {
            get
            {
                return i_секунда;
            }

            set
            {
                if (value < 0)
                {
                    throw new ApplicationException("Количество секунд не может быть отрицательным.");
                }
                else if (value > 59)
                {
                    throw new ApplicationException("Количество секунд не может быть больше 59.");
                }

                i_секунда = value;
            }
        }

        public void ПеревестиВперед(int i_час, int i_минута, int i_секунда)
        {
            this.i_секунда += i_секунда;
            this.i_секунда %= 60;

            ПеревестиВперед(i_час, i_минута + i_секунда / 60);
        }

        new public void ВывестиВремя()
        {
            Console.WriteLine("Текущее время: {0}ч. {1}мин. {2}сек.", Час, Минута, Секунда);
        }
    }
}
