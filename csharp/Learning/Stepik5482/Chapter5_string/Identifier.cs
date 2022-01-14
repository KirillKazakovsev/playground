using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter5_string
{
    internal class Identifier
    {
        public static void Do()
        {
            string s = Console.ReadLine();
            int a = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i] >= 'a' && s[i] <= 'z' || s[i] >= 'A' && s[i] <= 'Z' || s[i] >= '0' && s[i] <= '9' && i != 0 || s[i] == '_')
                    a++;
            if (a == s.Length)
                Console.Write("YES");
            else
                Console.Write("NO");
        }
    }
}
