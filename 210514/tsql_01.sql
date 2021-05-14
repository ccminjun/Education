--프로그래밍 시작
/*  USE sqlDB; sqlDB로 쿼리 안만들었으면 선언해줘야함 */
GO

DECLARE @myVar1 INT;
DECLARE @myVar2 DECIMAL(5, 2);  -- 총 5자리, 소수점 2자리, 소수점은 알아서 짜름
DECLARE @myVar3 NCHAR(20) ;
DECLARE @inchUnit DECIMAL(4, 3); -- 정수1, 소수점 3

SET @myVar1 = 4000;
SET @myVar2 = 3.14;
SET @myVar3 = '가수 이름 ==> ';
SET @inchUnit = 0.393;

--SELECT @myVar1, @myVar2
--SELECT @MyVar3 AS 'string', name FROM userTbl WHERE height > 180; -- DECLARE 구문은 위에부터 실행해야됨
SELECT name, height * @inchUnit AS '키(인치)' FROM userTbl;