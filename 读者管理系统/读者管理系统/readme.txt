2、功能
	读者信息管理可以分为查询，添加，修改，删除四个功能。
读者信息包括卡号，密码。
主要就是根据id号对应读者信息表进行增删查改操作。（SQL语句）

3、实现
使用c#连接到数据库，然后使用在方法中传入SQL语句对数据库中的读者信息表增删查改操作。

SQL语句:（如果需要对读者数量计数，这位增删等操作设置触发器，自动的随着操作修改总数量）
1、增加
insert into T_People([P_Id],[P_Name],[P_Password]) values('3','3号','333');

2、删除
delete
from T_People 
where P_Id = '2';

3、修改
update T_People
set P_Name = '33号'
where P_Id = '3';

4、查询
select * from T_People p where p.P_Id = '3';





