using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Books
    {
        private int _id;
        private string _category;
        private string _name;
        private string _author;

        public Books(int id, string category, string name, string author)
        {
            _id = id;
            _category = category;
            _name = name;
            _author = author;
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
    }
}