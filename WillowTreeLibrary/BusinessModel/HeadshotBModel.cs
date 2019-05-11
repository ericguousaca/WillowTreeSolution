using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillowTreeLibrary.BusinessModel
{
    public class HeadshotBModel
    {
        //"type": "image",
        //    "mimeType": "image/png",
        //    "id": "4bvrsSqvsp44wjlSWzYhLg",
        //    "url": "//images.ctfassets.net/3cttzl4i3k1h/4bvrsSqvsp44wjlSWzYhLg/02410607d445298e5f9b24f5a2cc63d1/402-3-4.png",
        //    "alt": "Christina Simmons",
        //    "height": 170,
        //    "width": 170
        public string Type { get; set; }
        public string MimeType { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
        public string Alt { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public HeadshotBModel()
        {
            this.Type = "";
            this.MimeType = "";
            this.Id = "";
            this.Url = "";
            this.Alt = "";
            this.Height = 0;
            this.Width = 0;
        }
    }
}
