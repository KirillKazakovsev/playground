using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_1_6_Rotate
    {
        public static void Do()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n - 1; i++)
            {
                if (i == 0)
                {
                    Console.Write(s[n - 1] + " ");
                }
                Console.Write(s[i] + " ");
            }
        }
    }
}
