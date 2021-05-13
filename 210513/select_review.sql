--데이터 조회
SELECT * FROM userTbl;

--데이터 조회 필터링
SELECT * FROM userTbl
 WHERE userID = 'BBK'

SELECT * FROM userTbl
 WHERE name = '조용필';

SELECT * FROM userTbl
 WHERE name LIKE '%용%';


SELECT userID, name, addr FROM userTbl
 WHERE name LIKE '%용%';

-- 특정 레이블 레코드(데이터) 갯수확인
SELECT COUNT(userID) FROM userTbl;

-- 사용자 테이블에서 키가 180이상이고 
-- 출생년도가 1970년 이후에 태어난 사람의
-- 아이디와, 이름, 키를 조회하세요.
SELECT userID, name, height FROM userTbl
 WHERE height >= 180 AND birthYear >= 1970;

--출생년도순(오르마순)으로 정렬해서 조회
SELECT * FROM userTbl
 ORDER BY birthYear DESC; -- ASC(ENDING) DESC(ENDING) 내림차순

-- SELECT INTO
-- userTbl_NEW 테이블이 생성(PK 키정보는 미생성)
SELECT * INTO userTbl_NEW From userTbl;

SELECT * FROM userTbl_NEW;

SELECT userID, name, addr INTO userTbl_Backup2 From userTbl -- 원하는 필드만 복사
 WHERE addr = '서울'

SELECT * FROM userTbl_Backup;

SELECT * FROM userTbl_Backup2;
