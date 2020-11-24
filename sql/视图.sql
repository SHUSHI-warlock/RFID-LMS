/*建视图*/
/*图书的数据视图*/
go
CREATE VIEW [V_Book] AS
SELECT  dbo.T_Label.L_Id, dbo.T_Book.*
FROM      dbo.T_Book ,dbo.T_Label 
WHERE dbo.T_Book.B_Id = dbo.T_Label.B_Id;

/*还书的数据视图*/
go
CREATE VIEW [V_Return] AS
SELECT  P_Id,V_Book.B_Id,V_Book.L_Id,V_Book.B_Name,dbo.T_Borrow.BR_Start,BR_IsReturn,BR_Time
FROM   dbo.T_Borrow ,dbo.V_Book
WHERE  dbo.T_Borrow.L_Id = dbo.V_Book.L_Id;

