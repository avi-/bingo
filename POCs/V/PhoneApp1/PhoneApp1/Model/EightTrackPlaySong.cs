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

namespace PhoneApp1.Model
{

    /// <summary>
    /// this is the play token we have generated 807789426
    /// http://8tracks.com/sets/807789426/play.json?api_key=5aca54a2ba7c7a3ef7c5d7410738021bdcf742ec&mix_id=31453
    /// </summary>
    public class Track
    {
        public int id { get; set; }
        public string name { get; set; }
        public string performer { get; set; }
        public string release_name { get; set; }
        public int year { get; set; }
        public string url { get; set; }
        public bool faved_by_current_user { get; set; }
        public string buy_link { get; set; }
        public string buy_icon { get; set; }
        public int play_duration { get; set; }
    }

    public class Set
    {
        public bool at_beginning { get; set; }
        public bool at_end { get; set; }
        public bool at_last_track { get; set; }
        public bool skip_allowed { get; set; }
        public Track track { get; set; }
    }

    public class EightTrackPlaySong
    {
        public Set set { get; set; }
        public string status { get; set; }
        public object errors { get; set; }
        public string notices { get; set; }
        public List<string> api_warning { get; set; }
        public int api_version { get; set; }
    }
}
