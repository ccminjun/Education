str = "꿈은 이루어 진다."
i = 0
while i<3:
		print(str)
		i = i + 1
Smart = True
print(type(Smart))
print(Smart)
Smart=bool(100000) # true 나오는 걸 알 수 있다. 0만 거짓

print("---------------------------------")
i = int(input("반복 횟수 숫자를 입력하십시오."))
j = 1
flag = True
while flag:
		j = j+1
		if i<j:
			flag = False
		print(str)