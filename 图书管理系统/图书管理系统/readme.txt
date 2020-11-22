--登录窗口
	控件列表
	Label1 用户名
	Label2 密码
	(Textbox)username 接收用户名
	(Textbox)password 接收密码
	(button) submit 提交按钮
	以及一个充当提示的东西，用来告知用户登录是否成功
	可以是弹出框（这个应该好一些），或者用一个隐藏控件显示

	布局说明
	username和Label1一行，password和Label2一行；
	Label1和Label2  password和username 竖直对齐；
	password是密码类型，输入时显示的是*号
	不允许放大缩小

	功能说明
	输入用户名和密码，然后与（数据库/程序内写死/加密文件）中的密码比较
	相等则跳转到主界面（也弹出提示？），否则弹出提示


--主界面窗口
	控件列表
	一个tabcontrol控件，用来显示多个子页
	①图书信息管理
		bt_addbook 添加图书，入库。点击后显示（panel）pl_addbook
		图书入库界面 pl_addbook
			bt_out_RK 返回，图书管理系统,隐藏pl_addbook
			bt_bookin 图书入库按钮
			bt_readtag 读标签按钮
			tb_tagtext 标签内容
			cbb_class 分类的下拉列表
			tb_author 作者
			tb_bookname 书名
			tb_bookid 书号
