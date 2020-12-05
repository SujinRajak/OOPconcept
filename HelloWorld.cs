using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            if (args == null)
            {
                Console.WriteLine("args is null");
            }
            else
            {
                Console.WriteLine("args length is ");
                Console.WriteLine(args.Length);

                for(int i =0;i < args.Length; i++)
                {
                    string argus = args[i];
                    Console.Write("args index");
                    Console.Write(i);
                    Console.Write("is [");
                    Console.Write(argus);
                    Console.WriteLine("]");
                }
            }
            Console.ReadLine();
        }
    }
}
