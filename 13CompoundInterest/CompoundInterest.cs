using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterest
{
    class CompoundInterest
    {
        static void Main()
        {
            decimal p = decimal.Parse(Console.ReadLine());
            decimal n = decimal.Parse(Console.ReadLine());
            decimal i = decimal.Parse(Console.ReadLine());
            decimal f = decimal.Parse(Console.ReadLine());
            decimal interest= (decimal)Math.Pow(1 + (double)i, (double)n);
            decimal bankLoan = p * interest;
            decimal friendLoan = p * (1 + f);
            if (friendLoan <= bankLoan)
            {
                Console.WriteLine("{0:F2} Friend",friendLoan);
            }
            else
                Console.WriteLine("{0:F2} Bank", bankLoan);
        }
    }
}