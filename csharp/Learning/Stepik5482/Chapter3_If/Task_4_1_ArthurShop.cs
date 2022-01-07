using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter3_If
{
    public class Task_4_1_ArthurShop
    {
        public static void Do()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int s1 = a + a + b + b;
            int s2 = a + c + b;
            int s3 = a + c + c + a;
            int s4 = b + c + c + b;
            int m1 = Math.Min(s1, s2);
            int m2 = Math.Min(s3, s4);
            Console.WriteLine(Math.Min(m1, m2));
        }
    }
}
