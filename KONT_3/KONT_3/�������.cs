using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KONT_3
{
    class Комната
    {
        private double d_длина, d_ширина, d_высота;
        private int i_количествоОкон;

        public Комната(double d_длина, double d_ширина,
            double d_высота, int i_количествоОкон)
        {
            Длина = d_длина;
            Ширина = d_ширина;
            Высота = d_высота;
            КоличествоОкон = i_количествоОкон;
        }

        public double Длина
        {
            get
            {
                return d_длина;
            }
            set
            {
                if((value >= 2) && (value <= 30))
                {
                    d_длина = value;
                }
                else
                {
                    throw new ApplicationException("Недопустимое значение длины.");
                }
            }
        }

        public double Ширина
        {
            get
            {
                return d_ширина;
            }
            set
            {
                if ((value >= 2) && (value <= 30))
                {
                    d_ширина = value;
                }
                else
                {
                    throw new ApplicationException("Недопустимое значение ширины.");
                }
            }
        }

        public double Высота
        {
            get
            {
                return d_высота;
            }
            set
            {
                if ((value >= 1.8) && (value <= 4))
                {
                    d_высота = value;
                }
                else
                {
                    throw new ApplicationException("Недопустимое значение высоты.");
                }
            }
        }

        public int КоличествоОкон
        {
            get
            {
                return i_количествоОкон;
            }
            set
            {
                if ((value >= 1) && (value <= 4))
                {
                    i_количествоОкон = value;
                }
                else
                {
                    throw new ApplicationException("Недопустимое значение количества окон.");
                }
            }
        }


        public double Площадь()
        {
            return Длина * Ширина;
        }

        public double Объем()
        {
            return Площадь() * Высота;
        }

        public string Паспорт()
        {
            return String.Format(@"Паспорт комнаты
  Длина: {0:F2} м.
  Высота: {1:F2} м.
  Ширина: {2:F2} м.
  Площадь: {3:F2} кв. м.
  Объем: {4:F2} куб. м.
  Число окон: {5}", Длина, Высота, Ширина, Площадь(), Объем(), КоличествоОкон);
        }
    }
}
