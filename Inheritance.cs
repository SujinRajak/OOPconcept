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
    
    
    class Inheritance : Base
    {

        public void derived()
        {
            Console.WriteLine("yo bro wassuppp i am his child");
        }
        public static void Main()
        {
            Inheritance obj = new Inheritance();
            Base obje = new Base();
            obje.show();
            obj.show();
            obj.derived();
        }
        
    }
}
