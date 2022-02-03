using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_2_Difference_MinMax_Index
    {
        public static void Do()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(ss[i]);
            }
            int min = numbers[0];
            int indexMin = 0;
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    indexMin = i;
                }
            }
            int max = numbers[0];
            int indexMax = 0;
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    indexMax = i;
                }
            }
            Console.WriteLine(indexMax - indexMin);
        }
    }
}
