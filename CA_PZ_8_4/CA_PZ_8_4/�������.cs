using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_PZ_8_4
{
    class Счетчик
    {
        /*
         * Поля
         */

        private int i_значение;


        /*
         * Конструкторы
         */

        public Счетчик()
        {
            Значение = 0;
        }

        public Счетчик(int i_значение)
        {
            Значение = i_значение;
        }

        /*
         * Свойства
         */

        public int Значение
        {
            get
            {
                return i_значение;
            }
            set
            {
                if ((value > 9999) || (value < 0))
                {
                    throw new ApplicationException("Недопустимое значение счетчика.");
                }

                i_значение = value;
            }
        }

        /*
         * Методы
         */

        public void Увеличить()
        {
            Значение += 1;
        }

        public void Уменьшить()
        {
            Значение -= 1;
        }

        public bool МожноУвеличитьНа(int n)
        {
            return (Значение + n > 9999) ? false : true;
        }

        public bool МожноУменьшитьНа(int n)
        {
            return (Значение - n < 0) ? false : true;
        }

        public override string ToString()
        {
            return "Значение счетчика: " + Значение.ToString();
        }
    }
}
