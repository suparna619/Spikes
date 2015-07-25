using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Register
    {
        public List<Books> bookRegister = new List<Books>();


        public void AddBook(Books book)
        {
            bookRegister.Add(new Books(book.ID, book.Category, book.Name, book.Author));
        }

        public void RemoveBook(Books book)
        {
            bookRegister.Remove(book);
        }
        
    }
}
