#turple03
card = 'red', 4, 'python', True        # card 튜플을 다양한 타입의 요소로 선언 [] 대입해서 리스트 만들어도 동일
a, b, c, d = card
print(a)
print(b)
print(c)
d = False                              # d 변수값을 수정
print(d)



'''
# turple02
one = '하나'           
print(type(one))        
one = "원"
print(one)

two = '둘'
print(type(two))
#two[0] = '투'
print(two[0])
'''



'''
# turple01
str = "파이썬 문자열"                # 문자열은 튜플이다.
print(str[0])                        # List처럼 동작함
print(str[-1])                       # List처럼 동작함
#str[0] = '와'                       # List가 아님을 알 수 있음
card = 'red', 4, 'python', True      # Turple 선언
card = ['red', 4, 'python', True]    # List 선언
print(card)
print(card[1])
card[0] = 'blue'                     # List일때는 에러가 안나지만 Turple일때는 에러가 남
'''