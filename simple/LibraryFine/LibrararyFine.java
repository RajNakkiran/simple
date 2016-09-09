// Raj Nakkiran. Sep 2,2016

import java.util.Date;
import java.util.Scanner;

public class LibrararyFine
{	
	@SuppressWarnings("deprecation")
	public static void main(String[] args) 
	{
		// System.out.println("Enter 6 ints");
		Scanner scanner = new Scanner(System.in);
		
		// read return data
		int d1 = scanner.nextInt();
		int m1 = scanner.nextInt();
		int y1 = scanner.nextInt();
		
		// read due date
		int d2 = scanner.nextInt();
		int m2 = scanner.nextInt();
		int y2 = scanner.nextInt();
		scanner.close();
		
		Date ret = new Date();
		ret.setDate(d1);
		ret.setMonth(m1);
		ret.setYear(y1);
		
		Date due = new Date();
		due.setDate(d2);
		due.setMonth(m2);
		due.setYear(y2);
		
		// No Fine
		if ( due.equals ( ret )  ||   due.after( ret ))
		{
			System.out.println(0);
			return;
		}
		
		// More than a year. Fixed Fine
		if( ret.getYear() > due.getYear() )
		{
			System.out.println(10000);
			return;
		}
		
		//
		// Same Year
		//
		
		if ( ret.getMonth() > due.getMonth() )
		{
			System.out.println(  ( ret.getMonth() - due.getMonth() ) * 500  );
			return;
		}
		
		//
		//  Same Month
		// 
		System.out.println(  ( ret.getDay() - due.getDay() ) * 15  );
		
	}

}
