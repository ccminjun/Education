-- GROUP BY
-- 아이디별로 물건을 얼마치 샀는지 조회
SELECT userID, SUM(amount) AS '총구매갯수'
  FROM buyTbl    
 GROUP BY userID

-- 우리 쇼핑몰에서 가장 돈 많이 쓴 사람을
-- 아이디 별로 조회하고 그 금액을 같이 출력
SELECT userID, SUM(amount * price) AS '총구매금액'
  FROM buyTbl
 GROUP BY userID
 ORDER BY SUM(amount * price) DESC --내림차순으로 정렬

SELECT SUM(amount * price) AS '총구매금액'
  FROM buyTbl

-- 평균구매금액
SELECT AVG(price) AS '평균구매금액' FROM buyTbl -- [평균구매금액]으로 사용해도 같은 값이 나옴

-- 사용자테이블에서 키가 가장 큰사람하고 가장 작은사람 조회
SELECT * FROM userTbl
 ORDER BY height ASC;

SELECT * FROM userTbl
 ORDER BY height DESC;

SELECT * FROM userTbl
 WHERE height = 166 OR height = 186; /* X!! */

SELECT name AS '이름', height AS [키] FROM userTbl
 WHERE height = (SELECT MAX(height) FROM userTbl)
    OR height = (SELECT MIN(height) FROM userTbl) /* OK!! */
	
-- GROUP BY / HAVING
SELECT userID AS '사용자 아이디'
     , SUM(price * amount) AS [총구매금액]
  FROM buyTbl
-- WHERE SUM(price * amount) >= 1000 //절대불가
 GROUP BY userID
 HAVING SUM(price * amount) >= 1000

-- 통계
-- 제품그룹별로 사용자 얼마만큼 구매를 했는지 조회
SELECT groupName   -- 순서 바꿀려면 userID, groupName 바꾸면 됨
     , userID
     , SUM(price * amount) AS [총구매금액]
  FROM buyTbl
 GROUP BY ROLLUP(groupName,userID ) -- userID랑 groupName 앞에 오는 순서에 따라 다름 userID가 먼저 나오면 유저ID별로 그룹해서 정리하고 반대는 그룹 먼저 정리

 SELECT groupName  
     , userID
     , SUM(price * amount) AS [총구매금액]
  FROM buyTbl
 GROUP BY CUBE(groupName,userID ) -- 그룹한거끼리 합계가 하나 더 나옴

 SELECT groupName  
     , SUM(price * amount) AS [총구매금액]
	 , GROUPING_ID(groupName) 'SUM'   -- 0000 된건 테이블 데이터, 1은 새로운 행(롤업이 만든 것)
  FROM buyTbl
 GROUP BY ROLLUP (groupName)