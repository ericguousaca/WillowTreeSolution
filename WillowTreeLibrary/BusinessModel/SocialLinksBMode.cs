using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowTreeLibrary.BusinessModel
{
    //"socialLinks": [
    //        {
    //            "type": "linkedin",
    //            "callToAction": "Follow Kevin Snead on LinkedIn",
    //            "url": "https://www.linkedin.com/in/kevinsnead/"
    //        }
    //    ]
    public class SocialLinksBMode
    {
        public string Type { get; set; }
        public string CallToAction { get; set; }
        public string Url { get; set; }

        public SocialLinksBMode()
        {
            this.Type = "";
            this.CallToAction = "";
            this.Url = "";
        }
    }
}
