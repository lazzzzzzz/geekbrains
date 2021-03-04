using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static long FibonacchiNumber(int i,int a,int b)
        {
            a += b;
            return (i>2)? (FibonacchiNumber(i-1,b,a)): b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine( FibonacchiNumber(3,1,1));
        }
    }
}
