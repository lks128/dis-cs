using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_PZ_7_1
{
    class Часы1
    {
        public const string S_Название = "Часы с часовой стрелкой";

        private static int i_количествоОбращений = 0;

        private int i_час;

        public Часы1()
        {
            i_количествоОбращений += 1;
            i_час = 0;
        }

        public Часы1(int i_час)
        {
            i_количествоОбращений += 1;
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

        public static int КоличествоОбращений
        {
            get
            {
                return i_количествоОбращений;
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
