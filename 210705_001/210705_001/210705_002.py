#list06
aa = [[1,2,3,4],
	  [5,6,7,8],
	  [9,10,11,12]]
print(aa[0][0])
print(aa[0])
print(aa[1][2])
print(aa)
print("aa[1] = %s" %aa[1])
print("aa[2] = %s" %aa[2])
print("aa[2][0] = %s" %aa[2][0])
print("aa[2][0]aa[2][1]aa[2][2]aa[2][3] = %d,%d,%d,%d" %(aa[2][0],aa[2][1],aa[2][2],aa[2][3]))
print("aa[2][2]~aa[2][3] = %s" %aa[2][1:3])
print("aa[0:2] = %s" %aa[0:2])


'''
#list05
aa = [30, 10, 20]
print(type(aa))                                      # type은 list가 나온다.
print("현재의 리스트 : %s" %aa)

aa.append(40)                                        # 요소 하나 추가
print("append 후의 리스트 : %s" % aa)
zz=aa.pop()                                             # aa 리스트의 제일 마지막 요소 뺸다. stack 알고리즘 적용
print("pop 후의 리스트 : %s" % aa) 
print("리스트에서 꺼낸 값 : %s" %zz)
aa.sort()                                            # 오름차순
print("sort 후의 리스트 : %s" % aa)
aa.reverse()                                         # 내림차순
print("reverse 후의 리스트 : %s" % aa)
aa.insert(2, 222)                                    # 세번째 위치에 222 추가
print("insert(2, 222) 후의 리스트 : %s" % aa)
print("20값의 위치 : %d" %aa.index(20))
aa.remove(222)                                       # 222제거
print("remove(222) 후의 리스트 : %s" %aa)
aa.extend([77, 88, 77])                              # 리스트 확장
print("extend([77,88,77]) 후의 리스트 : %s" %aa)
print("77값의 개수 : %d" %aa.count(77))
'''




'''
#list04
aa = [10, 20, 30, 40]
print("aa[-1]은 %d, aa[-2]는 %d" % (aa[-1], aa[-2]))

print(aa[0:2])
print(aa[2:4])
print(aa[0:])

print('aa= %d,%d,%d,%d' %(aa[-4],aa[-3],aa[-2],aa[-1]))
print('aa= %d,%d,%d,%d' %(aa[0],aa[1],aa[2],aa[3]))
# 상한선 에러 : print(aa[4])
# 하안선 에러 : print(aa[-5])
'''