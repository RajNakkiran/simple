// https://www.hackerrank.com/challenges/cavity-map
// Raj Nakkiran. Sep 7,2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CavityMap
{
    class CavityMap
    {

        // grid[] cells will have 1..9  or X 
        static bool TestCellForCavity(string[] grid, int n, int x, int y)
        {
            // border cells are not.
            if ((x == 0) || (y == 0) || (x == (n - 1)) || (y == (n - 1)))
            {
                return false;
            }

            string cur_char = grid[y].Substring(x, 1);
            if (cur_char.Equals("X"))
            {
                // already marked as Cavity
                return true;
            }

            // 1..9
            int current = Convert.ToInt32(cur_char);

            string top_char = grid[y-1].Substring(x, 1);    // strings really
            string left_char = grid[y].Substring(x-1, 1);
            string bottom_char = grid[y+1].Substring(x, 1);
            string right_char = grid[y].Substring(x+1, 1);

            // If any neighbor is a cavity, this cannot be.  cavity is strictly deeper.
            if (top_char.Equals("X") || left_char.Equals("X") || bottom_char.Equals("X") || right_char.Equals("X"))
            {
                return false;
            }

            int top = Convert.ToInt32(top_char);
            int left = Convert.ToInt32(left_char);
            int bottom = Convert.ToInt32(bottom_char);
            int right = Convert.ToInt32(right_char);

            if ((current > top) && (current > left) && (current > bottom) && (current > right))
            {
                return true;
            }

            return false;

        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] grid = new string[n];
            for (int grid_i = 0; grid_i < n; grid_i++)
            {
                grid[grid_i] = Console.ReadLine();      // Each cell = 1..9 
            }

            int x, y;

            for (x = 0; x < n; x++)
            {
                for (y = 0; y < n; y++)
                {
                    if (TestCellForCavity(grid, n, x, y))
                    {
                        char[] old = grid[y].ToCharArray();
                        old[x] = 'X';
                        grid[y] = new string(old);   // NOTE:  old.ToString() is incorrect !!!
                    }
                }
            }

            for (y = 0; y < n; y++)
            {
                Console.WriteLine(grid[y]);
            }

        }

    }
}
