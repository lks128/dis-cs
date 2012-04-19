using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_PZ_9_2
{
    class ГенераторОдномерногоМассива
    {
        private double d_минимум = Double.NaN;
        private double d_максимум = Double.NaN;
        private int i_размер = -1;
        private double[] da_массив;
        private Random v_генераторСлучайныхЧисел = new Random();

        public ГенераторОдномерногоМассива()
        {
            // пустой конструктор

            // - комментарий для того, чтобы было понятно, что так надо,
            //   и разработчик ничего не забыл
        }

        // свойства
        public double Минимум
        {
            get { return d_минимум; }
            set
            {
                // так как минимальное значение может быть отрицательным
                // проверки не требуются
                d_минимум = value;
            }
        }

        public double Максимум
        {
            get { return d_максимум; }
            set
            {
                if (Double.IsNaN(d_минимум))
                    throw new ApplicationException("Введите сначала минимальное значение.");

                if (value < Минимум)
                    throw new ApplicationException("Введенное значение должно быть больше минимального.");

                d_максимум = value;
            }
        }

        public int Размер
        {
            get { return i_размер; }
            set
            {
                if (value <= 0)
                    throw new ApplicationException("Размер должен быть больше 0.");

                i_размер = value;
            }
        }

        // методы
        public void Сформировать()
        {
            if ((i_размер == -1) || Double.IsNaN(d_максимум) || Double.IsNaN(d_минимум))
            {
                throw new ApplicationException(String.Format("Введены не все требуемые значения:\n" +
                    "d_минимум = {0}\nd_максимум = {1}\ni_размер = {2}", d_минимум, d_максимум, i_размер));
            }

            da_массив = new double[i_размер];

            for (int i = 0; i < da_массив.Length; i++)
            {
                // необходимо использовать Abs для возможности генерации в отрицательном диапазоне
                da_массив[i] = Минимум + Math.Abs(Максимум - Минимум)
                    * v_генераторСлучайныхЧисел.NextDouble();
            }
        }

        public void ВывестиНаЭкран()
        {
            foreach (double d in da_массив)
            {
                Console.WriteLine("{0:F3}",d);
            }
        }

        public double СуммаОтрицательных()
        {
            double d_результат = 0;

            foreach (double d in da_массив)
            {
                if (d > 0)
                    continue;

                d_результат += d;
            }

            return d_результат;
        }

        public double ПроизведениеМеждуМинМакс()
        {
            int i_индексМинимального = 0;
            int i_индексМаксимального = 0;
            double d_результат = 1;

            for (int i = 0; i < da_массив.Length; i++)
            {
                if (da_массив[i] < da_массив[i_индексМинимального])
                    i_индексМинимального = i;

                if (da_массив[i] > da_массив[i_индексМаксимального])
                    i_индексМаксимального = i;
            }


            if (i_индексМинимального > i_индексМаксимального)
            {
                int t = i_индексМинимального;
                i_индексМинимального = i_индексМаксимального;
                i_индексМинимального = t;
            }

            for (int i = i_индексМинимального; i <= i_индексМаксимального; i++)
            {
                d_результат *= da_массив[i];
            }

            return d_результат;
        }
    }
}
