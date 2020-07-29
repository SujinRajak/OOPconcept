using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    
    abstract class imp
    {
        public int a, b,c=0;
        public abstract int area();

        public void get()
        {
            Console.WriteLine("enter number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number");
            b = Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("the area is :{0}",c);
        }
    }

    class rectangle:imp
    {
        
        
        public override int area()
        {
            c = a * b;
            return c;
        }
    }

    class square : imp
    {

       
        public override int area()
        {
            c = a * a;
            return c;
        }
    }

    class abbbs
    {
        public static void Main()
        {
            imp ob;
            ob = new rectangle();
            ob.get();
            ob.area();
            ob.display();

            ob = new square();
            ob.get();
            ob.area();
            ob.display();
        }
    }





    
    
    
}
