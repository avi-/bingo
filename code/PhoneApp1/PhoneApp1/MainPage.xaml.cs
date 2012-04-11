using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using PhoneApp1.Model;
using Microsoft.Phone.BackgroundAudio;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            EightTrackDataService obj = new EightTrackDataService();
            obj.playEightTrackSong("807789426", "31453", (se, ev) =>
                {
                    MyAudioPlaybackAgent.AudioPlayer player = new MyAudioPlaybackAgent.AudioPlayer();

                    player.getTrack(se.set.track.name, se.set.track.performer, se.set.track.release_name, se.set.track.url);
                    BackgroundAudioPlayer.Instance.Play();
                });
            
           
        }
    }
}