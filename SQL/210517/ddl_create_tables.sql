USE sampleDB
GO

CREATE TABLE userTBL
(
	userID CHAR(8) NOT NULL PRIMARY KEY,
	name NVARCHAR(10) NOT NULL,
	birthYear INT NOT NULL,
	height SMALLINT
);

--부모는 userTBL
CREATE TABLE buyTBL
(
	num INT NOT NULL PRIMARY KEY,
	userID CHAR(8) NOT NULL
	FOREIGN KEY REFERENCES userTBL(userID), --RDB!!에서 제일 어려운것중 하나
	prodNAME NCHAR(6) NOT NULL,
	price INT NOT NULL
)
--
--userTBL에 email(유니크제약조건) 추가
ALTER TABLE userTBL
  ADD email VARCHAR(50) NOT NULL

--CHECK
ALTER TABLE userTBL
  ADD CONSTRAINT CK_birthYear
  CHECK (birthYear >= 1900 AND birthYear <= Year(GETDATE()));
--2021년 까지

SELECT * FROM sampleDB.dbo.userTBL;

SELECT * FROM sqlDB.dbo.buyTbl;

SELECT * FROM AdventureWorksLT2019.SalesLT.Product;