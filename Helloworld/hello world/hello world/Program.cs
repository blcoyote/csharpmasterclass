using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            int num1 = 13;
            int num2 = 29;
            int sum = num1 + num2;


            Console.WriteLine($"The sum of {num1} and {num2} is "+sum);
            Console.Read();
        }
    }
}
