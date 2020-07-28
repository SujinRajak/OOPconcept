using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1
{
    class obj
    {
        int a;

        public void getval()
        {
            Console.WriteLine("Enter first values:");
            a = Convert.ToInt32(Console.ReadLine());
        }

        public static obj operator -(obj a)
        {
            obj val = new obj();
            val.a = -a.a;
            return val;
        }

        public void print()
        {
            Console.WriteLine("the number is: {0}", a);
        }
    }
    
    
    class OperatorOver
    {
        public static void Main()
        {
            obj hi = new obj();
            hi.getval();
            hi = -hi;
            hi.print();
        }
    
    }
}
