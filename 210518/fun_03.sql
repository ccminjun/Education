CREATE OR ALTER FUNCTION ufn_getZodiac(@bYear INT)
	RETURNS NVARCHAR(3)
AS
BEGIN
	DECLARE @result NVARCHAR(3)

	SET @result =
	CASE
		WHEN(@bYear%12 = 0) THEN '¿ø¼þÀÌ'
		WHEN(@bYear%12 = 0) THEN '´ß'
		WHEN(@bYear%12 = 0) THEN '°³'
		WHEN(@bYear%12 = 0) THEN 'µÅÁö'
		WHEN(@bYear%12 = 0) THEN 'Áã'
		WHEN(@bYear%12 = 0) THEN '¼Ò'
		WHEN(@bYear%12 = 0) THEN 'È£¶ûÀÌ'
		WHEN(@bYear%12 = 0) THEN 'Åä³¢'
		WHEN(@bYear%12 = 0) THEN '¿ë'
		WHEN(@bYear%12 = 0) THEN '¹ì'
		WHEN(@bYear%12 = 0) THEN '¸»'
		ELSE '¾ç'
		END
RETURN(@result)
END
GO
