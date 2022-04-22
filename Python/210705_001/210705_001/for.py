
#for02.py
sum = 0
for i in range(1, 11):
	sum+=i
print("sum  %d" % sum)
print("--------------------------------")

#for문을 이용하여 1에서 10까지 식과 합을 구하시오
sum = 0
for j in range(1, 11):
	if j<10:
		print("%d + " %j, end="")
	elif j==10:
		print("%d = "%j, end="")
	sum+=j
print("%d" % sum)      #1에서 10까지 합 출력



'''
#for01.py
for i in range(0, 5):
	print(i)
print("--------------------------------")
for j in[1,3,5,7,9]:
	print(j)
print("--------------------------------")
for k in range(0, 3):
	print("꿈은 이루어진다.")
'''