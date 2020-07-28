using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;


//function overloading
namespace ConsoleApp1
{
    class polymorphism
    {
        public int add(int a, int b,int c)
        {
            return a + b + c;
        }

        public float add(int a, int b, float d)
        {
            return a + b + d;
        }

        public int add(int a , int b)
        {
            return a + b;
        }


        public float add(int a ,float d)
        {
            return a + d;
        }
    
        
    }


    class define
    {

        public static void Main()
        {
            polymorphism obj = new polymorphism();
            int a= obj.add(4, 5, 6);
            float b= obj.add(4, 5, 5.5f);
            int c= obj.add(4, 5);
            float d= obj.add(4, 5.5f);
            Console.WriteLine("integer:" + a);
            Console.WriteLine("Float:" + b);
            Console.WriteLine("integer:" + c);
            Console.WriteLine("float:" + d);
        }
    } 
}


