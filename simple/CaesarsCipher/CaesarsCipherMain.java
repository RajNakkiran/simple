// Raj Nakkiran. Sep 3,2016

import java.util.Scanner;

public class CaesarsCipherMain {

	public static void main(String[] args) 
	{
		Scanner scanner = new Scanner(System.in);
		int char_count = scanner.nextInt();
		String input_str = scanner.next();
		int k = scanner.nextInt();
		
		String alpha = "abcdefghijklmnopqrstuvwxyz";
		String ALPHA = alpha.toUpperCase();
		
		for(int i = 0; i < input_str.length(); i++)
		{
			char c = input_str.charAt(i);
			int j = alpha.indexOf(c);
			if ( j != -1)
			{
				System.out.printf( "%c", alpha.charAt(   (j + k ) % 26 ));
				continue;
			}
			
			j = ALPHA.indexOf(c);
			if ( j != -1)
			{
				System.out.printf( "%c", ALPHA.charAt(   (j + k ) % 26 ));
				continue;
			}
			
			System.out.printf( "%c",c);
		 	
		}
		
	}

}
