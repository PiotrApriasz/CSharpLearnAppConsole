using DataAccess;
using NUnit.Framework;

namespace UserTests
{
    public class SignInServiceTest
    {
        [Test]
        public void FindUser_Test()
        {
            var actual = SignInService.FindUser("piotrek", "123");
            Assert.IsTrue(actual);
        }
    }
}