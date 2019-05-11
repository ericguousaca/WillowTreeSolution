using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowTreeLibrary.CommonUtils
{
    public interface ILog
    {
        void Log(string message, MessageType msgType);       
    }
}
