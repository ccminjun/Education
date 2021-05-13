--GROUP BY ROLLUP �̸� �־��ֱ� ���� �۾�
WITH cte_summary(GRP, SUMM, DIV)  -- �Ʒ� ����Ʈ �� �� �����;���
AS
(
   SELECT groupName GRP
        , SUM(price * amount) AS SUMM
		, GROUPING_ID(groupName) AS DIV   --DIV ���� ����� �׳� �ᵵ ��
     FROM buyTbl
    GROUP BY ROLLUP(groupName)
)

/*SELECT grp AS [��ǰ�׷�]
     , summ AS [�׷캰���űݾ�]
	 , div 
  FROM cte_summary*/

SELECT 
       CASE div
	   WHEN 0 THEN grp
	   WHEN 1 THEN '���հ�' END AS [��ǰ�׷�]
	  ,summ AS [�׷캰���űݾ�]
	  --, div
 FROM cte_summary;