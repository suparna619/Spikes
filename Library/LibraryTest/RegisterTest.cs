using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using NUnit.Framework;


namespace LibraryTest
{
    [TestFixture]
    class RegisterTest
    {
        [Test]
        public void AddBook_Should_Add_A_Book_Inside_Book_Register()
        {
            var newBook = new Books(101, "Drama", "Macbeth", "Shakespeare");
            var register = new Register();
            register.AddBook(newBook);
            Assert.IsTrue(register.HasBook(newBook.Name, newBook.Author));
            Assert.IsFalse(register.HasBook("Hamlet", "Shakespeare"));
        }
    }
}