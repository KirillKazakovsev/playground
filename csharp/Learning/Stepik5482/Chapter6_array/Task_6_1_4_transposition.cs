using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_1_4_transposition
    {

        public static void Do()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            for (int i = 1; i < n; i += 2)
                Console.Write(s[i] + " " + s[i - 1] + " ");
            if (n % 2 != 0)
                Console.Write(s[n - 1]);
        }
    }
}
