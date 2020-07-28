using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Base{
        public void show()
        {
            Console.WriteLine("hello i am parent class");
        }
    }
    
    class Derived : Base
    {
        public void derived()
        {
            Console.WriteLine("hello i am child class");
        }
    }
    
    class Inheritance 
    {
        public static void Main()
        {
            Derived obj = new Derived();
            Base obje = new Base();
            obje.show();
            obj.show();
            obj.derived();
        }
    }
}
