--���̺� ����
USE sampleDB
GO

CREATE TABLE ddlTbl
(
	ID int NOT NULL PRIMARY KEY IDENTITY(1, 1),
	name NVARCHAR(20) NOT NULL,
	regDate DATETIME
);
GO

-- DDL ���̺� ����
ALTER TABLE ddlTbl ADD Id INT IDENTITY(1, 1); -- �ȵ� ������̺��ؾߵ�

DROP TABLE ddlTbl

--DDL �Ѱ� �̻� �÷� PK�� ������ ��
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