using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_2_Min_Index
    {
        public static void Do()
        {
            int n = Convert.ToInt32(Console.ReadLine()); 
            string s = Console.ReadLine(); 
            string[] ss = s.Split(' '); 
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = Convert.ToInt32(ss[i]);
                numbers[i] = number;
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

            
            Console.WriteLine(indexMin);
        }
    }
}
