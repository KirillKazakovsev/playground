using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter5_string
{
    internal class Azbyka_Artorse
    {

        public static void Do()
        {
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '.')
                    Console.Write(0);
                else
                    Console.Write(s[++i] == '.' ? 1 : 2);
            }
        }
    }
}
