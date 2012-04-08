using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

//http://developer.echonest.com/api/v4/artist/images?api_key=N6E4NIOVYMTHNDM8J&id=ARH6W4X1187B99274F&format=json&results=1&start=0&license=unknown
namespace PhoneApp1.Model
{
    public class Status
    {
        public string version { get; set; }
        public int code { get; set; }
        public string message { get; set; }
    }

    public class License
    {
        public string type { get; set; }
        public string attribution { get; set; }
        public string url { get; set; }
    }

    public class Image
    {
        public string url { get; set; }
        public License license { get; set; }
    }

    public class Response
    {
        public Status status { get; set; }
        public int start { get; set; }
        public int total { get; set; }
        public List<Image> images { get; set; }
    }

    public class EchoNestArtistImage
    {
        public Response response { get; set; }
    }
}
