using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_1_5_Two_element
    {
        public static void Do()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            string[] s = Console.ReadLine().Split();
            int[] b = new int[n];
            for (int i = 0; i < s.Length; i++)
            {
                b[i] = Convert.ToInt32(s[i]);
                if (i > 0 && b[i] * b[i - 1] > 0)
                    a++;
            }
            if (a > 0)
                Console.Write("YES");
            else
                Console.Write("NO");
        }
    }
}
