using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace WillowTreeLibrary.CommonUtils
{
    //Custom Exception filter that can be used to catch unhandled exception for API control/method
    public class WillowTreeExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {            
            StringBuilder sb = new StringBuilder();

            Exception curExp = actionExecutedContext.Exception;
            while(curExp != null)
            {
                sb.Append(curExp.Message + Environment.NewLine);
                curExp = curExp.InnerException;
            }

            string message = sb.ToString();

            //Log exception to log file
            LogToFile logger = new LogToFile();
            logger.Log(message, MessageType.Exception);

            var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent("Unhanded exception was thrown by service:" + Environment.NewLine + message),
                ReasonPhrase = "Internal Server Error, please contact IT Support!",
            };

            actionExecutedContext.Response = response;
        }
    }
}
