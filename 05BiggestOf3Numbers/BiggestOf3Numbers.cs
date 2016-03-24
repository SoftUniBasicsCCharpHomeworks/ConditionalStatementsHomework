using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("the biggest number is: {0}", a);
        }
        else if (b >= c && b >= a)
        {
            Console.WriteLine("the biggest number is: {0}", b);
        }
        else
        {
            Console.WriteLine("the biggest number is: {0}", c);
        }

    }
}

