// https://www.hackerrank.com/challenges/extra-long-factorials
// Raj Nakkiran. Sep 11,2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace BigIntFactorial
{
    class BigIntFactorial
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if ( n <= 1 )
            {
                Console.WriteLine(1);
                return;
            }

            BigInteger factorial = new BigInteger(1);
            for (int i = 2; i < (n + 1); i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);

        }
    }
}
