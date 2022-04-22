 --3개 테이블 내부조 조인
 SELECT * FROM stdTbl
 SELECT * FROM clubTbl

 SELECT s.Stdid, s.StdName
      , r.ClubName
	  , r.RegDate, c.ClubRoom
   FROM stdTbl AS s
  INNER JOIN reginfoTbl AS r
     ON s.Stdid = r.Stdid
  INNER JOIN clubTbl AS c
     ON c.ClubName = r.ClubName
  WHERE s.Stdid = 'KBS'