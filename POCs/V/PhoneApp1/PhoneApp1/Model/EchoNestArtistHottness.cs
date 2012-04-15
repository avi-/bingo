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


//http://developer.echonest.com/api/v4/artist/hotttnesss?api_key=N6E4NIOVYMTHNDM8J&id=ARH6W4X1187B99274F&format=json
namespace PhoneApp1.Model
{
    //public class Status
    //{
    //    public string version { get; set; }
    //    public int code { get; set; }
    //    public string message { get; set; }
    //}

    //public class Artist
    //{
    //    public double hotttnesss { get; set; }
    //    public string id { get; set; }
    //    public string name { get; set; }
    //}

    //public class Response
    //{
    //    public Status status { get; set; }
    //    public Artist artist { get; set; }
    //}

    public class EchoNestArtistHottness
    {
        public Response response { get; set; }
    }
}
