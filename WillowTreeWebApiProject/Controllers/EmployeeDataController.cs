using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Caching;
using System.Threading.Tasks;
using System.Web.Http;
using WillowTreeLibrary.BusinessControl;
using WillowTreeLibrary.BusinessModel;
using WillowTreeLibrary.CommonUtils;

namespace WillowTreeWebApiProject.Controllers
{
    [Authorize]
    [WillowTreeExceptionFilter]
    [RoutePrefix("api/EmployeeData")]
    public class EmployeeDataController : ApiController
    {
        private string willowTreeApi = ConfigUtils.EmployeeApiUrl;
        public EmployeeDataController()
        {
        }

        [HttpGet]
        [Route("GetFaceGameData")]
        public async Task<IHttpActionResult> GetFaceGameData(int itemCount)
        {
            FaceGameBModel faceGameModel = new FaceGameBModel();

            EmployeeBControl ec = new EmployeeBControl();
            List<EmployeeBModel> employeeList = await ec.GetEmployeeList(willowTreeApi);

            if(itemCount > employeeList.Count)
            {
                return Content(HttpStatusCode.BadRequest, "Item Count cannot be more than " + employeeList.Count.ToString() + "!");
            }
            else
            {
                //Get the no repeat random index list
                List<int> indexList = new List<int>();
                int index;
                int totalCount = employeeList.Count;
                Random rand = new Random();
                for (int i = 0; i < itemCount; i++)
                {
                    do
                    {
                        index = rand.Next(1, totalCount);
                    } while (indexList.Contains(index));
                    indexList.Add(index);
                }

                //Fill all random employees
                foreach(int curIndex in indexList)
                {
                    EmployeeBModel curEmp = employeeList[curIndex];

                    FaceGameItemBModel item = new FaceGameItemBModel();
                    item.EmployeeId = curEmp.Id;
                    item.HintFullName = curEmp.FirstName + " " + curEmp.LastName;
                    item.ImgUrl = curEmp.HeadShot.Url;
                    item.ImgAlt = curEmp.HeadShot.Alt;

                    faceGameModel.FaceGameItemList.Add(item);
                }

                //Get sorted distinct full name list
                faceGameModel.DistictFullNameList = employeeList.Select(x => x.FirstName + " " + x.LastName).Distinct().OrderBy(x=>x).ToList();
            }
                      

            return Ok(faceGameModel);

        }

        [HttpPost]
        [Route("CheckEmployeeName")]
        public async Task<IHttpActionResult> CheckEmployeeName([FromBody]CheckNameBModel checkNameModel)
        {
            EmployeeBControl ec = new EmployeeBControl();
            List<EmployeeBModel> employeeList = await ec.GetEmployeeList(willowTreeApi);

            EmployeeBModel emp = employeeList.Where(x => x.Id == checkNameModel.EmployeeId).FirstOrDefault();

            if(emp == null)
            {                
                string message = "Could not find Employee with Id = " + checkNameModel.EmployeeId + "!";

                //Unusally case, log this information for future investigation
                LogToFile logger = new LogToFile();
                logger.Log(message, MessageType.Information);

                return Content(HttpStatusCode.NotFound, message);
            }
            else
            {
                string fullName = emp.FirstName + " " + emp.LastName;
                if (fullName.ToLower() == checkNameModel.NameToCheck.ToLower())
                {
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }            
        }

        [HttpGet]
        [Route("GetAllEmployees")]
        public async Task<IHttpActionResult> GetAllEmployees()
        {
            EmployeeBControl ec = new EmployeeBControl();
            List<EmployeeBModel> employeeList = await ec.GetEmployeeList(willowTreeApi);

            return Ok(employeeList);
        }

        [HttpGet]
        [Route("GetEmployee")]
        public async Task<IHttpActionResult> GetEmployee(string id)
        {
            EmployeeBControl ec = new EmployeeBControl();
            List<EmployeeBModel> employeeList = await ec.GetEmployeeList(willowTreeApi);

            EmployeeBModel emp = employeeList.Where(x => x.Id == id).FirstOrDefault();

            if (emp == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(emp);
            }
        }




        protected override void Dispose(bool disposing)
        {
        }
    }
}
