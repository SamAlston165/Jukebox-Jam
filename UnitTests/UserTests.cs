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
            user.Username = username;

            //assert
            //Check if property matches the dynamic setter

            Assert.AreEqual(username, user.Username);
        }

        [TestMethod]
        public void LoginWithValidUsernameAndPasswordIsSuccessful()
        {
            const string username = "user1";
            const string password = "user1";

            //arrange
            Login login = new Login();
            var user = new Mock<IUser>();

            //act
            //user.Object = login.AuthorizeUser(username, password);

            //assert
            //Assert.AreEqual(username, user.Username);
        }

        [TestMethod]
        public void LoginWithInvalidUsernameAndPasswordReturnsNull()
        {
            const string username = "user1";
            const string password = "asfd";

            //arrange
            Login login = new Login();
            var user = new Mock<IUser>();

            //act
            //user.Object = login.AuthorizeUser(username, password);

            //assert
            //Assert.AreEqual(username, user.Username);
        }
    }
}
