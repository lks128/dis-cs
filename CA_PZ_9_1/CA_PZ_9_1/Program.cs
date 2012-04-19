using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CA_PZ_9_1
{
    class Program
    {

        static void РаспечататьМассив(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("[{0}] = \"{1}\"", i, arr[i]);
            }
        }

        static void Main(string[] args)
        {
            // Работа со строками и символами

            string s_исходнаяСтрока = "   ПЕРВОЕ ПРЕДЛОЖЕНИЕ.   ВТОРОЕ ПРЕДЛОЖЕНИЕ!  ТРЕТЬЕ ПРЕДЛОЖЕНИЕ.  ";

            Console.WriteLine("Исходная строка:\n{0}", s_исходнаяСтрока);

            s_исходнаяСтрока = s_исходнаяСтрока.ToLower();

            // разбиваем строку на предложения
            // sa - сокращенно String Array
            string[] sa_предложения = s_исходнаяСтрока.Split('.', '!');

            Console.WriteLine("Число элементов в массиве: {0}", sa_предложения.Length);

            Console.WriteLine("Массив:");
            РаспечататьМассив(sa_предложения);

            // удаление лишних пробелов в начале и конце предложения
            for (int i = 0; i < sa_предложения.Length; i++)
            {
                sa_предложения[i] = sa_предложения[i].Trim();
            }

            Console.WriteLine("Массив без пробелов:");
            РаспечататьМассив(sa_предложения);

            // Замена первых букв предлжения на прописные

            char[] ca_символы;

            for (int i = 0; i < sa_предложения.Length; i++)
            {
                if (sa_предложения[i].Length == 0)
                    continue;

                ca_символы = sa_предложения[i].ToCharArray();
                ca_символы[0] = Char.ToUpper(ca_символы[0]);
                sa_предложения[i] = new string(ca_символы);
            }

            Console.WriteLine("Массив с заглавными буквами:");
            РаспечататьМассив(sa_предложения);

            // вывод предложений на экран в обратном порядке
            Console.WriteLine();

            // изменение порядка следования элеметнов на  обратный
            Array.Reverse(sa_предложения);

            Console.WriteLine("Перевернутый массив:");
            РаспечататьМассив(sa_предложения);

            // формирование выходной строки. разделители - точка

            string s_выходнаяСтрока = "";

            foreach (string s in sa_предложения)
            {
                if (s == "") continue;

                s_выходнаяСтрока = s_выходнаяСтрока + String.Concat(s, ". ");
            }

            Console.WriteLine("Результат: {0}", s_выходнаяСтрока);

            Console.WriteLine();
        }
    }
}
