using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Register
    {
        private List<Books> bookRegister = new List<Books>();


        public void AddBook(Books book)
        {
            bookRegister.Add(book);
        }

        public void RemoveBook(Books book)
        {
            if (!bookRegister.Contains(book)) return;
            bookRegister.Remove(book);
        }

        public bool HasBook(string bookName, string authorName)
        {
            return bookRegister.Any(book => book.Name == bookName && book.Author == authorName);
        }

        public int CountTotalNumberOfBooksInLibrary()
        {
            return bookRegister.Count();
        }

        public int NumberOfCopiesOfBook(string bookName, string authorName)
        {
            var listOfCopies = bookRegister.Where(book => book.Name == bookName && book.Author == authorName);
            return listOfCopies.Count();
        }
    }
}
