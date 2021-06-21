<br/>
<p align="center">
    <a href="https://github.com/boomini/RentcarProject" target="_blank">
        <img width="50%" src="https://user-images.githubusercontent.com/60223013/121276963-9add9180-c90a-11eb-852c-caaad97c071b.PNG" alt="Sulu logo">
    </a>
</p>

**렌트카 회사 고객과 차량 렌트 관리를 도와주는 렌트카 관리 프로그램**  
<br/>
![tobeprocess](https://user-images.githubusercontent.com/60223013/122747099-9e3b2a80-d2c5-11eb-9a59-1c023d60d9f8.PNG)  


고객 관리와 렌트 관리의 process를 구현하여 렌트카 관리가 가능한 프로그램을 제작  
<br/>
#### 고객관리   
: 고객 정보를 입력받아 고객을 등록하고, 대여 및 반납 내용을 통해 고객의 등급을 구분한다. <br/>  
#### 렌트 관리     
- 대여 : 대여 가능한 차량 목록을 확인한 후, 대여 가능한 고객과 차량 대여 자격 여부를 확인한 후 차량 대여를 등록    
- 반납 : 일자를 확인 후 연체금을 계산하여, 차량 반납을 등록한다.  
#### 조회 기능 
 : 대여 및 반납 내역을 확인한다.
<br/>
#### DashBoard 
 :  현재 차량의 상태 현황과, 매출 top3 고객, 연료별 차량 사용률, 사이즈별 차량 사용률, 월별, 분기별, 년도별 매출을 확인한다.  


## 🚀&nbsp; 사용한 개발 환경
![개발환경](https://user-images.githubusercontent.com/60223013/121473523-c7260a80-c9fd-11eb-874e-e2046cd2345e.PNG)

## 🤝&nbsp; 요구사항정의
![요구사항](https://user-images.githubusercontent.com/60223013/121478206-bc6e7400-ca03-11eb-90e9-a957bbb3dc04.PNG)  

## ❤️&nbsp; 프로젝트 구조 (기능모듈)
![모듈](https://user-images.githubusercontent.com/60223013/121473245-5383fd80-c9fd-11eb-8214-40aff0e93519.PNG)


## 📫&nbsp; 화면구성
**- 로그인화면**    
![login](https://user-images.githubusercontent.com/60223013/121476576-cc855400-ca01-11eb-8f9a-6b27c6801c74.jpg)
- 아이디와 패스워드를 통해 로그인을 할 수 있다.
- 관리자 프로그램이므로, 회원가입 없이 주어진 아이디로만 로그인 가능.  
<br>

**- 렌트카메인화면(Dashboard)**    
![rentcar_main](https://user-images.githubusercontent.com/60223013/121275676-315c8380-c908-11eb-9580-62ed6d71ff17.png)
- 프로그램에서 유용한 정보들을 Dashboard를 통해 제공한다.
- 소유중인 차량을 사용가능, 사용중, 정비중, 폐기차량, 연체차량등의 현재 현황 조회가능
- 이달의 매출액이 top3인 고객 표시.
- 연료별,사이즈별 차량 매출 분포도 확인
- 월별, 분기별, 년도별 매출 분포도 확인  

**- 고객정보 현황 조회 화면**  
![client](https://user-images.githubusercontent.com/60223013/121477044-503f4080-ca02-11eb-9391-cabbffd2e077.PNG)
- 고객추가, 조회, 삭제, 업데이트가 가능한 화면
- 고객의 등급에 따른 조회
- 고객ID, 고객이름을 검색하여 조회가능
- 이달의 매출이 TOP3에 포함된 고객은 VIP, 3번이상 연체를 한 고객은 블랙리스트로 분류한다.  


**- 고객추가 화면**  
![client_add](https://user-images.githubusercontent.com/60223013/121476822-15d5a380-ca02-11eb-885b-f8cd09182c52.jpg)  
이름, 나이, 주소, 전화번호, 성별에 따른 고객 정보 입력 가능
- 차량 정보 현황 조회
![car](https://user-images.githubusercontent.com/60223013/121477710-26d2e480-ca03-11eb-8920-455423e1b247.jpg)
![car_add](https://user-images.githubusercontent.com/60223013/121477709-263a4e00-ca03-11eb-843f-fa184677bc9d.jpg)
![rent](https://user-images.githubusercontent.com/60223013/121477708-25092100-ca03-11eb-8f00-c931cac453eb.jpg)
![rent_add](https://user-images.githubusercontent.com/60223013/121477712-26d2e480-ca03-11eb-89ca-40613d928c39.jpg)
![client_search](https://user-images.githubusercontent.com/60223013/121477713-276b7b00-ca03-11eb-89a3-33b70d3a5569.jpg)
![car_search](https://user-images.githubusercontent.com/60223013/121477714-276b7b00-ca03-11eb-8f76-b30d36217380.jpg)

We are happy to welcome you in our official [Slack channel](https://sulu.io/services-and-support) or answer your questions via [GitHub Discussions](https://github.com/sulu/sulu/discussions)! Obviously you can always **reach out to us directly** via the [Sulu twitter account](https://twitter.com/sulu) or post your question on [StackOverflow](https://stackoverflow.com/questions/tagged/sulu) with the official `sulu` tag.


## ✅&nbsp; Requirements

Sulu requires a **PHP version higher or equal to 7.2** and is compatible with every **Symfony version starting from 4.3**. Have a look at the `require` section in the [composer.json](composer.json) of the [sulu/sulu](https://github.com/sulu/sulu) core framework to find an **up-to-date list of the requirements** of Sulu content management system.


## 📘&nbsp; Contributors

 - [@ccminjun](https://github.com/ccminjun)
 - [@Jang-Jungi](https://github.com/Jang-Jungi)
 - [@sangw](https://github.com/masangwoo)
 - [@정유경](https://github.com/YuKyung-Chung)

