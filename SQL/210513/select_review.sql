--������ ��ȸ
SELECT * FROM userTbl;

--������ ��ȸ ���͸�
SELECT * FROM userTbl
 WHERE userID = 'BBK'

SELECT * FROM userTbl
 WHERE name = '������';

SELECT * FROM userTbl
 WHERE name LIKE '%��%';


SELECT userID, name, addr FROM userTbl
 WHERE name LIKE '%��%';

-- Ư�� ���̺� ���ڵ�(������) ����Ȯ��
SELECT COUNT(userID) FROM userTbl;

-- ����� ���̺��� Ű�� 180�̻��̰� 
-- ����⵵�� 1970�� ���Ŀ� �¾ �����
-- ���̵��, �̸�, Ű�� ��ȸ�ϼ���.
SELECT userID, name, height FROM userTbl
 WHERE height >= 180 AND birthYear >= 1970;

--����⵵��(��������)���� �����ؼ� ��ȸ
SELECT * FROM userTbl
 ORDER BY birthYear DESC; -- ASC(ENDING) DESC(ENDING) ��������

-- SELECT INTO
-- userTbl_NEW ���̺��� ����(PK Ű������ �̻���)
SELECT * INTO userTbl_NEW From userTbl;

SELECT * FROM userTbl_NEW;

SELECT userID, name, addr INTO userTbl_Backup2 From userTbl -- ���ϴ� �ʵ常 ����
 WHERE addr = '����'

SELECT * FROM userTbl_Backup;

SELECT * FROM userTbl_Backup2;
