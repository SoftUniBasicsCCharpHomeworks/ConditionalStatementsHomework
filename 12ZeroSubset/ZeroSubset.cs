using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroSubset
{
    class ZeroSubset
    {
        static void Main()
        {
            int[] number = new int[5];

            Console.WriteLine("Enter five numbers");

            for (int i = 0; i < 5; i++)
            {
                number[i] = int.Parse(Console.In.ReadLine());
            }

            bool subsetFound = false;
            
            for (int firstPos = 0; firstPos < 5; firstPos++)
            {

                for (int secondPos = firstPos+1; secondPos < 5; secondPos++)
                {

                    if (number[firstPos] + number[secondPos] == 0)
                    {
                        subsetFound = true;
                        Console.WriteLine("{0} + {1} = 0", number[firstPos], number[secondPos]);
                    }
                    for (int thirdPos = secondPos+1; thirdPos < 5; thirdPos++)
                    {

                        if (number[firstPos] + number[secondPos] + number[thirdPos] == 0)
                        {
                            subsetFound = true;
                            Console.WriteLine("{0} + {1} + {2} = 0", number[firstPos], number[secondPos], number[thirdPos]);
                        }
                        for (int fourthPos = thirdPos+1; fourthPos < 5; fourthPos++)
                        {

                            if (number[firstPos]+ number[secondPos]+ number[thirdPos] + number[fourthPos] == 0)
                            {
                                subsetFound = true;
                                Console.WriteLine("{0} + {1} + {2} + {3}= 0", number[firstPos], number[secondPos], number[thirdPos], number[fourthPos]);
                            }
                            for (int fithPos = fourthPos+1; fithPos < 5; fithPos++)
                            {
                                if (number[firstPos]+ number[secondPos]+ number[thirdPos] + number[fourthPos] + number[fithPos] == 0)
                                {
                                    subsetFound = true;
                                    Console.WriteLine("{0} + {1} + {2} + {3}= 0", number[firstPos], number[secondPos], number[thirdPos], number[fourthPos], number[fithPos]);
                                }
                            }
                        }

                    }

                }

            }
            if (subsetFound == false)
            {
                Console.WriteLine("no zero subset");
            }
        }
    }
}
