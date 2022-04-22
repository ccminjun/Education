class AutoMobile:                                   # 클래스 선언
	name = ""                                       # 객체의 문자열 속성 선언
	velocity = 0                                    # 객체의 숫자 속성 선언 
	def velocityPlus(self):                         # 객체 기능인 메소드 선언 
		self.velocity = self.velocity + 1          
		print("속도는 %d 입니다." % self.velocity)
	def velocityDw(self):                   
		self.velocity = self.velocity - 1           # 객체 기능인 메소드 선언
		if self.velocity < 0:
		    self.velocity = 0
		print("속도는 %d 입니다." % self.velocity)

ac = AutoMobile()                                   # 객체 생성
ac.velocityPlus()                                   # 메소드 호출
ac.velocity = 20                                    # 객체 속성에 값을 대입
ac.velocityDw()                                     # 메소드 호출
	