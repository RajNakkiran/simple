// Raj Nakkiran.  Aug 17,2016
// raj_nakkiran@msn.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeChecker
{
    class PalindromeChecker
    {

        static bool IsPalindrome(string s)
        {
            char[] ca = s.ToLower().Replace(" ", string.Empty).ToCharArray();
            int start = 0;
            int end = ca.Length - 1;

            while (start < end)
            {
                if (ca[start] != ca[end]) return false;
                start++;
                end--;
            }

            return true;

        }

        static void Check(string s, bool shouldBePalindrome)
        {
            Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
        }
 

        static void Main(string[] args)
        {
            Check("abcba", true);
            Check("abcde", false);
            Check("Mr owl ate my metal worm", true);
            Check("Never Odd Or Even", true);
            Check("Never Even Or Odd", false);
        }
    }
}
