using ApplicationCore;
using DataAccess;
using NUnit.Framework;

namespace UserTests
{
    public class RegisterServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SignUpTest()
        {
            var user = new User()
            {
                Username = "piotrek",
                Password = "123",
                Name = "Piotr",
                LastName = "Apriasz",
                Email = "demik534@gmail.com"
            };

            var register = RegisterService.SignUp(user);
            
            Assert.IsTrue(register);
        }
    }
}