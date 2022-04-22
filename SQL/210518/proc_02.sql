--파라미터(매개변수) 늘어나는 프로시저
CREATE PROC usp_users1
   @userName NVARCHAR(10)
AS
     --로직
	 SELECT userId, name, birthYear FROM userTbl
	 WHERE name = @userName;
GO

EXEC usp_users1 '조관우'

SELECT * FROM v_userbuyInfo WHERE name '성시경'

CREATE PROC usp_users2
    @userBirthYear INT,
	@userHeight INT
AS
	SELECT userID, name, birthYear, height, mdate FROM userTbl
	 WHERE birthYear > @userBirthYear
	   AND height >= @userHeight
GO

EXEC usp_users2 1960, 170

CREATE PROC usp_users3
   @lastName NVARCHAR(2),
   @outCount INT OUTPUT  --리턴 받는 값
AS	
	SELECT @outCount = COUNT(*) FROM userTbl WHERE name LIKE @lastname + '%';
GO

SELECT COUNT(*) FROM userTbl WHERE name LIKE '김' + '%'

DECLARE @myValue INT
EXEC usp_users3 '김', @myValue OUTPUT
PRINT CONCAT('김씨 성을 가진 사용자 수는  ', @myValue)
