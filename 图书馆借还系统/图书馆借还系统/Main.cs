using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 图书馆借还系统
{
    public partial class Main : Form
    {
        BorrowForm BForm;
        ReturnForm RForm;
        LoginFrom LForm;
        SarchForm SForm;
        

        const string strBF = "BForm";
        const string strRF = "RForm";
        const string strLF = "LForm";
        const string strSF = "SForm";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        
            BForm = new BorrowForm(this);
            RForm = new ReturnForm(this);
            LForm = new LoginFrom(this); 
            SForm = new SarchForm(this); 
        }

        private void HideAllWin()
        {
            this.Visible = false;
            BForm.Visible = false;
            RForm.Visible = false;
            LForm.Visible = false;
            SForm.Visible = false;
        }
        //选择进入其他界面
        public void Enter2Win(string winName,string nextWin="",string userid="")
        {
            HideAllWin();
            switch (winName)
            {
                case strBF:BForm.ShowMyWin(userid);
                    break;
                case strRF:RForm.ShowMyWin();
                    break;
                case strLF:LForm.ShowMyWin(nextWin);
                    break;
                case strSF:SForm.ShowMyWin(userid);
                    break;
            }
        }
        //返回主界面
        public void ReturnMainWin()
        {
            HideAllWin();
            this.Visible = true;
        }

        //借书按钮
        private void button_B_Click(object sender, EventArgs e)
        {
            Enter2Win(strLF, strBF);
        }
        //还书按钮
        private void button_R_Click(object sender, EventArgs e)
        {
            Enter2Win(strRF);
        }
        //查询按钮
        private void button_S_Click(object sender, EventArgs e)
        {
            Enter2Win(strLF, strSF);
        }
    }
}
