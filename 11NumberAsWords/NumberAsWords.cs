using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsWords
{
    class NumberAsWords
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number(0 - 999)");
            int number = int.Parse(Console.In.ReadLine());

            if (number <= 999 && number >= 0)
            {
                switch (number / 100)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("One hundred ");
                        break;
                    case 2:
                        Console.Write("Two hundred ");
                        break;
                    case 3:
                        Console.Write("Three hundred ");
                        break;
                    case 4:
                        Console.Write("Four hundred ");
                        break;
                    case 5:
                        Console.Write("Five hundred ");
                        break;
                    case 6:
                        Console.Write("Six hundred ");
                        break;
                    case 7:
                        Console.Write("Seven hundred ");
                        break;
                    case 8:
                        Console.Write("Eight hundred  ");
                        break;
                    case 9:
                        Console.Write("Nine hundred  ");
                        break;

                    default:
                        break;
                }

                if (number / 100 != 0 && number % 100 != 0)
                {
                    Console.Write("and ");
                }
                switch (number / 10 % 10)
                {
                    case 0:
                        break;
                    case 1:
                        {
                            switch (number % 10)
                            {
                                case 0:
                                    Console.WriteLine("ten");
                                    break;
                                case 1:
                                    Console.WriteLine("eleven");
                                    break;
                                case 2:
                                    Console.WriteLine("twelve");
                                    break;
                                case 3:
                                    Console.WriteLine("thirteen");
                                    break;
                                case 4:
                                    Console.WriteLine("fourteen");
                                    break;
                                case 5:
                                    Console.WriteLine("fifteen");
                                    break;
                                case 6:
                                    Console.WriteLine("sixteen");
                                    break;
                                case 7:
                                    Console.WriteLine("seventeen");
                                    break;
                                case 8:
                                    Console.WriteLine("eighteen");
                                    break;
                                case 9:
                                    Console.WriteLine("nineteen");
                                    break;

                                default:
                                    break;
                            }
                        }
                        break;

                    case 2:
                        Console.Write("twenty ");
                        break;
                    case 3:
                        Console.Write("thirty ");
                        break;
                    case 4:
                        Console.Write("forty ");
                        break;
                    case 5:
                        Console.Write("fifty ");
                        break;
                    case 6:
                        Console.Write("sixty ");
                        break;
                    case 7:
                        Console.Write("seventy ");
                        break;
                    case 8:
                        Console.Write("eighty  ");
                        break;
                    case 9:
                        Console.Write("ninety  ");
                        break;

                    default:
                        break;
                }
                switch (number % 10)
                {
                    case 0:
                        if (number == 0)
                        {
                            Console.Write("Zero\n");
                        }
                        break;
                    case 1:
                        if (number / 10 % 10 == 1) break;
                        Console.WriteLine("one");
                        break;
                    case 2:
                        if (number / 10 % 10 == 1) break;
                        Console.WriteLine("two");
                        break;
                    case 3:
                        if (number / 10 % 10 == 1) break;
                        Console.WriteLine("three ");
                        break;
                    case 4:
                        if (number / 10 % 10 == 1) break;
                        Console.WriteLine("four");
                        break;
                    case 5:
                        if (number / 10 % 10 == 1) break;
                        Console.WriteLine("five");
                        break;
                    case 6:
                        if (number / 10 % 10 == 1) break;
                        Console.WriteLine("six");
                        break;
                    case 7:
                        if (number / 10 % 10 == 1) break;
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        if (number / 10 % 10 == 1) break;
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        if (number / 10 % 10 == 1) break;
                        Console.WriteLine("nine");
                        break;

                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}