using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 10;
            try
            {
                k = k / 0;
                Console.WriteLine("Hello");
            }
            catch
            {
                Console.WriteLine("Runtime Exception");
            }
            
        }
    }
}
