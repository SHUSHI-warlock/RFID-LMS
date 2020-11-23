/*建表*/
/*
人员表（T_People）
Column(s) of " T_ Peop " Table

Name	Datatype	Null Option	Comment	Is PK	Is FK	Name
P_Id	Varchar(20)	NOT NULL		Yes	No	读者卡号
P_Password	Varchar(20)	NOT NULL		No	No	读者密码
*/
create table T_People
(
	P_Id Varchar(20)  NOT NULL  PRIMARY KEY,
	P_Name Varchar(20),
	P_Password Varchar(20) NOT NULL	
)



/*
图书表（T_Book）
Column(s) of " T_ Book " Table

Name	Datatype	Null Option	Comment	Is PK	Is FK	Name
B_Id	Varchar(20)	NOT NULL		Yes	No	书号
B_Class	Varchar(20)	NOT NULL		No	No	类别
B_Author	Varchar(20)					作者
B_Name	Varchar(20)	NOT NULL				书名
B_CountAll	Int					总库存
B_CountNow	Int					当前库存
*/

/*修改为100
ALTER TABLE T_Book
ALTER COLUMN B_Author Varchar(100)  
ALTER TABLE T_Book
ALTER COLUMN B_Name Varchar(100)
*/

create table T_Book
(
	B_Id Varchar(20)  NOT NULL  PRIMARY KEY,
	B_Class Varchar(20),
	B_Author Varchar(100) NOT NULL ,
	B_Name Varchar(100) NOT NULL,
	B_CountAll Int, 
	B_CountNow Int,
)


/*
标签表(T_Label)
Column(s) of " T_ Label " Table

Name	Datatype	Null Option	Comment	Is PK	Is FK	Name
B_Id	Varchar(20)	NOT NULL		Yes	Yes	图书号
L_Id	Varchar(20)	NOT NULL		Yes	No	标签号
*/


create table T_Label
(
	B_Id Varchar(20)  NOT NULL ,
	L_Id Varchar(20) NOT NULL,
	foreign key(B_Id) references T_Book(B_Id),
	PRIMARY KEY(B_Id,L_Id),
);


/*
借阅表（T_Borrow）
Column(s) of " T_ Borrow " Table

Name	Datatype	Null Option	Comment	Is PK	Is FK	Name
P_Id	Varchar(20)	NOT NULL		Yes	Yes	读者卡号
L_Id	Varchar(20)	NOT NULL		Yes	Yes	标签号
BR_Start	Time					借阅日期
BR_Time	int					借阅时长(天)
BR_Isreturn	Bool					是否归还
*/
create table T_Borrow
(
	P_Id Varchar(20)  NOT NULL,
	L_Id Varchar(20) NOT NULL,
	B_Id Varchar(20)  NOT NULL ,
	BR_Start TIMESTAMP NOT NULL,
	BR_Time int NOT NULL,	/*天数*/
	BR_IsReturn int,
	foreign key(P_Id)references T_People(P_Id),
	foreign key(B_Id,L_Id)references T_Label(B_Id,L_Id),
	PRIMARY KEY( P_Id,L_Id,BR_Start),
);