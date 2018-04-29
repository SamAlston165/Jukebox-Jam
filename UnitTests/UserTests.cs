using System;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using User;

namespace UnitTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void UsernameGetAndSetAreSuccessful()
        {
            const string username = "user";

            //arrange
            var user = new AUser("");

            //act
            user.Username = username;

            //assert
            Assert.AreEqual(username, user.Username);
        }

        [TestMethod]
        public void LoginWithAnyUsernameAndPasswordIsSuccessful()
        {
            const string expectedUsername = "user1";
            const string password = "user1";

            //arrange
            Login login = new Login();

            //act
            string resultUsername = login.AuthorizeUser(expectedUsername, password).Username;

            //assert
            Assert.AreEqual(expectedUsername, resultUsername);
        }
    }
}
