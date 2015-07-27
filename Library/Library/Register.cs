using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Register
    {
        private List<Book> allBooks = new List<Book>();

        
//        public void RemoveBook(Book book)
//        {
//            if (!bookRegister.Contains(book)) return;
//            bookRegister.Remove(book);
//        }
//
//        public bool HasBook(string bookName, string authorName)
//        {
//            return bookRegister.Any(book => book.Name == bookName && book.Author == authorName);
//        }
//
//        public int CountTotalNumberOfBooksInLibrary()
//        {
//            return bookRegister.Count;
//        }
//
//        public int NumberOfCopiesOfBook(string bookName)
//        {
//            var listOfCopies = new List<Book>();
//
//            allBooks.ForEach(book =>
//            {
//                if (book.Name.Equals(bookName))
//                {
//                    listOfCopies.Add(book);
//                }
//            });
//            return listOfCopies.Count;
//        }

        public bool HasBook(string nameOfBook)
        {
            return allBooks.Any(book => book.Name.Equals(nameOfBook));
        }

        public void AddBook(Book book)
        {
            allBooks.Add(book);
        }

        public int IssueBook(string bookName)
        {
            if (HasBook(bookName))
            {
                var bookIssued = allBooks.FirstOrDefault(book => book.Name.Equals(bookName));
                return bookIssued.Equals(null) ? 0 : bookIssued.ID;
            }
            else return 0;
        }
    }
}
