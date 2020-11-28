/*
图书出库
删除读者
*/

/*删除触发器的语句*/
/*
drop trigger triDelBooks;
drop trigger triDelPeople;
*/


/*图书出库 删除对应的借阅记录*/

set ansi_nulls on
go
set quoted_identifier on
go
create trigger triDelBooks on dbo.T_Label instead of delete
as
begin
	set nocount on
	delete from dbo.T_Borrow where L_Id=(select L_Id from deleted)
	delete from dbo.T_Label where L_Id = (select L_Id from deleted)
	end
go

/*删除读者 删除对应的借阅记录*/
set ansi_nulls on
go
set quoted_identifier on
go
create trigger triDelPeople on dbo.T_People instead of delete
as
begin
	set nocount on
	delete from dbo.T_Borrow where P_Id=(select P_Id from deleted)
	delete from dbo.T_People where P_Id = (select P_Id from deleted)
	end
go