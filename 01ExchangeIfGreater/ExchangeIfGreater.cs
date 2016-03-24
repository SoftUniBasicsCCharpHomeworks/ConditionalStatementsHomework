using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.WriteLine("Enter first number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double b = double.Parse(Console.ReadLine());

            if (a>b)
            {
                double c = a;
                a = b;
                b = c;
            }
            Console.WriteLine(a + " " + b);
        }
    }
}
