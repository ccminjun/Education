--�����Լ�
SELECT RANK() OVER( ORDER BY SUM(price * amount) DESC) AS '���ż���'
      ,userID, SUM(price * amount) AS '����ں����űݾ�'
  FROM buyTbl
 GROUP BY userID
   FOR JSON AUTO; --XML�� ����






SELECT ROW_NUMBER() OVER(ORDER BY height DESC) AS 'Ű����'
     , name, height, addr 
  FROM userTbl
 WHERE height IS NOT NULL

 -- ROW�� ������ �ٸ��� �����ű�µ� RANK�Լ��� ���� ������ �ű�
SELECT RANK() OVER(ORDER BY height DESC) AS 'Ű����'
     , name, height, addr 
  FROM userTbl
 WHERE height IS NOT NULL

 -- RANK�ʹ� �ٸ��� ������ �ڿ��� �� ���� ������ ��
SELECT DENSE_RANK() OVER(ORDER BY height DESC) AS 'Ű����'
     , name, height, addr 
  FROM userTbl
 WHERE height IS NOT NULL

 -- �������� �����ϴ� ��
SELECT ROW_NUMBER() OVER(PARTITION BY addr ORDER BY height DESC) AS 'Ű����'
     , name, height, addr 
  FROM userTbl
 WHERE height IS NOT NULL