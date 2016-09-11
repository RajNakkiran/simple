import java.util.Scanner;
import java.math.*;

// https://www.hackerrank.com/challenges/extra-long-factorials?h_r=next-challenge&h_v=zen
// Raj Nakkiran. Sep 11,2016

public class BigIntFactorialMain {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        in.close();
        
        if ( n <= 1)
        {
        	System.out.println( 1 );
        	return;
        }
        
        BigInteger factorial = BigInteger.ONE;
        for(   BigInteger i = BigInteger.valueOf(2) ; i.compareTo(BigInteger.valueOf(n+1)) == -1  ;  i =  i.add( BigInteger.ONE))
        {
        	factorial = factorial.multiply( i );		// NOTE:  need to assign, NOT an op on object, but result is retuned.
        }
        System.out.println( factorial );
	}

}
