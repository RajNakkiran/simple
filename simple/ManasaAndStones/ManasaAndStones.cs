// https://www.hackerrank.com/challenges/manasa-and-stones?h_r=next-challenge&h_v=zen
// Raj Nakkiran. Sep 8.2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManasaAndStones
{
    class ManasaAndStones
    {


        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());    // # test cases
            for (int t = 0; t < T; t++)
            {
                long nn = Convert.ToInt64(Console.ReadLine());  // # stones
                if ( nn == 1 )
                {
                    Console.WriteLine(0);
                    continue;
                }

                long a = Convert.ToInt64(Console.ReadLine());
                long b = Convert.ToInt64(Console.ReadLine());

                List<long> Sums = new List<long>();
                long n = nn - 1;
                for (long x = 0; x <= n ; x++)
                {
                    long s = (x * a) + (n - x) * b;
                    if ( ! Sums.Contains(s))
                    {
                        Sums.Add(s);
                    }
                }

                Sums.Sort();

                foreach (long v in Sums)
                {
                    Console.Write("{0} ", v);
                }
                Console.WriteLine();
            }
        }


    }
}
