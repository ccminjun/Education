--DELETE
--WHERE �Ⱦ��� ������

--Ʈ����� ����
BEGIN TRAN

UPDATE testTbl
 WHERE ID = 4;

UPDATE testTbl
   SET userNAME = 'ȫ�浿'
  addr ID = 2;




COMMIT;
ROLLBACK;