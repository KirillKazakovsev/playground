using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_4_Competitions
    {

        public static void Do()
        {
            string[] a = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(a[0]);
            int m = Convert.ToInt32(a[1]);
            int[,] b = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    b[i, j] = Convert.ToInt32(s[j]);
                }
            }
            int max = 0;
            int imax = 0;
            int sum;
            for (int i = 0; i < n; i++)
            {
                sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum = sum + b[i, j];
                }
                if (sum > max)
                {
                    max = sum;
                    imax = i;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(imax);
        }
        }
}
