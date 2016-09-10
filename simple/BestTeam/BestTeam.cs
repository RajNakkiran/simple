// https://www.hackerrank.com/challenges/acm-icpc-team?h_r=next-challenge&h_v=zen
// Raj Nakkiran. Sep 9,2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BestTeam
{
    class BestTeam
    {

        public class Pair
        {
            public int i;
            public int j;

            public Pair(int ii, int jj)
            {
                i = ii;
                j = jj;
            }
        }

        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);   // nbr of people
            int m = Convert.ToInt32(tokens_n[1]);   // nbr of skills 
           
            object[] topic = new object[n];
            for (int topic_i = 0; topic_i < n; topic_i++)
            {
                string line = Console.ReadLine();   // read skills array for one person
                topic[topic_i] = line.ToCharArray();
            }

            SortedDictionary<int, ArrayList> RankDictionary = new SortedDictionary<int, ArrayList>();

            // Walk the elements of nCr ...
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    // i,j is a Pair now. Find max score for this pair
                    int sum = 0;
                    for (int k = 0; k < m; k++)
                    {
                        char[] TI = (char[])topic[i];
                        char[] TJ = (char[])topic[j];

                        if ((TI[k] == '1') || (TJ[k] == '1'))
                        {
                            sum++;
                        }
                    }

                    //
                    // Save the sum in a dictionary sorted by sum
                    // The value is a list of Pairs<i,j>
                    //
                    if (RankDictionary.ContainsKey(sum))
                    {
                        ArrayList l = RankDictionary[sum];
                        l.Add(new Pair(i, j));
                        RankDictionary[sum] = l;
                    }
                    else
                    {
                        ArrayList l = new ArrayList();
                        l.Add(new Pair(i, j));
                        RankDictionary[sum] = l;
                    }
                }
            }

            // find max sum
            int MaxSum = RankDictionary.Keys.Max();

            // count how may pairs have max sum
            ArrayList ListOfMaxPairs = RankDictionary[MaxSum];

            Console.WriteLine(MaxSum);
            Console.WriteLine(ListOfMaxPairs.Count);
        }


    }
}
