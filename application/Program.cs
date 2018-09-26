using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 15;
           double sum= Add(a, b);
           Console.WriteLine("sum={0}", sum);
        }
        static double Add(double a,double b)
        {
            return a + b;
        }
    }
}
