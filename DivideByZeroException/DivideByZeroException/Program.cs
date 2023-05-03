using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZeroException
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 10, i = 0;
            try
            {
                int s = k / i;
                Console.WriteLine("hello");
            }
            catch
            {
                Console.WriteLine("Divide by zero exception");
            }
            
        }
    }
}
