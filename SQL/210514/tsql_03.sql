--문자열 함수
SELECT ASCII('z'), CHAR(66);
SELECT UNICODE('가'), NCHAR(44032);

--문자열 연결
SELECT CONCAT('SQL ','server ',2019) AS [name]; --사용빈도 상
SELECT 'SQL '+'sever '+ CAST(2019 AS VARCHAR); -- 아래처럼 써도 되는데 CAST 형변환 해줘야 됨

--단어 시작위치
SELECT CHARINDEX('world', 'Hello world');
-- C#, java, pyton 문자열 0부터 시작
-- DB 1부터 시작 차이가 있음

-- LEFT, RIGHT, SUBSTRING, LEN, LOWER, UPPER, RTRIM
DECLARE @STR VARCHAR(20);
SET @STR = 'SQL Server 2019';
-- SELECT LEFT('SQL Server 2019', 3), RIGHT('SQL Server 2019', 4)
SELECT LEFT(@STR, 3), RIGHT(@STR, 4)

SELECT SUBSTRING('대한민국만세!', 5, 2);  -- 5부터 2자리를 자름

SELECT LEN('Hello World');
SELECT LEN('대한민국만세!');

SELECT LOWER('heLLO World!'), UPPER('heLLO World!')
-- CD1001, CD2005, cd2005 같은 것을 C# 넘겨서 쓸 때 대소문자 바꾸려고
SELECT UPPER('cd2005')

--스페이스 제거
SELECT'     SQL', LTRIM('  SQL     '); ---중
SELECT'    SQL    ', RTRIM('   SQL     '); ---중
SELECT'    SQL    ', TRIM('  SQL     '); ---상

--Relpace 사용빈도 최상
SELECT REPLACE('SQL Server 2019, Sever만쉐', 'Server', '서버');

--STR 사용빈도 하 숫자를 문자로 변환
SELECT STR(3.141592);
SELECT STR(45);

--FORMAT 사용빈도 상
SELECT GETDATE();
SELECT FORMAT(GETDATE(), 'yyyy-MM-dd hh:mm:ss'); --한국식
SELECT FORMAT(GETDATE(), 'MM/dd/yyyy hh:mm:ss'); --미국식

