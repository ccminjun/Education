--���ڿ� �Լ�
SELECT ASCII('z'), CHAR(66);
SELECT UNICODE('��'), NCHAR(44032);

--���ڿ� ����
SELECT CONCAT('SQL ','server ',2019) AS [name]; --���� ��
SELECT 'SQL '+'sever '+ CAST(2019 AS VARCHAR); -- �Ʒ�ó�� �ᵵ �Ǵµ� CAST ����ȯ ����� ��

--�ܾ� ������ġ
SELECT CHARINDEX('world', 'Hello world');
-- C#, java, pyton ���ڿ� 0���� ����
-- DB 1���� ���� ���̰� ����

-- LEFT, RIGHT, SUBSTRING, LEN, LOWER, UPPER, RTRIM
DECLARE @STR VARCHAR(20);
SET @STR = 'SQL Server 2019';
-- SELECT LEFT('SQL Server 2019', 3), RIGHT('SQL Server 2019', 4)
SELECT LEFT(@STR, 3), RIGHT(@STR, 4)

SELECT SUBSTRING('���ѹα�����!', 5, 2);  -- 5���� 2�ڸ��� �ڸ�

SELECT LEN('Hello World');
SELECT LEN('���ѹα�����!');

SELECT LOWER('heLLO World!'), UPPER('heLLO World!')
-- CD1001, CD2005, cd2005 ���� ���� C# �Ѱܼ� �� �� ��ҹ��� �ٲٷ���
SELECT UPPER('cd2005')

--�����̽� ����
SELECT'     SQL', LTRIM('  SQL     '); ---��
SELECT'    SQL    ', RTRIM('   SQL     '); ---��
SELECT'    SQL    ', TRIM('  SQL     '); ---��

--Relpace ���� �ֻ�
SELECT REPLACE('SQL Server 2019, Sever����', 'Server', '����');

--STR ���� �� ���ڸ� ���ڷ� ��ȯ
SELECT STR(3.141592);
SELECT STR(45);

--FORMAT ���� ��
SELECT GETDATE();
SELECT FORMAT(GETDATE(), 'yyyy-MM-dd hh:mm:ss'); --�ѱ���
SELECT FORMAT(GETDATE(), 'MM/dd/yyyy hh:mm:ss'); --�̱���

