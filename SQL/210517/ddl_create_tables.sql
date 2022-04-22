USE sampleDB
GO

CREATE TABLE userTBL
(
	userID CHAR(8) NOT NULL PRIMARY KEY,
	name NVARCHAR(10) NOT NULL,
	birthYear INT NOT NULL,
	height SMALLINT
);

--�θ�� userTBL
CREATE TABLE buyTBL
(
	num INT NOT NULL PRIMARY KEY,
	userID CHAR(8) NOT NULL
	FOREIGN KEY REFERENCES userTBL(userID), --RDB!!���� ���� �������� �ϳ�
	prodNAME NCHAR(6) NOT NULL,
	price INT NOT NULL
)
--
--userTBL�� email(����ũ��������) �߰�
ALTER TABLE userTBL
  ADD email VARCHAR(50) NOT NULL

--CHECK
ALTER TABLE userTBL
  ADD CONSTRAINT CK_birthYear
  CHECK (birthYear >= 1900 AND birthYear <= Year(GETDATE()));
--2021�� ����

SELECT * FROM sampleDB.dbo.userTBL;

SELECT * FROM sqlDB.dbo.buyTbl;

SELECT * FROM AdventureWorksLT2019.SalesLT.Product;