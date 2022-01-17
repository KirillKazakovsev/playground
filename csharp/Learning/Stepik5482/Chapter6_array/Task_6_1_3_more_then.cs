using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_1_3_more_then
    {
        public static void Do()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            string[] s = Console.ReadLine().Split();
            int[] b = new int[n];
            b[0] = Convert.ToInt32(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                b[i] = Convert.ToInt32(s[i]);
                if (b[i] > b[i - 1])
                    a++;
            }
            Console.Write(a);
        }
    }
}
