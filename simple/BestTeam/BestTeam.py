# https://www.hackerrank.com/challenges/acm-icpc-team
# Raj Nakkiran. Sep 10,2016
# 3 tests passed and 5 tests timed out. May be there is some inefficiency here !

import sys
import collections

n,m = input().strip().split(' ')
n,m = [int(n),int(m)]
topic = []
topic_i = 0
for topic_i in range(n):
   topic_t = str(input().strip())
   topic.append(topic_t)

d = collections.defaultdict(int)	## least documented ; dict with int key !!

for i in range(n):
	for j in range(i+1, n):
		sum = 0
		for k in range(m):
			if (topic[i][k] == '1') or  (topic[j][k] == '1'):
				sum += 1	# not sum++
		d[sum] += 1

maxScore = max(d , key=int)
maxTeams = d[maxScore]
print( maxScore )
print( maxTeams )

