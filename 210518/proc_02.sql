--�Ķ����(�Ű�����) �þ�� ���ν���
CREATE PROC usp_users1
   @userName NVARCHAR(10)
AS
     --����
	 SELECT userId, name, birthYear FROM userTbl
	 WHERE name = @userName;
GO

EXEC usp_users1 '������'

SELECT * FROM v_userbuyInfo WHERE name '���ð�'

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
   @outCount INT OUTPUT  --���� �޴� ��
AS	
	SELECT @outCount = COUNT(*) FROM userTbl WHERE name LIKE @lastname + '%';
GO

SELECT COUNT(*) FROM userTbl WHERE name LIKE '��' + '%'

DECLARE @myValue INT
EXEC usp_users3 '��', @myValue OUTPUT
PRINT CONCAT('�达 ���� ���� ����� ����  ', @myValue)
