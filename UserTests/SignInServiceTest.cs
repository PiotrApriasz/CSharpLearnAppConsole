using DataAccess;
using NUnit.Framework;

namespace UserTests
{
    public class SignInServiceTest
    {
        [Test]
        public void FindUserCorrect_Test()
        {
            var actual = SignInService.FindUser("piotrek", "123");
            
            Assert.Multiple((() =>
            {
                Assert.AreEqual("piotrek", actual.Username); 
                Assert.AreEqual("123", actual.Password);
                Assert.AreEqual("Piotr", actual.Name);
                Assert.AreEqual("Apriasz", actual.LastName);
                Assert.AreEqual("demik534@gmail.com", actual.Email);
            }));
        }

        [Test]
        public void FindUserNull_Test()
        {
            var actual = SignInService.FindUser("incorrect", "incorrect");
            
            Assert.IsNull(actual);
        }
    }
}