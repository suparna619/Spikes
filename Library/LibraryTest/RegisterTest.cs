using System.Configuration;
using Library;
using NUnit.Framework;


namespace LibraryTest
{
    [TestFixture]
    class RegisterTest
    {
        private Register register;
        private Book book1;
        private Book book2;

        [SetUp]
        public void SetUp()
        {
            register = new Register();
            book1 = new Book(101, "Macbeth", "Shakespeare");
            book2 = new Book(102, "Macbeth", "Shakespeare");
        }


/*        [Test]
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
        }*/


/*        [Test]
        public void BookIssue_Should_Be_Able_A_User_To_Have_A_Book()
        {
            register.AddBook(book1);
            register.AddBook(book2);
            var user1 = new User();
            var requestedBookName = "Macbeth";
            var requestedBookAuthor = "Shakespeare";
            Assert.IsTrue(user1.IssuedBook);
            
        }*/

        [Test]
        public void Should_Be_Able_To_Check_If_A_Book_Is_Available()
        {
            register.AddBook(book1);
            var hasBook = register.HasBook("Macbeth");
            Assert.That(hasBook);
        }

        [Test]
        public void If_Book_Is_Available_User_Can_Issue_That()
        {
            register.AddBook(book1);
            var issueId1 = register.IssueBook("Macbeth");
            var issueId2 = register.IssueBook("Hamlet");
            Assert.NotNull(issueId1);
            Assert.AreEqual(0, issueId2);
        }

    }
}