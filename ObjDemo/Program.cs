using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ObjDemo
{
    public class Student
    {
        public int Age;
        public string Name;
        public int Mark;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Age = 20;
            s.Name = "Rik";
            s.Mark = 8;

            Student s1 = GetStudent(s);
            Console.WriteLine($"{s1.Name} {s1.Age } {s1.Mark }");
        }

        private static Student GetStudent(Student s)
        {
            Student s1 = new Student();
            s1.Age = 30;
            s1.Name = "Salvatore";
            s1.Mark = 9; ;
            return s1;
        }
        
    }
}
