// https://www.hackerrank.com/challenges/kaprekar-numbers
// Raj Nakkiran. Sep 14,2016


import java.util.Scanner;

public class KaprekarNumbersMain {

	public static void main(String[] args) 
	{
		boolean NothingFound = true;
		 
		Scanner in = new Scanner(System.in);
        long  p = in.nextLong();
        long  q = in.nextLong();
        in.close();
        
        for (long i = p; i <= q; i++)
        {
            long sq = i * i;
            
            String i_str = String.format("%d", i);
            String sq_str = String.format("%d", sq);
            
            int i_len = i_str.length();
            int sq_len = sq_str.length();
            int  right_len = i_len;
            int  left_len  = sq_len - right_len;
            String right_str = sq_str.substring(left_len);      // cannot be empty
            String left_str = sq_str.substring(0, left_len);    // empty for i = 1
            long l = 0;
            if ( ! left_str.isEmpty() )
            {
                l = Long.parseLong(left_str);
            }
            long r = Long.parseLong(right_str);

            if (i == l + r)
            {
                System.out.printf("%d ", i );
                NothingFound = false;
            }
        }
        if (NothingFound)
        {
        	System.out.printf("INVALID RANGE");
        }
        
        

	}
}
