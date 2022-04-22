--순위함수
SELECT RANK() OVER( ORDER BY SUM(price * amount) DESC) AS '구매순위'
      ,userID, SUM(price * amount) AS '사용자별구매금액'
  FROM buyTbl
 GROUP BY userID
   FOR JSON AUTO; --XML도 가능






SELECT ROW_NUMBER() OVER(ORDER BY height DESC) AS '키순위'
     , name, height, addr 
  FROM userTbl
 WHERE height IS NOT NULL

 -- ROW는 동점자 다르게 순위매기는데 RANK함수는 같은 순위로 매김
SELECT RANK() OVER(ORDER BY height DESC) AS '키순위'
     , name, height, addr 
  FROM userTbl
 WHERE height IS NOT NULL

 -- RANK와는 다르게 동점자 뒤에는 그 다음 순위로 감
SELECT DENSE_RANK() OVER(ORDER BY height DESC) AS '키순위'
     , name, height, addr 
  FROM userTbl
 WHERE height IS NOT NULL

 -- 지역별로 구분하는 것
SELECT ROW_NUMBER() OVER(PARTITION BY addr ORDER BY height DESC) AS '키순위'
     , name, height, addr 
  FROM userTbl
 WHERE height IS NOT NULL