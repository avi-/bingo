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
    /// Play Tokens are used to control access and playback of mixes and tracks. Rules, such as randomized tracks after the first listen of a mix, are applied accordingly. Play tokens are scoped around a single user for unlimited mix playback
    /// </summary>
    /// 

    //http://8tracks.com/sets/new.json?api_key=5aca54a2ba7c7a3ef7c5d7410738021bdcf742ec

    public class EightTrackPlayToken
    {
        public string play_token { get; set; }
        public string status { get; set; }
        public object errors { get; set; }
        public object notices { get; set; }
        public List<string> api_warning { get; set; }
        public int api_version { get; set; }
    }
}
