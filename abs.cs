using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1
{

    abstract class areaClass
    {
        public abstract int area(); 
    }

    class square:areaClass
    {
        int n;
        
        public square(int a)
        {
            n = a;
        }


        public override int area()
        {
            return n*n;
        }
    }
    class abs
    {
        public static void Main()
        {
            square a = new square(4);
            Console.WriteLine("the area of square is:{0}", a.area());
        }
        

    }
}
