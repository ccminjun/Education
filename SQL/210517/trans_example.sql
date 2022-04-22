BEGIN TRAN
UPDATE userTBL SET addr = '제주' WHERE userID = 'KBS'
COMMIT

BEGIN TRAN
UPDATE userTBL SET addr = '미국' WHERE userID = 'KKH'
ROLLBACK

BEGIN TRAN --COMMIT 할려면 BEGIN TRAN 필요
UPDATE userTBL SET addr = '호주' WHERE userID = 'JYP'
COMMIT

SELECT * FROM userTbl

BEGIN TRAN -- 3개중 하나만 오류나도 전부다 적용 안되고 위에껀 오류난것만 적용안됨 서로 다른것
UPDATE userTBL SET addr = '제주' WHERE userID = 'KBS'
UPDATE userTBL SET addr = '미국' WHERE userID = 'KKH'
UPDATE userTBL SET addr = '호주' WHERE userID = 'JYP'
COMMIT

-- Transaction 처리순서 시뮬
USE sampleDB
GO

CREATE TABLE testTbl (num int)
GO
INSERT into testTbl VALUES (1),(3),(5)

BEGIN TRAN --하나의 에디터에서 실행하는것은 다른곳에서 할 수 없음 락 걸음 트랜
UPDATE testTbl SET num = 11 WHERE num = 1
UPDATE testTbl SET num = 33 WHERE num = 3
UPDATE testTbl SET num = 55 WHERE num = 5
COMMIT

SELECT * FROM testTbl

