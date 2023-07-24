using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Jane";
            byte Age = 27;
            bool Pet = true;
            double Foot = 37.5;

            Console.WriteLine("My name is " + Name);
            Console.WriteLine("MyAge " + Age);
            Console.WriteLine("Do I have a pet? " + Pet);
            Console.WriteLine("My shoe size is " + Foot);
            Console.ReadKey();
        }
    }
}
