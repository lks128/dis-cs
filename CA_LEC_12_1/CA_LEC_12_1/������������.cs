using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_11_1
{
    class МинутныеЧасы : ПростейшиеЧасы
    {
        private int i_минута;

        public МинутныеЧасы() : base()
        {
            Минута = 0;
        }

        public МинутныеЧасы(int i_час, int i_минута)
            : base(i_час)
        {
            Минута = i_минута;
        }


        public int Минута
        {
            get
            {
                return i_минута;
            }

            set
            {
                if (value < 0)
                {
                    throw new ApplicationException("Количество миунт не может быть отрицательным.");
                }
                else if (value > 59)
                {
                    throw new ApplicationException("Количество минут не может быть больше 59.");
                }

                i_минута = value;
            }
        }

        public void ПеревестиВперед(int i_час, int i_минута)
        {
            this.i_минута += i_минута;
            this.i_минута %= 60;

            ПеревестиВперед(i_час + i_минута / 60);
        }

        override public void ВывестиВремя()
        {
            Console.WriteLine("Текущее время: {0}ч. {1}мин.", Час, Минута);
        }
    }
}
