--UPDATE

--트랜잭션 시작
BEGIN TRANSACTION

UPDATE testTbl
   SET userNAME = '성명건'
 WHERE ID = 2;

UPDATE testTbl
   SET userNAME = '성명건'
  addr ID = 2;


COMMIT;
ROLLBACK;