using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsSum(5, 5);
        }
        public static void ParamsSum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
            public static void Stringfunction()
        {
            Console.WriteLine("enter string");
            string functionstring = Console.ReadLine();
            Console.WriteLine(functionstring);
        }

        
            
    }
}
