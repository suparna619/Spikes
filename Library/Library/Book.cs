namespace Library
{
    public class Book
    {
        private readonly int _id;
        private readonly string _name;
        private readonly string _author;

        public Book(int id, string name, string author)
        {
            _id = id;
            _name = name;
            _author = author;
        }

        public int ID
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
        }
        
        public string Author
        {
            get { return _author; }
        }
    }
}