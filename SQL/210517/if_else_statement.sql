--SQL Programming

DECLARE @VAR1 INT  ---���� ����
SET @VAR1 = 170

IF (@VAR1 < 100)
BEGIN 
     PRINT '���ذ��� �۽��ϴ�.'
END
ELSE
BEGIN
/* IF()
   BEGIN
   END ������ ELSE IF �۾��� �ؾ���, ELSE IF�� ���� */
	SELECT * FROM userTbl WHERE height > @VAR1
END