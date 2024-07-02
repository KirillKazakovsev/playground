namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int num1 = number / 100000;
            int num2 = (number / 10000) % 10;
            int num3 = (number / 1000) % 10;
            int num4 = (number / 100) % 10;
            int num5 = (number / 10) % 10;
            int num6 = number % 10;
            if ((num1 + num2 + num3) == (num4 + num5 + num6))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
