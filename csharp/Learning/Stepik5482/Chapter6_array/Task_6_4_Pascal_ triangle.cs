using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_4_Pascal__triangle
    {

        public static void Do()
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(s[0]), m = Convert.ToInt32(s[1]);
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 || j == 0) a[i, j] = 1;
                    else a[i, j] = a[i - 1, j] + a[i, j - 1];
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
