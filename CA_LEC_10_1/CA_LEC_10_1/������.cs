using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_10_1
{
    class Массив
    {
        private int[] ia_массив;

        public Массив(int i_размерность)
        {
            if (i_размерность <= 0)
                throw new ApplicationException("Недопустимое значение индекса.");

            ia_массив = new int[i_размерность];
        }

        public Массив(params int[] ia_массив)
        {
            this.ia_массив = (int[]) ia_массив.Clone();
        }

        public int this[int i_индекс]
        {
            get
            {
                if((i_индекс < 0) || (i_индекс >= Размерность))
                    throw new ApplicationException("Индекс выходит за пределы массива.");

                return ia_массив[i_индекс];
            }
            set
            {
                if ((i_индекс < 0) || (i_индекс >= Размерность))
                    throw new ApplicationException("Индекс выходит за пределы массива.");

                ia_массив[i_индекс] = value;
            }
        }

        public int Размерность
        {
            get
            {
                return ia_массив.Length;
            }
        }


        public static Массив operator + (Массив v_1, Массив v_2)
        {
            if (v_1.Размерность != v_2.Размерность)
                throw new ApplicationException("Массивы имеют разную размерность.");

            int i_размерность = v_1.Размерность;

            Массив v_результат = new Массив(i_размерность);

            for(int i = 0; i < i_размерность; i++)
            {
                v_результат[i] = v_1[i] + v_2[i];
            }

            return v_результат;
        }

        public static Массив operator -(Массив v_1, Массив v_2)
        {
            if (v_1.Размерность != v_2.Размерность)
                throw new ApplicationException("Массивы имеют разную размерность.");

            int i_размерность = v_1.Размерность;

            Массив v_результат = new Массив(i_размерность);

            for (int i = 0; i < i_размерность; i++)
            {
                v_результат[i] = v_1[i] - v_2[i];
            }

            return v_результат;
        }


    }
}
