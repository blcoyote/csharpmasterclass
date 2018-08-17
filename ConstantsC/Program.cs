using System;

namespace ConstantsC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two numbers seperated by enter");
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();
            Console.WriteLine(Int32.Parse(input)+Int32.Parse(input2));
            Console.Read();
        }


    }
}
