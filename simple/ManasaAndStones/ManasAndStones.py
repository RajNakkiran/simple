# ManasAndFriends.py
# https://www.hackerrank.com/challenges/manasa-and-stones?h_r=next-challenge&h_v=zen
# Raj Nakkiran. Sep 8,2016

T = int ( input() )	# nbr of test cases
for i in range( T ):
	nn = int( input() )	# no long()
	a  = int( input() )
	b  = int( input() )
	if nn == 1:
		print( 0 )
		continue
	n = nn - 1
	Sums = []
	for x in range(n+1):
		s = ( x * a ) + (n-x) * b
		if not (s in Sums):
			Sums.append( s )
	
	Sums.sort()
	
	for v in Sums:
		print( v , '', end="", flush=True)	#  ' ' is bad.  '' is OK.
	print()

	