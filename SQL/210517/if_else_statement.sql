--SQL Programming

DECLARE @VAR1 INT  ---변수 선언
SET @VAR1 = 170

IF (@VAR1 < 100)
BEGIN 
     PRINT '기준값이 작습니다.'
END
ELSE
BEGIN
/* IF()
   BEGIN
   END 순으로 ELSE IF 작업을 해야함, ELSE IF는 없음 */
	SELECT * FROM userTbl WHERE height > @VAR1
END