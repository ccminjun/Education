--����(���̺� ��ġ��)
SELECT StdName, Region From stdTbl	
UNION
SELECT ClubName, ClubRoom From clubTbl


--������Ÿ���� ��ġ�ؾ� UNION ����
SELECT CAST(Id AS VARCHAR), Stdid FROM reginfoTbl
UNION
SELECT ClubName, ClubRoom FROM clubTbl


--�ߺ��� ���
SELECT StdName, Region FROM stdTbl
UNION ALL --���Ͽ� ���� �ߺ��� �����, ���Ͽ��� �ߺ� ������� ����
SELECT StdName, Region FROM stdTbl

-- except
SELECT name, CONCAT(mobile1, mobile2) AS mobile FROM userTbl
EXCEPT -- ��������.
SELECT name, CONCAT(mobile1, mobile2) AS mobile FROM userTbl
WHERE mobile1 IS NOT NULL

-- ���� ���̺� ���� �����ϴ� �����͸� �߷����°�
SELECT name, CONCAT(mobile1, mobile2) AS mobile FROM userTbl
INTERSECT
SELECT name, CONCAT(mobile1, mobile2) AS mobile FROM userTbl
WHERE mobile1 IS NOT NULL