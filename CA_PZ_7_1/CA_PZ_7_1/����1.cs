using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_PZ_7_1
{
    class Часы1
    {
        private int i_час;

        public Часы1()
        {
            i_час = 0;
        }

        public Часы1(int i_час)
        {
            this.Час = i_час;
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

        public void ПеревестиВперед(int n)
        {
            i_час += n;

            while (i_час > 23)
            {
                i_час -= 24;
            }
        }

        override public string ToString()
        {
            return String.Format("Текущее время: {0} часов", i_час);
        }
    }
}
