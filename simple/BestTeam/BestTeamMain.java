// BestTeam.java -- https://www.hackerrank.com/challenges/acm-icpc-team
// Sep 10,2016 Raj Nakkiran

import java.util.Scanner;
import java.util.TreeMap;

public class BestTeamMain {

	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		int n = scanner.nextInt();		// # of people
		int m = scanner.nextInt();      // # of skills
		String[] topic = new String[n];
		for(int ti = 0; ti < n; ti++)
		{
			topic[ti] = scanner.next();   // skills bitmap for ith person.  len = m 
		}
		scanner.close();
		
		// Key = Sum of skills(score) for a pair of people. value is the count of teams with that score.
		TreeMap<Integer,Integer> RankDictionary = new TreeMap<Integer,Integer>();
		
		// Walk thru nCr combinations of people
		for(int i = 0; i < n; i++ )
		{
			for(int j = i + 1; j < n; j++)
			{
				// Considering the  pair <i,j>
				
				int sum = 0;
				for(int k = 0; k < m; k++)
				{
					if (  (  topic[i].charAt(k) == '1') ||  (  topic[j].charAt(k) == '1') )
					{
						sum++;
					}
				}
				
				if ( RankDictionary.containsKey(sum) )
				{
					int tmp = RankDictionary.get(sum) + 1;
					RankDictionary.put(sum, tmp);					
				}
				else
				{
					RankDictionary.put(sum, 1);
				}
				
			}
		}
		
		// print results
		int maxScore = RankDictionary.lastKey() ;
		int maxTeams = RankDictionary.get(maxScore);
		System.out.printf("%d\n", maxScore );		// max score possible with 2 person team
		System.out.printf("%d\n", maxTeams );		// number of teams with sum score
		
	}

}
