using System;

namespace Stepik5482.Chapter3_If
{
    public class Task_4_2_ReverseNumber
    {
        public static void Do()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            Console.WriteLine("Обратного числа не существует");
            else 
                Console.WriteLine(1 / a);
        }
    }
}
