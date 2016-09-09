# https://www.hackerrank.com/challenges/cavity-map
# CavityMap.py
# Raj Nakkiran. Sep 8,2016


def TestCellForCavity(grid,n,x,y):
	if (x == 0) or ( y == 0 ) or ( x == (n -1) ) or ( y == (n - 1)): 
		return False

	top_c = 	grid[y-1][x] 
	left_c =  	grid[y][x-1]
	bottom_c =  	grid[y+1][x]
	right_c =  	grid[y][x+1]

	if ( top_c == 'X' )  or  ( left_c == 'X' )  or  ( bottom_c == 'X' )  or  (right_c == 'X' ):
		return False;

	current = int ( grid[y][x] )

	top = int ( top_c )
	left = int( left_c )
	bottom = int ( bottom_c )
	right = int ( right_c )

	if ((current > top)   and  (current > left)   and  (current > bottom)   and  (current > right)):
		return True

	return False

#
# Main
# 

n_str = input()	   # input().strip() better
n = int ( n_str )  # sq. grid size
grid = []	   # Empty list of strings
for i in range(n):
	grid.append ( input() )


for x in range(n):
	for y in range(n):
		if TestCellForCavity(grid,n,x,y):
			old = list( grid[y] )    	# string to list 
			old[x] = 'X'
			grid[y] = ''.join( old )	# list to string
			
			
		
for y in range(n):
	print( grid[y] )
