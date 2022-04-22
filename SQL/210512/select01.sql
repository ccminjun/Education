USE sqlDB;
GO

SELECT * FROM userTbl  
 WHERE userID = 'KKH';

 --사용자 테이블에서 출생년도 1970~1980년 사이, 키가 180이상인 사람을 조회하세요
SELECT * FROM userTbl
 WHERE birthYear >= 1970 AND birthYear <=1980
   AND height >= 180;
 
 --위 구문을 BETWEEN 이용하여 나타낸 것
SELECT * FROM userTbl
 WHERE birthYear BETWEEN 1970 AND 1980
   AND height >= 180;


 --출생년도가 1970년 이후이거나 키가 182이상인 사람 조회
 SELECT * FROM userTbl
  WHERE birthYear >=1970 OR height>182

 --사용자 중에 지역이 경남, 전남, 경북인 사람만 조회
 SELECT [name], userID, addr FROM userTbl
  WHERE addr = '경남' OR addr = '전남' OR addr = '경북'

 --OR 구문 너무 많이쓰면 성능 저하 아래처럼 쓰는게 좋음
 SELECT [name], userID, addr FROM userTbl
  WHERE addr IN ('경남','경북','전남');

 --LIKE 절(문자열에서 속하는 문자열이 있는(contain))
 SELECT name, height, addr FROM userTbl
  WHERE name LIKE '김%';

 SELECT name, height, addr FROM userTbl
  WHERE name LIKE '_비킴'; -- 언더바(_)가 자리수이기 때문에 언더바 자리를 맞춰주어야 됨

 SELECT name, height, addr FROM userTbl
  WHERE name LIKE '%용%';

--SubQuery
--키가 175보다 큰 사람들 조회
SELECT * FROM userTbl
 WHERE height > 175;

--김경호보다 키가 큰 사람을 조회
SELECT * FROM userTbl
 WHERE height > (SELECT height FROM userTbl WHERE name = '김경호');  -- height 대신 * 쓰면 안됨 디테일하게 잡아줘야 함

--경남에 사는 사람들보다 키가 큰 사람들 조회
SELECT * FROM userTbl
 WHERE height > ANY (SELECT height FROM userTbl WHERE addr = '경남');  -- 두개 값 이상이면 ANY를 사용해야됨

 -- IN은 서브쿼리에서 나온 결과와 일치하는 결과만 조회
SELECT * FROM userTbl
 WHERE height IN (SELECT height FROM userTbl WHERE addr = '경남');

SELECT * FROM userTbl
 WHERE height = ANY (SELECT height FROM userTbl WHERE addr = '경남');

 --ORDERBY
SELECT * FROM userTbl
 ORDER BY userID DESC; --DESC는 적어야됨


 --키로 내림차순 정렬 후 이름으로 오름차순
SELECT * FROM userTbl
 ORDER BY height DESC, name ASC; --기본으로 ASC 되어있음

 --moblie1으로 오름차순 뒤 같은값여민 mobil2로 내림차순
 SELECT * FROM userTbl
 ORDER BY userID ASC; --mobile DESC

 SELECT COUNT(*) FROM userTbl
 SELECT COUNT(*) FROM buyTbl

 --DISTINCT (중복제거)
 SELECT DISTINCT addr FROM userTbl

 -- TOP
USE AdventureWorksLT2019;
GO

SELECT * FROM SalesLT.Customer;
SELECT TOP(10) * FROM SalesLT.Customer;

SELECT TOP(10) PERCENT * 
  FROM SalesLT.Customer 
 ORDER BY CustomerID DESC;

-- 10% 샘플링결과 조회(?? 어디쓰지?)
SELECT * FROM SalesLT.Customer
TABLESAMPLE(10 PERCENT);

-- 사용빈도 낮음
SELECT * FROM SalesLT.Customer
 ORDER BY FirstName
OFFSET 5 ROW -- 어디다 써??
FETCH NEXT 3 ROWS ONLY; -- 프로시저/함




