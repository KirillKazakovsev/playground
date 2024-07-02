using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_6_even_and_quantity
    {
        public static void Do()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j + 1)
                    {
                        Console.Write(1 + " ");
                    }
                    else if (i < j + 1)
                    {
                        Console.Write(2 + " ");
                    }
                    else if (i > j)
                    {
                        Console.Write(0 + " ");
                    }
                }
                Console.WriteLine();
                int n = Convert.ToInt32(Console.ReadLine()); // сколько чисел будут вводиться на следующей строке
                string s = Console.ReadLine(); // сохранить все введенную строку
                string[] ss = s.Split(' '); // разделить введенную строку по пробелам и сохранить в массив строкового типа

                int[] numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    int number = Convert.ToInt32(ss[i]);
                    numbers[i] = number;
                    // Console.WriteLine(numbers[i]+" ");
                }

                //  считаем:
                int cnt = 0;
                string res = "";
                for (int i = 0; i < n; i++)
                {
                    if (numbers[i] % 2 != 0) //если нечетное- пропускаем
                    {
                        continue;
                    }
                }
    }
}
