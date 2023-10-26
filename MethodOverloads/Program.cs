using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate(2, 2);
            Calculate(2, 2,3);
            Calculate(2, 2,4.5);
            Calculate(2, 2.5, 3.5);

            int x = 20;
            x.ToString().PadLeft(20);

  
        }

        static string Calculate(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Result: " + (a + b));
            return result.ToString();
        }
        static void Calculate(int a, int b, int c)
        {
            Console.WriteLine("Result: " + (a + b + c));
        }
        static void Calculate(int a, int b, double c)
        {
            Console.WriteLine("Result: " + (a + b + c));
        }

        static void Calculate(int a, double b, double c)
        {
            Console.WriteLine("Result: " + (a + b + c));
        }
    }
}
