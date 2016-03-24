using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class PetarsGame
{
    static void Main()
    {
        BigInteger startNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger endNumber = BigInteger.Parse(Console.ReadLine());

        string symbol = Console.ReadLine();
        BigInteger sum = 0;
        for (BigInteger i = startNumber; i < endNumber; i++)
        {
            if (i % 5 == 0)
            {
                sum+= i;
            }
            else
                sum += i % 5;
        }
        string newSum = sum.ToString();
        List<string> result = new List<string>();
        if (sum % 2 == 0)
        {
            for (int i = 0; i < newSum.Length; i++)
            {
                if (newSum[i] == newSum[0])
                {
                    result.Add(symbol);
                }
                else
                    result.Add(newSum[i].ToString());
            }
        }
        if (sum % 2 != 0)
        {
            for (int i = 0; i < newSum.Length; i++)
            {
                if (newSum[i] == newSum[newSum.Length-1])
                {
                    result.Add(symbol);
                }
                else
                    result.Add(newSum[i].ToString());
            }
        }
        foreach (var item in result)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}

