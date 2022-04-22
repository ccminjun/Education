USE sampleDB
GO

--VIEW
CREATE VIEW v_userTBL
AS
	SELECT userID, name, addr FROM userTBL;
GO

SELECT userID, name, addr FROM v_userTBL

SELECT * FROM v_buyTBL

SELECT * FROM buyTBl

CREATE VIEW v.userbuyinf
AS

SELECT u.userID, u.name, b.prodName, b.price
  FROM userTbl as u
 INNER Join buyTbl as b
    ON u.userID = b.userID
GO

SELECT * FROM v_userTBL
 ORDER BY price DESC
