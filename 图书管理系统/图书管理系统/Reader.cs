using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace 图书馆借还系统
{
    class BookLabel
    {
        string id;
        bool isReturn;

        public BookLabel(string Id, bool Sig)
        {
            id = Id;
            isReturn = Sig;
        }
        public string ID
        {
            set { id = value; }
            get { return id; }
        }
        public bool SIG
        {
            set { isReturn = value; }
            get { return isReturn; }
        }
    }
    interface Reader
    {
        BookLabel GetReader();
        List<BookLabel> GetReader(int n);
        bool SetReader(BookLabel book);
        bool SetReader(List<BookLabel> books);
    }
    class RFIDReader : Reader
    {
        public BookLabel GetReader()
        {
            return null;
        }
        public List<BookLabel> GetReader(int n)
        {
            return null;
        }
        public bool SetReader(BookLabel book)
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
        //读取标签的文件夹
        string readerFolder;

        public FileReader() { }
        public FileReader(string Folder)
        {
            WorkFolder = Folder;
        }


        public string WorkFolder
        {
            set { readerFolder = value; }
        }
        //开启读取区
        private DirectoryInfo ReadFolder()
        {
            if (!Directory.Exists(readerFolder))
            {
                //默认创建一个
                string defaultFolder = ConfigurationManager.AppSettings["root"].ToString() + "\\Reader";
                if (Directory.Exists(defaultFolder))
                    readerFolder = defaultFolder;
                else
                    return Directory.CreateDirectory(defaultFolder);
            }
            return new DirectoryInfo(readerFolder);
        }
        //解析标签内容
        private BookLabel PraseFile2Label(string fileName)
        {
            string Label = fileName.Substring(0, 5);
            bool isReturn = fileName[5] == '0' ? false : true;
            return new BookLabel(Label, isReturn);
        }
        private string PraseLabel2File(BookLabel label)
        {
            string newfile = label.ID;
            newfile += label.SIG == false ? '0' : '1';
            return newfile;
        }

        public BookLabel GetReader()
        {
            DirectoryInfo di = ReadFolder();
            FileInfo[] labels = di.GetFiles();
            if (labels.Length == 0)
                return null;
            else
                return PraseFile2Label(labels[0].Name);
        }
        public List<BookLabel> GetReader(int n)
        {
            DirectoryInfo di = ReadFolder();
            FileInfo[] labels = di.GetFiles();
            if (labels.Length == 0)
                return null;

            List<BookLabel> bookLabels = new List<BookLabel>(n);
            for (int i = 0; i < labels.Length && i < n; i++)
                bookLabels.Add(PraseFile2Label(labels[i].Name));
            return bookLabels;
        }

        public bool SetReader(BookLabel book)
        {
            DirectoryInfo di = ReadFolder();
            string path = di.Root.ToString();
            FileInfo[] labels = di.GetFiles();
            if (labels.Length == 0)
                return false;
            for (int i = 0; i < labels.Length; i++)
            {
                if (book.ID == PraseFile2Label(labels[i].Name).ID)
                {
                    string newfile = PraseLabel2File(book);
                    labels[0].MoveTo(path + "\\" + newfile);
                    return true;
                }
            }
            return false;
        }
        public bool SetReader(List<BookLabel> books)
        {
            DirectoryInfo di = ReadFolder();
            string path = di.FullName;
            FileInfo[] labels = di.GetFiles();
            if (labels.Length == 0)
                return false;

            while (books.Count() != 0)
            {
                BookLabel book = books[0];
                bool flag = false;
                for (int i = 0; i < labels.Length; i++)
                {
                    if (book.ID == PraseFile2Label(labels[i].Name).ID)
                    {
                        string newfile = PraseLabel2File(book);
                        labels[i].MoveTo(path + "\\" + newfile);
                        flag = true;
                        break;
                    }
                }
                if (!flag)//有一个标签没写上
                    return false;
                books.RemoveAt(0);
            }
            return true;
        }
    }
}
