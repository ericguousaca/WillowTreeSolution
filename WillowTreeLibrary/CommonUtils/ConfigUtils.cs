using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowTreeLibrary.CommonUtils
{
    public class ConfigUtils
    {
        public static string EmployeeApiUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["EmployeeApiUrl"];
            }
        }
    }
}
