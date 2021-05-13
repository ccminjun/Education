--DELETE
--WHERE 안쓰면 사유서

--트랜잭션 시작
BEGIN TRAN

UPDATE testTbl
 WHERE ID = 4;

UPDATE testTbl
   SET userNAME = '홍길동'
  addr ID = 2;




COMMIT;
ROLLBACK;