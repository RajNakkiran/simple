// https://www.hackerrank.com/challenges/the-grid-search
// Raj Nakkiran. Sep 6,2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GridSearch
{
    class GridSearch
    {

        static bool Confirm(string[] G, string[] P, int g, int found_col)
        {
            int p;
            for ( p = 0; (p < P.Length ) &&  (g < G.Length)  ; p++, g++)
            {
                string currentG = G[g].Substring(found_col);
                int found2 = currentG.IndexOf(P[p]);
                if( found2 != 0 )
                {
                    return false;
                }
            }

            if (p == P.Length)
            {
                return true;
            }

            return false;
        }

        static bool Contains(string[] G, string[] P, int g)
        {
            if ( g >= G.Length )
            {
                return false;
            }

            while (g < G.Length)
            {
                // look for 1st pattern 
                int found_col = G[g].IndexOf(P[0]);
                if (found_col != -1)
                {
                    bool confirmed =  Confirm(G,P, g, found_col );
                    if (confirmed)
                    {
                        return true;
                    }

                    // There might be another instance in the same row !!!
                    for (int i = found_col+1; i < G[g].Length; i++)
                    {
                        string currentG = G[g].Substring(i);
                        int found2 = currentG.IndexOf(P[0]);
                        if (found2 != -1)
                        {
                            bool confirmed2 = Confirm(G, P, g, found2);
                            if (confirmed2)
                            {
                                return true;
                            }
                        }
                    }
                    // 

                }
                g++;
            }

            return false;

        }
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());    // #tests 
            for (int a0 = 0; a0 < t; a0++)
            {
                //
                //   Search for P in G
                //
                string[] tokens_R = Console.ReadLine().Split(' ');
                int R = Convert.ToInt32(tokens_R[0]);
                int C = Convert.ToInt32(tokens_R[1]);
                string[] G = new string[R];
                for (int G_i = 0; G_i < R; G_i++)
                {
                    G[G_i] = Console.ReadLine();
                    if (G[G_i].Length != C)
                    {
                        G[G_i] = G[G_i].Substring(0, C);
                    }
                }
                string[] tokens_r = Console.ReadLine().Split(' ');
                int r = Convert.ToInt32(tokens_r[0]);
                int c = Convert.ToInt32(tokens_r[1]);
                string[] P = new string[r];
                for (int P_i = 0; P_i < r; P_i++)
                {
                    P[P_i] = Console.ReadLine();
                    if (P[P_i].Length != c)
                    {
                        P[P_i] = P[P_i].Substring(0, c);
                    }
                }

                if ( Contains( G, P,0) )
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }


                //
                // End Search 
                //

            }
        }
    }
}
