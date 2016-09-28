# Palindrome Checker 
# Raj Nakkiran. Sep 28,2016

import string

def IsPalindome(s):
	ca = s.lower().replace(" ", "" )	# string ca can be accesses as char array only in Python & C.
	start = 0
	end = len( ca ) - 1
	while start < end:
		if ca[start] != ca[end]:
			return False
		start += 1
		end   -= 1
	return True

def Check(s,shouldBePalindrome):
	if IsPalindome(s) == shouldBePalindrome:
		print("pass")
	else:
		print("FAIL")


Check("abcba", True);
Check("abcde", False);
Check("Mr owl ate my metal worm", True);
Check("Never Odd Or Even", True);
Check("Never Even Or Odd", False);		


	