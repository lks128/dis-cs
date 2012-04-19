using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_11_1
{
    class ПростейшиеЧасы
    {
        private int i_час;

        public ПростейшиеЧасы()
        {
            i_час = 0;
        }

        public ПростейшиеЧасы(int i_час)
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

        public void ПеревестиВперед(int i_час)
        {
            this.i_час += i_час;
            this.i_час %= 24;
        }

        public void ВывестиВремя()
        {
            Console.WriteLine("Текущее время: {0}ч.", i_час);
        }
    }
}
