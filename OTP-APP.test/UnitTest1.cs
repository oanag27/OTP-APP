using Microsoft.EntityFrameworkCore;
using OTP_APP.Domain;
using System;
using OTP_APP.Repository;
using OTP_APP.Validations;
using Microsoft.AspNetCore.Mvc;
using OTP_APP.Controllers.OTP;
using OTP_APP.Controllers.Register;
using OTP_APP.Service;
using Moq;

namespace OTP_APP.test
{
    public class Tests
    {


        [TestFixture]
        public class UserRegisterValidationTests
        {
            [Test]
            public void TestValidEmail()
            {
                string email = "test@example.com";
                bool result = UserRegisterValidation.IsValidEmail(email);
                Assert.IsTrue(result);
            }

            [Test]
            public void TestInvalidEmailLength()
            {
                string email = "ana";
                bool result = UserRegisterValidation.IsValidEmail(email);
                Assert.IsFalse(result);
            }

            [Test]
            public void TestInvalidEmail()
            {
                string email = "email";
                bool result = UserRegisterValidation.IsValidEmail(email);
                Assert.IsFalse(result);
            }

            [Test]
            public void TestInvalidUsername()
            {
                string username = "ana";
                bool result = UserRegisterValidation.IsValidUsername(username);
                Assert.IsFalse(result);
            }
        }

        //[Test]
        //public void TestSuccesfulPassword()
        //{
        //    var controller = new OtpController();
        //    var result = controller.GenerateOTPPassword() as OkObjectResult;
        //    var otpPassword = result.Value.ToString();
        //    Assert.AreEqual(200, result.StatusCode);
        //}

        [Test]
        public void TestSuccesfulIActionResultPassword()
        {
            var controller = new OtpController();
            var result = controller.GenerateOTPPassword() as OkObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.IsNotNull(result.Value);
            Assert.IsTrue(result.Value.ToString().Length > 0);
        }

    }
}