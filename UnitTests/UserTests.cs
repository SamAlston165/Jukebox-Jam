using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using User;

namespace UnitTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mockUser = new Mock<AUser>();
        }
    }
}
