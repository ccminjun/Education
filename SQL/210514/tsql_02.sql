 -- �ý����Լ�(SQL������ �⺻���� �������ִ� �Լ���)
 SELECT CAST(AVG(CAST(amount AS float)) AS decimal(5, 4)) FROM buyTbl; -- ������ �ϸ� 2.9���ε� ���⼭ ��վ��� 2�� �׷��� ����ȯ ��
 
 SELECT AVG(CONVERT(FLOAT, AMOUNT)) FROM buyTbl  --���������� TRYCONVER�� ����

 SELECT PARSE('3.14' AS INT); -- ������ �� ���ܹ߻��ϸ� ���� ������ ����
 SELECT TRY_PARSE('3.14' AS INT); -- ����ȯ���ϸ� NULL ����ü ������ ����

 -- HEIGHT SMALLINT --> VARCHAR, CHAR ����ȯ
 SELECT name, CAST(height AS varchar) + ' cm' FROM userTbl -- CHAR(6) ������ ���̰� �������� ���ϰ� VARCHAR ���
  WHERE height IS NOT NULL; --NULL���� =�� ������ ���� // IS�� ���� IS NOT (�����ʴ�)

 SELECT PARSE('2021�� 5�� 14�� 10�� 27��' AS DATETIME); --���������� TRY_PARSE ��� ����
  -- YYYY-MM-DD HH:min:ss

 SELECT GETDATE(); -- INSERT ���� ����Ͻú���

 SELECT @@SERVERNAME;
 SELECT @@SERVICENAME;

 --��¥ �� �ð��Լ�
 SELECT YEAR(GETDATE()) AS '����⵵';
 SELECT MONTH(GETDATE()) AS '�����';
 SELECT DAY(GETDATE()) AS '����';

 --��ġ�Լ�
 SELECT ABS(-100); --���밪
 SELECT ROUND(3.141592, 3); -- �ݿø�
 SELECT FLOOR(RAND() * 100); -- ���� + ����
 SELECT RAND();

 --���Լ�
 SELECT IIF(100 > 200, '��', '����'); -- CASE WHEN ���� �ξ� ����, �ڵ��� ���� �� �ִ�.
 
 