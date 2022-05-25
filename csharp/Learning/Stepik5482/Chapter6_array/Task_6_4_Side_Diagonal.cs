using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_4_side_diagonal
    //Побочная диагональ
    //Дано число n, n\le100n,n≤100. Создайте массив n\times nn×n и заполните его по следующему правилу:
    //числа на диагонали, идущей из правого верхнего в левый нижний угол, равны 1;
    //числа, стоящие выше этой диагонали, равны 00;
    //числа, стоящие ниже этой диагонали, равны 22.
    //Программа получает на вход число nn.
    //Необходимо вывести полученный массив. Числа разделяйте одним пробелом.
    {

        public static void Do()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n]; 
            for (int i = n; i > 0; i--) 
            {
                for (int j = 0; j < n; j++) 
                {
                    if (i == j + 1)        
                    {
                        Console.Write(1 + " "); 
                    }
                    else if (i < j + 1)   
                    {
                        Console.Write(2 + " "); 
                    }
                    else if (i > j)          
                    {
                        Console.Write(0 + " "); 
                    }
                }
                Console.WriteLine();  
            }
        }
    }
}
