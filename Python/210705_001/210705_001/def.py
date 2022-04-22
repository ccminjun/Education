def smart():
	a = int(input("숫자1을 입력하세요 : "))
	b = int(input("숫자2을 입력하세요 : "))
	return a + b

c = smart()
print("결과는 %d 입니다." %c)






'''
def mydef01():
	i = 10
	j = 20
	print(i+j)
mydef01()
def mydef02(i, j):
	print(i+j)
mydef02(10,20)

#계산할 숫자를 두 개 입력합니다.
def mydef03(i, j, p):
	if p == '+':
		print(i+j)
	elif p == '-':
		print(i-j)
	elif p == '*':
		print(i*j)
	elif p == '/':
		print(i/j)
n = int(input("첫 번째 숫자를 입렵합니다."))
m = int(input("두 번째 숫자를 입렵합니다."))
p = input("연산자를 입력하세요(+, -, *, /)")
mydef03(n,m,p)
'''

'''
#def01.py
def mydef01():
	print("함수를 선언합니다.")
mydef01()
def mydef02(str="인수함수를 선언합니다."):
	print(str)
mydef02()
mydef02("인수를 넣습니다")
'''




'''
def mydef():
	print("여기는 함수 내부입니다1")
	print("여기는 함수 내부입니다2")
	print("여기는 함수 내부입니다3")

print("여기가 시작인가요??")
mydef()
print("여기가 끝인가요?")
'''