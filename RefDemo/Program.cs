using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            int num3 = 50;
            int num4 = 60;
            
            AddRef(ref num1, ref num2);
            Console.WriteLine($"this is num1: {num1} {num2}");

            AddValue(num3,num4);
            Console.WriteLine($"this is num1: {num3} {num4}");
        }
        static void AddRef(ref int num1, ref int num2)
        {
            num1 += 1;
            num2 += 20;
        }
        static void AddValue(int num1, int num2)
        {
            num1 += 1;
            num2 += 20;
        }
    }
}
