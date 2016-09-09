// https://www.hackerrank.com/challenges/library-fine
// Raj Nakkiran. Sep 1,2016

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LibraryFine
{
    class Solution
    {
        static void Main(string[] args)
        {
            string[] tokens_d1 = Console.ReadLine().Split(' ');
            int d1 = Convert.ToInt32(tokens_d1[0]);
            int m1 = Convert.ToInt32(tokens_d1[1]);
            int y1 = Convert.ToInt32(tokens_d1[2]);
            string[] tokens_d2 = Console.ReadLine().Split(' ');
            int d2 = Convert.ToInt32(tokens_d2[0]);
            int m2 = Convert.ToInt32(tokens_d2[1]);
            int y2 = Convert.ToInt32(tokens_d2[2]);

            DateTime ReturnDate = new DateTime(y1, m1, d1);
            DateTime DueDate = new DateTime(y2, m2, d2);

            // No Fine
            if (DueDate >= ReturnDate)
            {
                Console.WriteLine(0);
                return;
            }

           
            // More than year old. Fixed fine
            if (ReturnDate.Year > DueDate.Year)
            {
                Console.WriteLine(10000);
                return;
            }


            //
            // Same Year. 
            //
            int Fine = 0;

            if (ReturnDate.Month > DueDate.Month)
            {
                // Months late
                Fine = (ReturnDate.Month - DueDate.Month) * 500;
                Console.WriteLine("{0}", Fine);
                return;
            }


            //
            // Same Month
            // 
            Fine = (ReturnDate.Day - DueDate.Day) * 15;
            Console.WriteLine("{0}", Fine);
            return;
        }
    }
}
