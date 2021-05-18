--테이블 생성
USE sampleDB
GO

CREATE TABLE ddlTbl
(
	ID int NOT NULL PRIMARY KEY IDENTITY(1, 1),
	name NVARCHAR(20) NOT NULL,
	regDate DATETIME
);
GO

-- DDL 테이블 수정
ALTER TABLE ddlTbl ADD Id INT IDENTITY(1, 1); -- 안됨 드랍테이블해야됨

DROP TABLE ddlTbl

--DDL 한개 이상 컬럼 PK로 지정할 때
CREATE TABLE prodTbl
(
	prodCode NCHAR(3) NOT NULL,
	prodID NCHAR(4) NOT NULL,
	prodDate DATETIME NOT NULL,
	prodCur NCHAR(10) NULL,
	CONSTRAINT PK_prodTbl_prodCode_prodID
	   PRIMARY KEY (prodCode, prodID)
);
GO