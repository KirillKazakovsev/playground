using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter5_string
{
    internal class long_words
    {
        public static void Do()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                string s = Console.ReadLine();
                if (s.Length > 10)
                    Console.WriteLine(s[0] + "" + (int)(s.Length - 2) + "" + s[s.Length - 1]);
                else
                    Console.WriteLine(s);
            }
        }
    }
}
