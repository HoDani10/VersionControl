//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnitTestExample.Abstractions;
using UnitTestExample.Controllers;
using UnitTestExample.Entities;

namespace UnitTestExample.Test
{
    class AccountControllerTestFixture
    {
        [
            Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            //arrange
            var accountController = new AccountController();

            //act
            var actualResult = accountController.ValidateEmail(email);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [
        Test,
        TestCase("irf@uni-corvinus.hu", true),
        TestCase("abcd1234", false)
        ]
        public void TestRegisterHappyPath(string email, string password)
        {
            // Arrange
            var accountServiceMock = new Mock<IAccountManager>(MockBehavior.Strict); 
            accountServiceMock
                .Setup(m => m.CreateAccount(It.IsAny<Account>()))
                .Returns<Account>(a => a);

            var accountController = new AccountController();
            accountController.AccountManager = accountServiceMock.Object;

            // Act
            var actualResult = accountController.Register(email, password);

            // Assert
            Assert.AreEqual(email, actualResult.Email);
            Assert.AreEqual(password, actualResult.Password);
            Assert.AreNotEqual(Guid.Empty, actualResult.ID);
        }
        [
        Test,
        TestCase("irf@uni-corvinus.hu", "Abcd1234")
        ]
        public void TestRegisterValidateExeption(string email, string password)
        {
            // Arrange
            var accountServiceMock = new Mock<IAccountManager>(MockBehavior.Strict);
            accountServiceMock
                .Setup(m => m.CreateAccount(It.IsAny<Account>()))
                .Throws<ApplicationException>();
            var accountController = new AccountController();
            accountController.AccountManager = accountServiceMock.Object;

            // Act
            try
            {
                var actualResult = accountController.Register(email, password);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ValidationException>(ex);
            }

        }
        /*
        [
            Test, 
            TestCase("ABCD1234", false),
            TestCase("Ab1234", false),
            TestCase("Abcd1234", true),
            TestCase("abcd1234", false),
            TestCase("abcdABCD", false),

         ]
        public void TestValidatePassword(string password, bool expectedResult)
        { 
            //arrange
            var accountController = new AccountController();

            //act
            var actualResult = accountController.ValidatePassword(password);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
            //regex
            //Regex r = new Regex("^[A-Z0-9]{6}$");
            //r.IsMatch(password);
        }
        */
    }
}

