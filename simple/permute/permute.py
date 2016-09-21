# permute.py 
# Raj Nakkiran. Sep 19,2016

def splits(word):
	" split word into all possible sub-words"
	" Returns list of tuples [(L,R)  (L,R)  (L,R)]"
	return [ (word[:i], word[i:] ) for i in range( len(word) + 1 ) ]

def insert(c,word):
	"Insert c in all possible locations of word"
	" Returns a list of strings "
	return [ L + c + R for L,R in splits(word) ] 

#	ret = []
#	for L,R in splits(word):
#		ret.append(  L + c + R )
#	return ret

def permute(word):
	" Find all permutations of word - by considering the arrival of char at the end one by one"
	" Returns a list of strings "
	if len(word) == 0:
		return []
	if len(word) == 1:
		return [word]
	if len(word) == 2:
		return [ word,  word[1] + word[0] ]
	#
	# Assume:  word = prefix + last_char
	#
	# get last char
	c = word[ len(word) -1 : ]
	# get prefix ( ie. w/o last char)
	prefix = word[: len(word)-1 ]
	# some how get all permutaions of the prefix, ie. the word before the last char arrived.
	prev = permute(prefix)
	# Now add the newly arrived last char to all permutations of the prefix
	ret = []
	for s in prev:
		ret += insert(c, s)
	return ret


# Test 1: print tuples 	
print ( splits('abcd'))
for L,R in splits('abcd' ):
	print ( L, R )

# Test 2: Print splicing of a char in-between two strings
c='x'
for L,R in splits('pqrs' ):
	print ( L + c + R )

# Test3: splining using insert()
print ( insert('1', '5678'))

# Final Test: permute a word.
print ( permute('abcd') )
