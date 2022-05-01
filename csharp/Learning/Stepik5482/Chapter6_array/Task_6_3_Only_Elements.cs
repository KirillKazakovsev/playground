using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_3_Only_Elements
    {
        public static void Do()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < s.Length; i++)
            {
                int a = 0;
                for (int j = 0; j < s.Length; j++)
                    if (s[i] == s[j] && i != j)
                    {
                        a++;
                        break;
                    }
                if (a == 0)
                    Console.Write(s[i] + " ");
            }

        }
    }
}
