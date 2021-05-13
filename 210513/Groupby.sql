-- GROUP BY
-- ���̵𺰷� ������ ��ġ ����� ��ȸ
SELECT userID, SUM(amount) AS '�ѱ��Ű���'
  FROM buyTbl    
 GROUP BY userID

-- �츮 ���θ����� ���� �� ���� �� �����
-- ���̵� ���� ��ȸ�ϰ� �� �ݾ��� ���� ���
SELECT userID, SUM(amount * price) AS '�ѱ��űݾ�'
  FROM buyTbl
 GROUP BY userID
 ORDER BY SUM(amount * price) DESC --������������ ����

SELECT SUM(amount * price) AS '�ѱ��űݾ�'
  FROM buyTbl

-- ��ձ��űݾ�
SELECT AVG(price) AS '��ձ��űݾ�' FROM buyTbl -- [��ձ��űݾ�]���� ����ص� ���� ���� ����

-- ��������̺��� Ű�� ���� ū����ϰ� ���� ������� ��ȸ
SELECT * FROM userTbl
 ORDER BY height ASC;

SELECT * FROM userTbl
 ORDER BY height DESC;

SELECT * FROM userTbl
 WHERE height = 166 OR height = 186; /* X!! */

SELECT name AS '�̸�', height AS [Ű] FROM userTbl
 WHERE height = (SELECT MAX(height) FROM userTbl)
    OR height = (SELECT MIN(height) FROM userTbl) /* OK!! */
	
-- GROUP BY / HAVING
SELECT userID AS '����� ���̵�'
     , SUM(price * amount) AS [�ѱ��űݾ�]
  FROM buyTbl
-- WHERE SUM(price * amount) >= 1000 //����Ұ�
 GROUP BY userID
 HAVING SUM(price * amount) >= 1000

-- ���
-- ��ǰ�׷캰�� ����� �󸶸�ŭ ���Ÿ� �ߴ��� ��ȸ
SELECT groupName   -- ���� �ٲܷ��� userID, groupName �ٲٸ� ��
     , userID
     , SUM(price * amount) AS [�ѱ��űݾ�]
  FROM buyTbl
 GROUP BY ROLLUP(groupName,userID ) -- userID�� groupName �տ� ���� ������ ���� �ٸ� userID�� ���� ������ ����ID���� �׷��ؼ� �����ϰ� �ݴ�� �׷� ���� ����

 SELECT groupName  
     , userID
     , SUM(price * amount) AS [�ѱ��űݾ�]
  FROM buyTbl
 GROUP BY CUBE(groupName,userID ) -- �׷��Ѱų��� �հ谡 �ϳ� �� ����

 SELECT groupName  
     , SUM(price * amount) AS [�ѱ��űݾ�]
	 , GROUPING_ID(groupName) 'SUM'   -- 0000 �Ȱ� ���̺� ������, 1�� ���ο� ��(�Ѿ��� ���� ��)
  FROM buyTbl
 GROUP BY ROLLUP (groupName)