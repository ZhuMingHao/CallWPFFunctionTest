using System;

namespace Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
          
            if (args.Length > 2)
            {
                if (args[2].ToString() == "/extension")
                {
                    TestMethod();
                }
            }
        }
        private static void TestMethod()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
