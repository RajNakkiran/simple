# CaesarsCipher.py
# Raj Nakkiran. Sep 3,2016

char_count_str = input()
input_str = input()
shift_key_str = input()
char_count = int( char_count_str )
k = int( shift_key_str )

alpha = "abcdefghijklmnopqrstuvwxyz"
ALPHA = alpha.upper()

for i in range( char_count ):
	c = input_str[i] 
	j = alpha.rfind(c)
	if j != -1:
		print( alpha [ (j + k ) % 26 ], end="", flush=True)
		continue
	j = ALPHA.rfind(c)
	if  j != -1:
		print( ALPHA [ (j + k ) % 26 ], end="", flush=True)
		continue			
	print( c, end="", flush=True)	
		
