using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowTreeLibrary.BusinessModel
{
    public class FaceGameItemBModel
    {
        public string EmployeeId { get; set; }
        public string HintFullName { get; set; }
        public string ImgUrl { get; set; }
        public string ImgAlt { get; set; }

        public FaceGameItemBModel()
        {
            this.EmployeeId = "";
            this.HintFullName = "";
            this.ImgUrl = "";
            this.ImgAlt = "";
        }
    }
}
