// Raj Nakkiran.  Sep 28,2016

public class PamidromeCheeckerMain {

	public static boolean IsPalindrome(String s)
	{
		
		char[] ca  =  s.toLowerCase().replace(" ", "").toCharArray();	// 1:1 with C#
		int start = 0;
        int end = ca.length - 1;

        while (start < end)
        {
            if (ca[start] != ca[end]) return false;
            start++;
            end--;
        }

        return true;
	}
	
	public static void Check(String s, boolean shouldBePalindrome)
    {
       System.out.println(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
    }
	
	public static void main(String[] args) 
	{
		
		Check("abcba", true);
        Check("abcde", false);
        Check("Mr owl ate my metal worm", true);
        Check("Never Odd Or Even", true);
        Check("Never Even Or Odd", false);

	}

}
