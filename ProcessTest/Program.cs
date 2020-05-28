using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 100000m; i++)
            {
                decimal j = 0m;
                j = i* i;
            }
            Thread.Sleep(10000000);
            Console.WriteLine(args[0]);

            Console.ReadKey();
        }
    }
}
