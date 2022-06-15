using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_4_Multiplication_Table
    {

        public static void Do()
        {
            string[] s = Console.ReadLine().Split();
            int n = Convert.ToInt32(s[0]), m = Convert.ToInt32(s[1]);
            int[,] a = new int[n, m];
            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= m; ++j)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
