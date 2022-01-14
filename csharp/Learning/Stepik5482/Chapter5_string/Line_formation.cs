using System;

namespace Stepik5482.Chapter5_string
{
    internal class Line_formation
    {
        public static void Do()

        {
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
                if (s[i] == 'e')
                    Console.Write('i');
                else
                    Console.Write(s[i]);
        }
    }
}
