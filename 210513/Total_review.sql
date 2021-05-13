--통합
BEGIN TRAN;

--
SELECT * FROM testTbl;

--데이터 입력
INSERT INTO testTbl VALUES ( '최우식', '캐낟');

--데이터 수정
UPDATE testTbl
   SET userName = '이지은'
     , addr = '서울'
 WHERE ID = 3;

 -- 데이터 삭제
 DELETE FROM testTbl  WHERE userName = '홍길순';

 COMMIT;  -- 보류중인 모든 데이터 변경사항을 영구적으로 적용. 현재 트랜잭션 종료
 ROLLBACK; --전체 트랜잭션을 롤백함
