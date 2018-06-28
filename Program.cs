using System;
using System.Linq;
using System.Threading;

namespace TestRepository
{
    class Program
    {

        static void Main(string[] args)
        {
            int x = 2;
                      
            MyTest mt=  new MyTest();
            mt.Test();
            Console.WriteLine("Hello World!"+x);
        }
    }
}
