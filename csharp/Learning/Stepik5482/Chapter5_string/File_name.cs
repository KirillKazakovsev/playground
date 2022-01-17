using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter5_string
{
    internal class File_name
    {

        public static void Do()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                if ((n - i >= 3) && (s[i] == 'x' && s[i + 1] == 'x' && s[i + 2] == 'x'))
                    a++;
            }
            Console.WriteLine(a);
        }
    }
}
