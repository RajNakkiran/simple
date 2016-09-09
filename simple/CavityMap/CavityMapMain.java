// https://www.hackerrank.com/challenges/cavity-map
// Raj Nakkiran. Sep 7,2016

import java.util.Scanner;

public class CavityMapMain 
{
	
	static boolean TestCellForCavity( String[] grid, int n, int x, int y)
	{
		// border cells are not.
        if ((x == 0) || (y == 0) || (x == (n - 1)) || (y == (n - 1)))
        {
            return false;
        }
        
        char cur_char = grid[y].charAt(x);
        if ( cur_char == 'X')
        {
        	// already marked
        	return true;
        }
        
        char top_char = grid[y-1].charAt(x);
        char left_char = grid[y].charAt(x-1);
        char bottom_char = grid[y+1].charAt(x);
        char right_char = grid[y].charAt(x+1);
        
        // If any neighbor is a cavity, this cannot be.  cavity is strictly deeper.
        if ( (top_char == 'X') || (left_char == 'X') || (bottom_char == 'X') || (right_char == 'X') )
		{
        	return false;
		}
        
        int current =  Character.getNumericValue( cur_char);
        int top =  Character.getNumericValue( top_char);
        int left =  Character.getNumericValue( left_char);
        int bottom =  Character.getNumericValue( bottom_char);
        int right =  Character.getNumericValue( right_char);
        
        if ((current > top) && (current > left) && (current > bottom) && (current > right))
        {
            return true;
        }

        return false;
        
	}

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int n = scanner.nextInt();
		String[] grid = new String[n];
		for(int i = 0; i < n; i++)
		{
			grid[i] = scanner.next();
		}
		
		
		int x, y;

        for (x = 0; x < n; x++)
        {
            for (y = 0; y < n; y++)
            {
                if (TestCellForCavity(grid, n, x, y))
                {
                	// C#
                    // char[] old = grid[y].ToCharArray();
                    // old[x] = 'X';
                    // grid[y] = new string(old);   
                	
                	// Java
                	StringBuilder old = new StringBuilder( grid[y]);
                	old.setCharAt(x, 'X');
                	grid[y] = old.toString();
                }
            }
        }

        for (y = 0; y < n; y++)
        {
            System.out.println(grid[y]);
        }
        

	}

}
