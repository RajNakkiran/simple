# https://www.hackerrank.com/challenges/kaprekar-numbers
# Raj Nakkiran. Sep 14,2016
p = int ( input().strip() )
q = int ( input().strip() )
NothingFound = True
for i in range(p,q+1):
	sq = i * i
	i_str = str( i )			## int to string
	sq_str = str( sq )
	i_len = len(i_str)			## NOT:  i_str.len()
	sq_len = len(sq_str)
	right_len = i_len
	left_len = sq_len - right_len
	right_str = sq_str[left_len:]		## inclusive start index
	left_str = sq_str[:left_len]		## exclusive end index
	l = 0
	if len(left_str) > 0:
		l = int ( left_str )		## string to int
	r = int ( right_str )
	if i == (l+r):
		print( i, '', end="", flush=True)	## space seperated ints
		NothingFound  = False
if NothingFound:
	print("INVALID RANGE")

