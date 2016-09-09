﻿// https://www.hackerrank.com/challenges/caesar-cipher-1
// Raj Nakkiran. Sep 3,2016

#if false
Sep 3,2016 

Julius Caesar protected his confidential information by encrypting it in a cipher. \
Caesar's cipher rotated every letter in a string by a fixed number, , 
making it unreadable by his enemies. Given a string, , and a number, , encrypt  and print the resulting string.

Note: The cipher only encrypts letters; symbols, such as -, remain unencrypted.

Input Format

The first line contains an integer, , which is the length of the unencrypted string. 
The second line contains the unencrypted string, . 
The third line contains the integer encryption key, , which is the number of letters to rotate.

Constraints 
 is a valid ASCII string and doesn't contain any spaces.

Output Format
For each test case, print the encoded string.
Sample Input
11
middle-Outz
2
Sample Output
okffng-Qwvb
Explanation

Each unencrypted letter is replaced with the letter occurring  spaces after it when listed alphabetically. 
Think of the alphabet as being both case-sensitive and circular; if  rotates past the end of the alphabet, 
it loops back to the beginning (i.e.: the letter after  is , and the letter after  is ).

Selected Examples: 
 (ASCII 109) becomes  (ASCII 111). 
 (ASCII 105) becomes  (ASCII 107). 
 remains the same, as symbols are not encoded. 
 (ASCII 79) becomes  (ASCII 81). 
 (ASCII 122) becomes  (ASCII 98); because  is the last letter of the alphabet,  
(ASCII 97) is the next letter after it in lower-case rotation.
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaesarsCipher
{
    class CaesarsCipher
    {
        // -1 of not found
        static int indexOf(char c, char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (c == array[i])
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {

            string alpha = "abcdefghijklmnopqrstuvwxyz";
            string ALPHA = alpha.ToUpper();

            char[] a = alpha.ToCharArray();
            char[] A = ALPHA.ToCharArray();

            int n = Convert.ToInt32(Console.ReadLine());        // NOT USED
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            char[] S = s.ToCharArray();

            for (int i = 0; i < S.Length; i++)
            {
                char c = S[i];

                // Lower case ?
                int x = indexOf(c, a);
                if (x != -1)
                {
                    Console.Write(a[(x + k) % 26]);
                    continue;
                }

                // Upper case ?
                x = indexOf(c, A);
                if (x != -1)
                {
                    Console.Write(A[(x + k) % 26]);
                    continue;
                }

                // Not a letter 
                Console.Write(c);
            }
        }
    }
}
