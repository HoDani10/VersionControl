//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

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
        }
    }
}

