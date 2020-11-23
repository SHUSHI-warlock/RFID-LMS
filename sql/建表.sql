/*����*/
/*
��Ա��T_People��
Column(s) of " T_ Peop " Table

Name	Datatype	Null Option	Comment	Is PK	Is FK	Name
P_Id	Varchar(20)	NOT NULL		Yes	No	���߿���
P_Password	Varchar(20)	NOT NULL		No	No	��������
*/
create table T_People
(
	P_Id Varchar(20)  NOT NULL  PRIMARY KEY,
	P_Name Varchar(20),
	P_Password Varchar(20) NOT NULL	
)



/*
ͼ���T_Book��
Column(s) of " T_ Book " Table

Name	Datatype	Null Option	Comment	Is PK	Is FK	Name
B_Id	Varchar(20)	NOT NULL		Yes	No	���
B_Class	Varchar(20)	NOT NULL		No	No	���
B_Author	Varchar(20)					����
B_Name	Varchar(20)	NOT NULL				����
B_CountAll	Int					�ܿ��
B_CountNow	Int					��ǰ���
*/

/*�޸�Ϊ100
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
��ǩ��(T_Label)
Column(s) of " T_ Label " Table

Name	Datatype	Null Option	Comment	Is PK	Is FK	Name
B_Id	Varchar(20)	NOT NULL		Yes	Yes	ͼ���
L_Id	Varchar(20)	NOT NULL		Yes	No	��ǩ��
*/


create table T_Label
(
	B_Id Varchar(20)  NOT NULL ,
	L_Id Varchar(20) NOT NULL,
	foreign key(B_Id) references T_Book(B_Id),
	PRIMARY KEY(B_Id,L_Id),
);


/*
���ı�T_Borrow��
Column(s) of " T_ Borrow " Table

Name	Datatype	Null Option	Comment	Is PK	Is FK	Name
P_Id	Varchar(20)	NOT NULL		Yes	Yes	���߿���
L_Id	Varchar(20)	NOT NULL		Yes	Yes	��ǩ��
BR_Start	Time					��������
BR_Time	int					����ʱ��(��)
BR_Isreturn	Bool					�Ƿ�黹
*/
create table T_Borrow
(
	P_Id Varchar(20)  NOT NULL,
	L_Id Varchar(20) NOT NULL,
	B_Id Varchar(20)  NOT NULL ,
	BR_Start TIMESTAMP NOT NULL,
	BR_Time int NOT NULL,	/*����*/
	BR_IsReturn int,
	foreign key(P_Id)references T_People(P_Id),
	foreign key(B_Id,L_Id)references T_Label(B_Id,L_Id),
	PRIMARY KEY( P_Id,L_Id,BR_Start),
);