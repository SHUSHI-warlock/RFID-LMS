using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 图书馆借还系统
{
    class BookLabel
    {
        string id;
        bool isBorrow;

        public BookLabel(string Id,bool Sig)
        {
            id = Id;
            isBorrow = Sig;
        }
        public string ID
        {
            set{id = value;}
            get{ return id;}
        }
        public bool SIG
        {
            set{ isBorrow = value;}
            get{return isBorrow;}
        }
    }
    interface Reader
    {
        List<BookLabel> GetReader();
        List<BookLabel> GetReader(int n);
        bool SetReader();
        bool SetReader(List<BookLabel> books);
    }
    class RFIDReader : Reader
    {
        public List<BookLabel> GetReader()
        {
            return null;
        }
        public List<BookLabel> GetReader(int n)
        {
            return null;
        }
        public bool SetReader()
        {
            return true;
        }
        public bool SetReader(List<BookLabel> books)
        {
            return true;
        }
    }
    class FileReader : Reader
    {
        public List<BookLabel> GetReader()
        {
            return null;
        }
        public List<BookLabel> GetReader(int n)
        {
            return null;
        }
        public bool SetReader()
        {
            return true;
        }
        public bool SetReader(List<BookLabel> books)
        {
            return true;
        }
    }
}
