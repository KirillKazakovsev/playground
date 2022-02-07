using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik5482.Chapter6_array
{
    internal class Task_6_2_FistMin_LastMax
    {
        public static void Do()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int[] N = new int[s.Length];
            for (int i = 0; i < N.Length; i++)
                N[i] = Convert.ToInt32(s[i]);
            int min = N[0];
            int max = N[0];
            int minIndex = 0;
            int maxIndex = 0;
            int a = 0;           
            for (int i = 1; i < N.Length; i++)
            {
                if (min > N[i])
                {
                    min = N[i];
                    minIndex = i;
                }
                if (max <= N[i])
                {
                    max = N[i];
                    maxIndex = i;
                }
            }            
            a = N[maxIndex];
            N[maxIndex] = N[minIndex];
            N[minIndex] = a;
            for (int i = 0; i < N.Length; i++)
                Console.Write(N[i] + " ");
        }
        }
}
