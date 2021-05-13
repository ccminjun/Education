--GROUP BY ROLLUP 이름 넣어주기 위한 작업
WITH cte_summary(GRP, SUMM, DIV)  -- 아래 셀렉트 된 것 가져와야함
AS
(
   SELECT groupName GRP
        , SUM(price * amount) AS SUMM
		, GROUPING_ID(groupName) AS DIV   --DIV 같이 영어는 그냥 써도 됨
     FROM buyTbl
    GROUP BY ROLLUP(groupName)
)

/*SELECT grp AS [상품그룹]
     , summ AS [그룹별구매금액]
	 , div 
  FROM cte_summary*/

SELECT 
       CASE div
	   WHEN 0 THEN grp
	   WHEN 1 THEN '총합계' END AS [상품그룹]
	  ,summ AS [그룹별구매금액]
	  --, div
 FROM cte_summary;