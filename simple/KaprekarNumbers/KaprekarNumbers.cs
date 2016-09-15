// https://www.hackerrank.com/challenges/kaprekar-numbers
// Raj Nakkiran. Sep 14,2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaprekarNumbers
{
    class KaprekarNumbers
    {
        static void Main(string[] args)
        {
            bool NothingFound = true;

            Int64 p = Convert.ToInt64(Console.ReadLine());
            Int64 q = Convert.ToInt64(Console.ReadLine());
            for (Int64 i = p; i <= q; i++)
            {
                Int64 sq = i * i;
                string i_str = string.Format("{0}", i);
                string sq_str = string.Format("{0}", sq);
                int i_len = i_str.Length;
                int sq_len = sq_str.Length;
                int  right_len = i_len;
                int  left_len  = sq_len - right_len;
                string right_str = sq_str.Substring(left_len);      // cannot be empty
                string left_str = sq_str.Substring(0, left_len);    // empty for i = 1
                Int64 l = 0;
                if ( ! string.IsNullOrEmpty(left_str))
                {
                    l = Convert.ToInt64(left_str);
                }
                Int64 r = Convert.ToInt64(right_str);

                if (i == l + r)
                {
                    Console.Write("{0} ", i);
                    NothingFound = false;
                }
            }
            if (NothingFound)
            {
                Console.WriteLine("INVALID RANGE");
            }
            
        }
    }
}
