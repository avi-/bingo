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

//http://developer.echonest.com/api/v4/artist/profile?api_key=N6E4NIOVYMTHNDM8J&id=ARH6W4X1187B99274F&bucket=id:7digital-US&format=json
namespace PhoneApp1.Model
{
    public class Status
    {
        public string version { get; set; }
        public int code { get; set; }
        public string message { get; set; }
    }

    public class ForeignId
    {
        public string catalog { get; set; }
        public string foreign_id { get; set; }
    }

    public class Artist
    {
        public List<ForeignId> foreign_ids { get; set; }
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Response
    {
        public Status status { get; set; }
        public Artist artist { get; set; }
    }

    public class EchoNestArtistProfile
    {
        public Response response { get; set; }
    }
}
