using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunlight
{
    class Sunlight
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int size = 3 * n;
            int diagonal = n - 1;
            Console.WriteLine("{0}*{0}",new string('.',size/2));
            for (int i = 0; i < diagonal; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.',1+ i),new string('.', ((size -5)/2)-i));
            }
            for (int i = 0; i < (size-2*diagonal-3)/2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }
            Console.WriteLine(new string('*', size));
            for (int i = 0; i < (size - 2 * diagonal - 3) / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }
            for (int i = diagonal; i > 0; i--)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', (size - 3- 2*i)/2));
            }
            Console.WriteLine("{0}*{0}",new string('.',size/2));
        }
    }
}
