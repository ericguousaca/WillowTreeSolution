using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowTreeLibrary.BusinessModel
{
    public class EmployeeBModel
    {
    //    {
    //    "id": "2PngvjLZLGImKKq68iC6Yc",
    //    "type": "people",
    //    "slug": "kevin-snead",
    //    "jobTitle": "Senior VP of Engineering",
    //    "firstName": "Kevin",
    //    "lastName": "Snead",
    //    "headshot": {
    //        "type": "image",
    //        "mimeType": "image/png",
    //        "id": "2Xl9FtYx4cMEgaiyoQEIue",
    //        "url": "//images.ctfassets.net/3cttzl4i3k1h/2Xl9FtYx4cMEgaiyoQEIue/e6c650aae70c18f68fb2e5aee92a21d8/kevin.png",
    //        "alt": "Kevin Snead, VP of Engineering at WillowTree, Inc.",
    //        "height": 664,
    //        "width": 664
    //    },
    //    "bio": "Senior VP of Engineering",
    //    "socialLinks": [
    //        {
    //            "type": "linkedin",
    //            "callToAction": "Follow Kevin Snead on LinkedIn",
    //            "url": "https://www.linkedin.com/in/kevinsnead/"
    //        }
    //    ]
    //},
        public string Id { get; set; }
        public string Type { get; set; }
        public string Slug { get; set; }
        public string JobTitle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public HeadshotBModel HeadShot { get; set; }
        public string Bio { get; set; }
        public List<SocialLinksBMode> SocialLinks { get; set; }

        public EmployeeBModel()
        {
            this.Id = "";
            this.Type = "";
            this.Slug = "";
            this.JobTitle = "";
            this.FirstName = "";
            this.LastName = "";
            this.HeadShot = new HeadshotBModel { };
            this.Bio = "";
            this.SocialLinks = new List<SocialLinksBMode> { };
        }
    }
}
