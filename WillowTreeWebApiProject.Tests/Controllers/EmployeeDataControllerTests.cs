using Microsoft.VisualStudio.TestTools.UnitTesting;
using WillowTreeWebApiProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WillowTreeLibrary.BusinessModel;
using System.Web.Http;
using System.Web.Http.Results;

namespace WillowTreeWebApiProject.Controllers.Tests
{
    [TestClass()]
    public class EmployeeDataControllerTests
    {
        [TestMethod()]
        public async Task CheckEmployeeNameTest()
        {
            EmployeeDataController edc = new EmployeeDataController();
            CheckNameBModel cnModel = new CheckNameBModel();

            cnModel.EmployeeId = "2PngvjLZLGImKKq68iC6Yc";
            cnModel.NameToCheck = "Kevin Snead";

            IHttpActionResult result = await edc.CheckEmployeeName(cnModel);

            Assert.IsInstanceOfType(result, typeof(OkResult));
        }

        [TestMethod()]
        public async Task GetAllEmployeesTest()
        {
            EmployeeDataController edc = new EmployeeDataController();
            IHttpActionResult result = await edc.GetAllEmployees();

            var contentResult = result as OkNegotiatedContentResult<List<EmployeeBModel>>;
            int empCount = contentResult.Content.Count;

            Assert.IsTrue(empCount > 0);
        }

        [TestMethod()]
        public async Task GetEmployeeTest()
        {
            EmployeeDataController edc = new EmployeeDataController();
            string id = "2PngvjLZLGImKKq68iC6Yc";
            IHttpActionResult result = await edc.GetEmployee(id);

            var contentResult = result as OkNegotiatedContentResult<EmployeeBModel>;

            string fullName = contentResult.Content.FirstName + " " + contentResult.Content.LastName;

            Assert.IsTrue(fullName == "Kevin Snead");
        }

        [TestMethod()]
        public async Task GetFaceGameDataTest()
        {
            int itemCount = 6;

            EmployeeDataController edc = new EmployeeDataController();
            IHttpActionResult result = await edc.GetFaceGameData(itemCount);

            var contentResult = result as OkNegotiatedContentResult<FaceGameBModel>;

            Assert.IsTrue(contentResult.Content.FaceGameItemList.Count == 6);
        }
    }
}