using Microsoft.VisualStudio.TestTools.UnitTesting;
using WillowTreeLibrary.BusinessControl;
using WillowTreeLibrary.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowTreeLibrary.BusinessControl.Tests
{
    [TestClass()]
    public class EmployeeBControlTests
    {
        [TestMethod()]
        public async Task GetEmployeeListTest()
        {          
            string apiUrl = @"https://www.willowtreeapps.com/api/v1.0/profiles";
            EmployeeBControl ec = new EmployeeBControl();

            List<EmployeeBModel> list = await ec.GetEmployeeList(apiUrl);

            List<EmployeeBModel> list1 = await ec.GetEmployeeList(apiUrl);

            Assert.IsTrue(list.Count == list1.Count);
        }        
    }
}