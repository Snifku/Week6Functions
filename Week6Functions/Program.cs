using System;

namespace Week6Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //HelloUser();
            Num();
        }
        public static void HelloUser()
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}");
        }
        public static void Num()
        {
            Console.WriteLine("enter number 1");
            int Num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter number 2");
            int Num2 = Int32.Parse(Console.ReadLine());
            int sum = Num1 + Num2;
            Console.WriteLine(sum);

        }

    }
}
