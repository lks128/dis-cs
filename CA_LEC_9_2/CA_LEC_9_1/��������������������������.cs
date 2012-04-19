using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_9_2
{
    class ГенераторДвумерногоМассива
    {
        private double d_минимум = Double.NaN;
        private double d_максимум = Double.NaN;
        private int i_количествоСтолбцов = -1;
        private int i_количествоСтрок = -1;
        private double[,] da_массив;
        private Random v_генераторСлучайныхЧисел = new Random();

        public ГенераторДвумерногоМассива()
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

        public int КоличествоСтрок
        {
            get { return i_количествоСтрок; }
            set
            {
                if (value <= 0)
                    throw new ApplicationException("Количество строк должно быть больше 0.");

                i_количествоСтрок = value;
            }
        }

        public int КоличествоСтолбцов
        {
            get { return i_количествоСтрок; }
            set
            {
                if (value <= 0)
                    throw new ApplicationException("Количество столбцов должно быть больше 0.");

                i_количествоСтолбцов = value;
            }
        }

        // методы
        public void Сформировать()
        {
            if ((i_количествоСтрок == -1) || (i_количествоСтолбцов == -1)
                || Double.IsNaN(d_максимум) || Double.IsNaN(d_минимум))
            {
                throw new ApplicationException(String.Format("Введены не все требуемые значения:\n" +
                    "d_минимум = {0}\nd_максимум = {1}\ni_количествоСтрок = {2}\ni_количествоСтолбцов = {3}",
                    d_минимум, d_максимум, i_количествоСтрок, i_количествоСтолбцов));
            }

            da_массив = new double[i_количествоСтрок, i_количествоСтолбцов];

            for (int i = 0; i < i_количествоСтрок; i++)
            {
                for (int j = 0; j < i_количествоСтолбцов; j++)
                {
                    // необходимо использовать Abs для возможности генерации в отрицательном диапазоне
                    da_массив[i, j] = Минимум + Math.Abs(Максимум - Минимум)
                        * v_генераторСлучайныхЧисел.NextDouble();
                }
            }
        }

        public void ВывестиНаЭкран()
        {
            // если использовать конструкцию вложенных массивов
            // то можно упростить вывод на экран

            for (int i = 0; i < i_количествоСтрок; i++)
            {
                for (int j = 0; j < i_количествоСтолбцов; j++)
                {
                    Console.Write("{0:F3}\t", da_массив[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
