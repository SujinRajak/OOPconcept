using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Base
    {
        public virtual void show()
        {
            Console.WriteLine("i am the parent class");
        }
    }
    

    class derived: Base
    {
        public override void show()
        {
            Console.WriteLine("i am the child class");
        }
    }
    class VirtualFuntion
    {
        public static void Main()
        {
            derived obj = new derived();
            Base ob = new Base();
            ob.show();
            obj.show();
        }
    }
}
