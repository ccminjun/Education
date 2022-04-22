CREATE OR ALTER FUNCTION ufn_getZodiac(@bYear INT)
	RETURNS NVARCHAR(3)
AS
BEGIN
	DECLARE @result NVARCHAR(3)

	SET @result =
	CASE
		WHEN(@bYear%12 = 0) THEN '������'
		WHEN(@bYear%12 = 0) THEN '��'
		WHEN(@bYear%12 = 0) THEN '��'
		WHEN(@bYear%12 = 0) THEN '����'
		WHEN(@bYear%12 = 0) THEN '��'
		WHEN(@bYear%12 = 0) THEN '��'
		WHEN(@bYear%12 = 0) THEN 'ȣ����'
		WHEN(@bYear%12 = 0) THEN '�䳢'
		WHEN(@bYear%12 = 0) THEN '��'
		WHEN(@bYear%12 = 0) THEN '��'
		WHEN(@bYear%12 = 0) THEN '��'
		ELSE '��'
		END
RETURN(@result)
END
GO
