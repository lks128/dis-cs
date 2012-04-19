using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CA_PZ_9_3
{
    class Program
    {
        private string s_текст = "";

        static void Main(string[] args)
        {
            Program p = new Program();

            bool b_работа = true;

            Console.WriteLine("Пустой ввод - вывод меню.");

            while (b_работа)
            {
                Console.Write("\nВаш выбор: ");

                switch (Console.ReadLine())
                {
                    case "":
                        Console.WriteLine(@"Меню:
1-Считать предложения из файла
2-Вывести форматированный текст на экран
3-Вывести форматированный текст в файл
4-Выход
");
                        break;

                    case "1":
                        p.СчитатьПредложения(@"..\..\input.txt");
                        break;

                    case "2":
                        Console.WriteLine(p.ФорматированныйТекст);
                        break;

                    case "3":
                        p.ВывестиПредложения(@"..\..\output.txt");
                        break;

                    case "4":
                        b_работа = false;
                        break;
                }




            }

        }


        void СчитатьПредложения(string s_имяФайла)
        {
            StreamReader f_ввод = new StreamReader(s_имяФайла);
            s_текст = f_ввод.ReadToEnd();
            f_ввод.Close();

            Console.WriteLine("Считано из файла:\n\"{0}\"", s_текст);
        }

        void ВывестиПредложения(string s_имяФайла)
        {
            StreamWriter f_вывод = new StreamWriter(s_имяФайла);
            f_вывод.Write(this.ФорматированныйТекст);
            f_вывод.Close();

            Console.WriteLine("Предложения записаны в файл.");
        }

        public string ФорматированныйТекст
        {
            get
            {
                string[] sa_предложения = s_текст.Split('.');

                // убираем лишние пробелы
                for(int i = 0; i < sa_предложения.Length; i++)
                {
                    sa_предложения[i] = sa_предложения[i].Trim();
                }

                // вывод в обратном порядке
                string s_результат = "";

                Array.Reverse(sa_предложения);

                foreach (string s in sa_предложения)
                {
                    if (s == "")
                        continue;
                    s_результат += s + ". ";
                }

                return s_результат;
            }
        }
    }
}
