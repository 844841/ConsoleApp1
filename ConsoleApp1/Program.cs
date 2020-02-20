using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            float a, b;
            double c;
            Console.WriteLine("enter first number");
            a =float.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            b =float.Parse(Console.ReadLine());
            c = a * b;
            Console.WriteLine("product of "+a+" and "+b+" is"  +c);
            




        }
    }
}
