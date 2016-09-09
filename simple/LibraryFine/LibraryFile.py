# Calculate Library Fine
# Raj Nakkiran. Sep 1,2016

import datetime

#
# Read stdin
#
return_date_str = input()   # day month year
due_date_str    = input()   # day month year

#
#  Split to tokens array
#
return_date = return_date_str.split()
due_date = due_date_str.split()

#
#  String to Int conversion
#
r_day = int( return_date[0] )
r_month = int ( return_date[1] )
r_year = int ( return_date[2] )

d_day = int ( due_date[0] )
d_month = int ( due_date[1] )
d_year = int ( due_date[2] )

#
# DateTime objects
# 
return_dt = datetime.date( r_year, r_month, r_day )
due_dt = datetime.date( d_year, d_month, d_day )

print( "Return = ", return_dt )
print( "Due    = ", due_dt )

if return_dt <= due_dt:
	# No Fine
	print ( 0 )
	exit()

if return_dt.year > due_dt.year:
	# Years late. Fixed Fine
	print( 100000 )
	exit()

if return_dt.month > due_dt.month:
	# months late
	print ( ( return_dt.month - due_dt.month ) * 500 )
	exit()

# Days late
print ( ( return_dt.day - due_dt.day ) * 15 )






