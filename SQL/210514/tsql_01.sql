--���α׷��� ����
/*  USE sqlDB; sqlDB�� ���� �ȸ�������� ����������� */
GO

DECLARE @myVar1 INT;
DECLARE @myVar2 DECIMAL(5, 2);  -- �� 5�ڸ�, �Ҽ��� 2�ڸ�, �Ҽ����� �˾Ƽ� ¥��
DECLARE @myVar3 NCHAR(20) ;
DECLARE @inchUnit DECIMAL(4, 3); -- ����1, �Ҽ��� 3

SET @myVar1 = 4000;
SET @myVar2 = 3.14;
SET @myVar3 = '���� �̸� ==> ';
SET @inchUnit = 0.393;

--SELECT @myVar1, @myVar2
--SELECT @MyVar3 AS 'string', name FROM userTbl WHERE height > 180; -- DECLARE ������ �������� �����ؾߵ�
SELECT name, height * @inchUnit AS 'Ű(��ġ)' FROM userTbl;