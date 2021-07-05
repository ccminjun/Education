dict = {'번호' :10, '성명':'장동건', '나이':23, '사는곳':'서울'}

print(dict)
print(type(dict))
print(dict['나이'])
dict['나이']=24
print(dict['나이'])
dict['직업']='배우'
print(dict)
print(dict.keys())
#print(key[0]) 지원 안함
print(dict.values())
print('사는곳' in dict)
del dict['사는곳']
print('사는곳' in dict)
print(dict)
