using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class GameOfLife
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[10,10];
            int[,] newMatrix = new int[10,10];
            int count = 0;

            for (int k = 0; k < n; k++)
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                
                matrix[x,9 - y] = 1;
            }

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                count = 0;
                    if (matrix[x, y] == 1)
                    {
                        if (x - 1 >= 0 && x - 1 <= 9 && y - 1 >= 0 && y - 1 <= 9)
                        {
                            if (matrix[x - 1, y - 1] == 1)
                            {
                                count++;
                            }
                        }
                        if (x - 1 >= 0 && x - 1 <= 9)
                        {
                            if (matrix[x - 1, y] == 1)
                            {
                                count++;
                            }
                        }
                        if (x - 1 >= 0 && x - 1 <= 9 && y + 1 >= 0 && y + 1 <= 9)
                        {
                            if (matrix[x - 1, y + 1] == 1)
                            {
                                count++;
                            }
                        }
                        if (y - 1 >= 0 && y - 1 <= 9)
                        {
                            if (matrix[x, y - 1] == 1)
                            {
                                count++;
                            }
                        }
                        if (y + 1 >= 0 && y + 1 <= 9)
                        {
                            if (matrix[x, y + 1] == 1)
                            {
                                count++;
                            }
                        }
                        if (x + 1 >= 0 && x + 1 <= 9 && y - 1 >= 0 && y - 1 <= 9)
                        {
                            if (matrix[x + 1, y - 1] == 1)
                            {
                                count++;
                            }
                        }
                        if (x + 1 >= 0 && x + 1 <= 9)
                        {
                            if (matrix[x + 1, y] == 1)
                            {
                                count++;
                            }
                        }
                        if (x + 1 >= 0 && x + 1 <= 9 && y + 1 >= 0 && y + 1 <= 9)
                        {
                            if (matrix[x + 1, y + 1] == 1)
                            {
                                count++;
                            }
                        }
                        if (count >= 2 && count <= 3)
                        {
                            newMatrix[x, y] = 1;
                        }
                    }
                    else if (matrix[x, y] == 0)
                    {
                        if (x - 1 >= 0 && x - 1 <= 9 && y - 1 >= 0 && y - 1 <= 9)
                        {
                            if (matrix[x - 1, y - 1] == 1)
                            {
                                count++;
                            }
                        }
                        if (x - 1 >= 0 && x - 1 <= 9)
                        {
                            if (matrix[x - 1, y] == 1)
                            {
                                count++;
                            }
                        }
                        if (x - 1 >= 0 && x - 1 <= 9 && y + 1 >= 0 && y + 1 <= 9)
                        {
                            if (matrix[x - 1, y + 1] == 1)
                            {
                                count++;
                            }
                        }
                        if (y - 1 >= 0 && y - 1 <= 9)
                        {
                            if (matrix[x, y - 1] == 1)
                            {
                                count++;
                            }
                        }
                        if (y + 1 >= 0 && y + 1 <= 9)
                        {
                            if (matrix[x, y + 1] == 1)
                            {
                                count++;
                            }
                        }
                        if (x + 1 >= 0 && x + 1 <= 9 && y - 1 >= 0 && y - 1 <= 9)
                        {
                            if (matrix[x + 1, y - 1] == 1)
                            {
                                count++;
                            }
                        }
                        if (x + 1 >= 0 && x + 1 <= 9)
                        {
                            if (matrix[x + 1, y] == 1)
                            {
                                count++;
                            }
                        }
                        if (x + 1 >= 0 && x + 1 <= 9 && y + 1 >= 0 && y + 1 <= 9)
                        {
                            if (matrix[x + 1, y + 1] == 1)
                            {
                                count++;
                            }
                        }
                        if ( count == 3)
                        {
                            newMatrix[x, y] = 1;
                        }
                    }
                }
            }
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Console.Write(newMatrix[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
