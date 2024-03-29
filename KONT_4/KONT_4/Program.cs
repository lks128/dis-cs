﻿// Контрольная 4
// Вариант 3
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KONT_4
{
    class Program
    {
        static int СчитатьЧисло()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Спросить(string s_приглашение, ref int i_значение)
        {
            Console.Write(s_приглашение + ": ");
            i_значение = СчитатьЧисло();
        }

        static void Main(string[] args)
        {
            // Объявление и инициализация переменных
            int[,] ia_массив;
            int i_строк = 0;
            int i_столбцов = 0;
            int i_минимум = 0;
            int i_максимум = 0;
            Random v_генератор = new Random();

            // Ввод параметров массива
            Спросить("Введите количество строк", ref i_строк);
            Спросить("Введите количество столбцов", ref i_столбцов);
            Спросить("Введите минимальное значение элемента", ref i_минимум);
            Спросить("Введите максимальное значение элемента", ref i_максимум);

            // Генерация массива
            Console.WriteLine("\nСоздается массив {0}x{1} с числами от {2} до {3}",
                i_строк, i_столбцов, i_минимум, i_максимум);
            ia_массив = new int[i_строк, i_столбцов];

            for (int i = 0; i < i_строк; i++)
            {
                for (int j = 1; j < i_столбцов; j++)
                {
                    ia_массив[i, j] = v_генератор.Next(i_минимум, i_максимум + 1);
                }
            }

            Console.WriteLine("\nСгенерированный массив:");

            Распечатать(ia_массив, i_строк, i_столбцов);


            // Подсчет суммы каждой строки
            for (int i = 0; i < i_строк; i++)
            {
                for (int j = 1; j < i_столбцов; j++)
                {
                    ia_массив[i, 0] += ia_массив[i, j];
                }
            }

            Console.WriteLine("\nМассив после подсчета суммы:");
            Распечатать(ia_массив, i_строк, i_столбцов);


            // Поиск столбцев с хотя бы одним нулевым элементом
            Console.WriteLine("\nНомера столбцов, содержащих хотя бы один нулевой элемент:");
            Console.WriteLine("Столбцы нумеруются начиная с 0.");
            for (int j = 0; j < i_столбцов; j++)
            {
                for (int i = 0; i < i_строк; i++)
                {
                    if (ia_массив[i, j] == 0)
                    {
                        Console.Write("{0}  ", j);
                        break;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            // Поиск наибольшего повторяющегося числа

            // -- подсчет количества повторений чисел
            int[] ia_количества = new int[i_максимум+1];
            for (int i = 0; i < i_строк; i++)
            {
                for (int j = 1; j < i_столбцов; j++)
                {
                    ia_количества[ia_массив[i, j]] += 1;
                }
            }

            bool b_найдено = false;
             // -- обработка количества повторений чисел
            for (int i = i_максимум; i > 0; i--)
            {
                if (ia_количества[i] >= 2)
                {
                    b_найдено = true;
                    Console.WriteLine("Максимальное из чисел, "
                        + "встречающееся в заданной матрице более одного раза:");
                    Console.WriteLine(i);
                    break;
                }
            }

            // -- вывод сообщения в случае, если число не найдено
            if (!b_найдено)
            {
                Console.WriteLine("Невозможно определить максимальное из чисел,"
                    + " встречающееся в заданной матрице более одного раза,"
                    + " так как все числа встречаются не более одного раза.");
            }
            
        }

        private static void Распечатать(int[,] ia_массив, int i_строк, int i_столбцов)
        {
            for (int i = 0; i < i_строк; i++)
            {
                for (int j = 0; j < i_столбцов; j++)
                {
                    Console.Write("{0} ", ia_массив[i, j].ToString().PadLeft(2,' '));
                }
                Console.WriteLine();
            }
        }
    }
}
