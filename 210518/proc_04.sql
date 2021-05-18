CREATe OR ALTER PROC usp_zodiac
	@userName NVARCHAR(10)
AS
	DECLARE @bYear INT
	DECLARE @zodiac NVARCHAR(3) --���̸� ����
	SELECT @bYear = birthYear FROM userTbl
	WHERE name = @userName

SET @zodiac =
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
	END;
	PRINT CONCAT(@userName, '(', @bYear , '���)', '�� ��� ', @zodiac, '�Դϴ�')
GO

EXEC usp_zodiac '���ð�'

SELECT * FROM userTbl

--�ý��� �������ν���
EXEC sp_databases
EXEC sp_tables 'userTbl', 'dbo'