using Microsoft.VisualStudio.TestTools.UnitTesting;
using WillowTreeWebApiProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WillowTreeWebApiProject.Models;
using System.Web.Http;

namespace WillowTreeWebApiProject.Controllers.Tests
{
    [TestClass()]
    public class AccountControllerTests
    {
        [TestMethod()]
        public async Task RegisterTest1()
        {
            RegisterBindingModel model = new RegisterBindingModel();
            model.Email = "eric@yahoo.com";
            model.Password = "Test@123456!";
            model.ConfirmPassword = "Test@123456!";

            AccountController ac = new AccountController();
            IHttpActionResult x = await ac.Register(model);

            Assert.Fail();
        }
    }
}