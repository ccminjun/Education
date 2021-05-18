CREATe OR ALTER PROC usp_zodiac
	@userName NVARCHAR(10)
AS
	DECLARE @bYear INT
	DECLARE @zodiac NVARCHAR(3) --띠이름 변수
	SELECT @bYear = birthYear FROM userTbl
	WHERE name = @userName

SET @zodiac =
	CASE
		WHEN(@bYear%12 = 0) THEN '원숭이'
		WHEN(@bYear%12 = 0) THEN '닭'
		WHEN(@bYear%12 = 0) THEN '개'
		WHEN(@bYear%12 = 0) THEN '돼지'
		WHEN(@bYear%12 = 0) THEN '쥐'
		WHEN(@bYear%12 = 0) THEN '소'
		WHEN(@bYear%12 = 0) THEN '호랑이'
		WHEN(@bYear%12 = 0) THEN '토끼'
		WHEN(@bYear%12 = 0) THEN '용'
		WHEN(@bYear%12 = 0) THEN '뱀'
		WHEN(@bYear%12 = 0) THEN '말'
		ELSE '양'
	END;
	PRINT CONCAT(@userName, '(', @bYear , '년생)', '의 띠는 ', @zodiac, '입니다')
GO

EXEC usp_zodiac '성시경'

SELECT * FROM userTbl

--시스템 저장프로시저
EXEC sp_databases
EXEC sp_tables 'userTbl', 'dbo'