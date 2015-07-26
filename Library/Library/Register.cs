using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            bool result = bookRegister.Any(book => book.Name == bookName && book.Author == authorName);

            return result;

        }
    }
}
