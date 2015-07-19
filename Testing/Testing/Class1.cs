using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Testing
{
    public class User
    {
        public string Name;
        public int Age;

        public User(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    public class Tests
    {
        [Test]
        public void ShouldReturnAllTheNameStartsWithS()
        {
            var users = new List<User>()
            {
              new User("Vijay", 21),
              new User("Suparna", 22),
              new User("Sayli", 20)
            };

            List<string> listOfUsersWhoseNameStartsWithS = users.Where(ele => ele.Name.StartsWith("S")).Select(e => e.Name).ToList();

            CollectionAssert.AreEqual(new List<string>() { "Suparna", "Sayli" }, listOfUsersWhoseNameStartsWithS);
        }


    }

}
