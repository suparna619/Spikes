using Library;
using NUnit.Framework;


namespace LibraryTest
{
    [TestFixture]
    class RegisterTest
    {
        private Register register;
        private Books book1;
        private Books book2;

        [SetUp]
        public void SetUp()
        {
            register = new Register();
            book1 = new Books(101, "Drama", "Macbeth", "Shakespeare");
            book2 = new Books(102, "Drama", "Macbeth", "Shakespeare");
        }


        [Test]
        public void AddBook_Should_Add_A_Book_Inside_Book_Register()
        {
            register.AddBook(book1);
            register.AddBook(book2);
            Assert.IsTrue(register.HasBook(book1.Name, book1.Author));
            Assert.IsFalse(register.HasBook("Hamlet", "Shakespeare"));
            Assert.AreEqual(2, register.CountTotalNumberOfBooksInLibrary());

        }

        [Test]
        public void NumberOfCopiesOfBook_Should_Return_2_For_Macbeth()
        {
            register.AddBook(book1);
            register.AddBook(book2);
            Assert.AreEqual(2, register.NumberOfCopiesOfBook("Macbeth", "Shakespeare"));
        }

        [Test]
        public void RemoveBook_Should_Remove_A_Book_From_Register()
        {
            register.AddBook(book1);
            register.RemoveBook(book1);
            Assert.IsFalse(register.HasBook(book1.Name, book1.Author));
        }
    }
}