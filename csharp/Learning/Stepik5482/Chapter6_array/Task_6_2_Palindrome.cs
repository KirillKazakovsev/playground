using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_2_Palindrome
    {
        public static void Do()
        {
            int n = Convert.ToInt32(Console.ReadLine());               
            string[] s = Console.ReadLine().Split();
            int a = 0;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    Console.Write("NO");
                    a++;
                    break;
                }
            }
            if (a == 0)
                Console.Write("YES");
        }
    }
}
