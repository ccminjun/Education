BEGIN TRAN
UPDATE userTBL SET addr = '����' WHERE userID = 'KBS'
COMMIT

BEGIN TRAN
UPDATE userTBL SET addr = '�̱�' WHERE userID = 'KKH'
ROLLBACK

BEGIN TRAN --COMMIT �ҷ��� BEGIN TRAN �ʿ�
UPDATE userTBL SET addr = 'ȣ��' WHERE userID = 'JYP'
COMMIT

SELECT * FROM userTbl

BEGIN TRAN -- 3���� �ϳ��� �������� ���δ� ���� �ȵǰ� ������ �������͸� ����ȵ� ���� �ٸ���
UPDATE userTBL SET addr = '����' WHERE userID = 'KBS'
UPDATE userTBL SET addr = '�̱�' WHERE userID = 'KKH'
UPDATE userTBL SET addr = 'ȣ��' WHERE userID = 'JYP'
COMMIT

-- Transaction ó������ �ù�
USE sampleDB
GO

CREATE TABLE testTbl (num int)
GO
INSERT into testTbl VALUES (1),(3),(5)

BEGIN TRAN --�ϳ��� �����Ϳ��� �����ϴ°��� �ٸ������� �� �� ���� �� ���� Ʈ��
UPDATE testTbl SET num = 11 WHERE num = 1
UPDATE testTbl SET num = 33 WHERE num = 3
UPDATE testTbl SET num = 55 WHERE num = 5
COMMIT

SELECT * FROM testTbl

