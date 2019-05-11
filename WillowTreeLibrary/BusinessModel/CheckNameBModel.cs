using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowTreeLibrary.BusinessModel
{
    public class CheckNameBModel
    {
        public string NameToCheck { get; set; }
        public string EmployeeId { get; set; }

        public CheckNameBModel()
        {
            this.NameToCheck = "";
            this.EmployeeId = "";
        }
    }
}
