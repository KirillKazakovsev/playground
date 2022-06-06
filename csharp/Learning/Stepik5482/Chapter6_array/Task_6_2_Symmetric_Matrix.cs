using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_2_Symmetric_Matrix
    {
        public static void Do()
        {
            int n = Convert.ToInt32(Console.ReadLine()), k = 0;
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    a[i, j] = Convert.ToInt32(s[j]);
            }
            for (int i = 0; i < n; i++)
                for (int j = i; j < n; j++)
                    if (a[i, j] != a[j, i])
                    {
                        Console.Write("NO");
                        k++;
                        i = n;
                        break;
                    }
            if (k == 0)
                Console.Write("YES");
        }
    }
}
