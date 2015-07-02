using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStartup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading libarary...");

            MyLibrary.TestClass test = new MyLibrary.TestClass();
            var v = test.Test("summer");
            Console.WriteLine(v);

            Console.Read();
        }

        public static void Launchpad()
        {
            Console.WriteLine("new launch pad function to commit");
        }
    }
}
