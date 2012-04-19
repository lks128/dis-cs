using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_PZ_7_2
{
    class Часы2
    {
        private int i_час;
        private int i_минута;

        public Часы2()
        {
            i_час = 0;
            i_минута = 0;
        }

        public Часы2(int i_час, int i_минута)
        {
            this.Час = i_час;
            this.Минута = i_минута;
        }

        public int Час
        {
            get
            {
                return i_час;
            }

            set
            {
                if (value < 0)
                {
                    throw new ApplicationException("Количество часов не может быть отрицательным.");
                }
                else if (value > 23)
                {
                    throw new ApplicationException("Количество часов не может быть больше 23.");
                }

                i_час = value;
            }
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
                    throw new ApplicationException("Количество минут не может быть отрицательным.");
                }
                else if (value > 59)
                {
                    throw new ApplicationException("Количество минут не может быть больше 59.");
                }

                i_минута = value;
            }
        }

        public void ПеревестиВперед(int i_часов, int i_минут)
        {
            if (i_часов < 0)
            {
                throw new ApplicationException("Количество часов не может быть отрицательным.");
            }
            if (i_минут < 0)
            {
                throw new ApplicationException("Количество минут не может быть отрицательным.");
            }

            i_час += i_часов;
            i_минута += i_минут;

            while (i_минута > 59)
            {
                i_час += 1;
                i_минута -= 60;
            }

            while (i_час > 23)
            {
                i_час -= 24;
            }
        }

        override public string ToString()
        {
            return String.Format("Текущее время: {0}ч {1}м", Час, Минута);
        }
    }
}
