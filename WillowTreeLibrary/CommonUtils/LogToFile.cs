using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WillowTreeLibrary.CommonUtils
{
    public class LogToFile : ILog
    {        
        private string logFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, "WillowTreeAppLog.txt");

        public LogToFile()
        {            
        }

        public LogToFile(string logFilePath)
        {
            this.logFilePath = logFilePath;
        }

        public void Log(string message, MessageType msgType)
        {                       
            StringBuilder sb = new StringBuilder();
            sb.Append("---------------------------" + Environment.NewLine);
            sb.Append(msgType.ToString() + " " + DateTime.Now.ToString() + Environment.NewLine);
            sb.Append(message + Environment.NewLine);
            sb.Append(Environment.NewLine);

            using (StreamWriter writer = new StreamWriter(this.logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }

       
    }
}
