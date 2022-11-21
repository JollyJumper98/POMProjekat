using NUnit.Framework;
using OrangeProjekat.Driver;
using OrangeProjekat.Page;

namespace OrangeProjekat
{
    public class Tests
    {
        Login login;
        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            login = new Login();
        }

        [Test]
        public void Test1()
        {
            login.LoginUser("Admin","Admin123");
        }
    }
}