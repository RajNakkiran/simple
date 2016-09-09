// https://www.hackerrank.com/challenges/manasa-and-stones?h_r=next-challenge&h_v=zen
// Raj Nakkiran. Sep 8,2016

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class ManasAndStonesMain {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int T = scanner.nextInt();
		for(int i = 0; i < T; i++)
		{
			long nn = scanner.nextLong(10);
			if ( nn == 1)
			{
				System.out.println(0);
				continue;
			}
			
			long a = scanner.nextLong(10);
			long b = scanner.nextLong(10);
			long n = nn - 1;
			
			List<Long> Sums = new ArrayList<Long>();
			
			for(long x = 0; x <= n; x++)
			{
				long s = ( x * a ) + ( n - x ) * b;
				if ( ! Sums.contains( s ))
				{
					Sums.add(s);
				}
			}
			
			Collections.sort(Sums);
			
			for ( long v: Sums)
			{
				// longs are also digits.
				System.out.printf("%d ", v);
			}
			System.out.println();
		}

	}

}
