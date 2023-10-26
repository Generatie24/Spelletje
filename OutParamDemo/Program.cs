using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParamDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 ;
            int num2 ;
            
            Add(out num1, out num2);
            Console.WriteLine($"this is num1: {num1} this is num2:{num2} ");
        }

        static void Add(out int num1, out int num2)
        {
            num1 = 1;
            num1 += 15;
            num2 = 2;
        }
    }
}
