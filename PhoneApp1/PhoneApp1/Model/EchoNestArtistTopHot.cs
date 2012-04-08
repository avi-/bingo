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


//http://developer.echonest.com/api/v4/artist/top_hottt?api_key=N6E4NIOVYMTHNDM8J&format=json&results=20&start=0&bucket=hotttnesss
namespace PhoneApp1.Model
{
    public class Status
    {
        public string version { get; set; }
        public int code { get; set; }
        public string message { get; set; }
    }

    public class Artist
    {
        public string name { get; set; }
        public double hotttnesss { get; set; }
        public string id { get; set; }
    }

    public class Response
    {
        public Status status { get; set; }
        public List<Artist> artists { get; set; }
    }

    public class EchoNestArtistTopHot
    {
        public Response response { get; set; }
    }
}
