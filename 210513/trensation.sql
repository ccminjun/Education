--UPDATE

--Ʈ����� ����
BEGIN TRANSACTION

UPDATE testTbl
   SET userNAME = '�����'
 WHERE ID = 2;

UPDATE testTbl
   SET userNAME = '�����'
  addr ID = 2;


COMMIT;
ROLLBACK;