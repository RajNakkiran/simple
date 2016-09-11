# BigIntFactorial.py
# https://www.hackerrank.com/challenges/extra-long-factorials
# Raj Nakkiran. Sep 11,2016  -- NOTE: Automatic BigInt in Python 2.5+

import sys

n = int(input().strip())
if n <= 1:
	print(1)
	exit()
factorial = 1
for i in range(2,n+1):
	factorial *= i
print( factorial )

