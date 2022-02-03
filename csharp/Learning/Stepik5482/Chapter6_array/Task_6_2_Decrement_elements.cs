using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_2_Decrement_elements
    {
        public static void Do()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int[] a = new int[n];
            int min = Convert.ToInt32(s[0]);
            for (int i = 0; i < n; i++)
            {
               a[i] = Convert.ToInt32(s[i]);
                if (a[i] < min) min = a[i];
            }
            for (int i = 0; i < n; i++)
            {
                a[i] = a[i] - min;
                Console.Write(a[i] + " ");
            }
        }
    }
}
