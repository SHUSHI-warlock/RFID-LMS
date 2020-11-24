using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 图书管理系统
{
    class BookLabel
    {
        private string ID
        {
            set
            {
                ID = value;
            }
            get
            {
                return ID;
            }
        }
        private bool SIG
        {
            set
            {
                SIG = value;
            }
            get
            {
                return SIG;
            }
        }
    }
    interface Reader
    {
        List<BookLabel> GetReader();
        List<BookLabel> GetReader(int n);
    }
    class RFIDReader
    {

    }
    class FileReader
    {

    }
}
