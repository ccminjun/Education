CREATE OR ALTER FUNCTION ufn_getAge(@bYear INT)
	RETURNS INT
AS
BEGIN
	DECLARE @age INT
	SET @age =  YEAR(GETDATE()) - @bYear + 1 --한국나이
	RETURN(@age)
END
GO


SELECT userID, name
	,dbo.ufn_getZodiac(birthYear) AS '띠'
    , birthYear, dbo.ufn_getAge(birthYear) AS '나이'
	, addr
	, height, dbo.ufn_getInch(height) AS '인치'
	FROM userTBL;