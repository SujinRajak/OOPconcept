using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface Ivechicle
    {
        //public int a, b;    
        //string name;                                        //cant declare variables
        // public string Fname="sujin";                       //can't initialize variable

        //only methods can be declared just to provide the overview oof the system which can be commom to all the child class 

        string name();
        string color();
        int speed();
        int weight();
    }
    
    class audi : Ivechicle
    {
        public string name()
        {
            return "Audi-classic";
        }

        public string color()
        {
            return "white";
        }
        public int speed()
        {
            return 300;
        }

        public int weight()
        {
            return 300;
        }


        
    }
    
    class Interface
    {
       
        public static void Main()
        {
            Ivechicle a;
            a = new audi();
            Console.WriteLine("the name is :{0}", a.name());
            Console.WriteLine("the cl0oir is :{0}", a.color());
            Console.WriteLine("the speed is :{0}", a.speed() + "Kmp");
            Console.WriteLine("the weight is  is :{0}", a.weight() + "pounds");
        }
       

    
    }
}
