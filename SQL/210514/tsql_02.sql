 -- 시스템함수(SQL서버가 기본으로 제공해주는 함수들)
 SELECT CAST(AVG(CAST(amount AS float)) AS decimal(5, 4)) FROM buyTbl; -- 엑셀로 하면 2.9몇인데 여기서 평균쓰면 2임 그래서 형변환 함
 
 SELECT AVG(CONVERT(FLOAT, AMOUNT)) FROM buyTbl  --마찬가지로 TRYCONVER도 가능

 SELECT PARSE('3.14' AS INT); -- 오류가 남 예외발생하면 쿼리 비정상 종류
 SELECT TRY_PARSE('3.14' AS INT); -- 값변환못하면 NULL 값대체 정상적 수행

 -- HEIGHT SMALLINT --> VARCHAR, CHAR 형변환
 SELECT name, CAST(height AS varchar) + ' cm' FROM userTbl -- CHAR(6) 넣으면 사이가 벌어져서 편하게 VARCHAR 사용
  WHERE height IS NOT NULL; --NULL값은 =로 비교하지 않음 // IS는 같다 IS NOT (같지않다)

 SELECT PARSE('2021년 5월 14일 10시 27분' AS DATETIME); --마찬가지로 TRY_PARSE 사용 가능
  -- YYYY-MM-DD HH:min:ss

 SELECT GETDATE(); -- INSERT 현재 년원일시분초

 SELECT @@SERVERNAME;
 SELECT @@SERVICENAME;

 --날짜 및 시간함수
 SELECT YEAR(GETDATE()) AS '현재년도';
 SELECT MONTH(GETDATE()) AS '현재월';
 SELECT DAY(GETDATE()) AS '오늘';

 --수치함수
 SELECT ABS(-100); --절대값
 SELECT ROUND(3.141592, 3); -- 반올림
 SELECT FLOOR(RAND() * 100); -- 랜덤 + 내림
 SELECT RAND();

 --논리함수
 SELECT IIF(100 > 200, '참', '거짓'); -- CASE WHEN 보다 훨씬 좋음, 코딩을 줄일 수 있다.
 
 