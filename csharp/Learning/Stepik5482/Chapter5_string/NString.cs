using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter5_string
{
    internal class NString
    {
        public static void Do()
        {
            string s = Console.ReadLine();
            int a = 0;
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == ' ')
                {
                    a++;
                    if (a == 1)
                        Console.Write(s[i]);
                    else if (a > 1 && s[i - 1] != ' ')
                        a = 0;
                }
                else
                    Console.Write(s[i]);
            }
        }
    }
}
