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
using PhoneApp1.Presenter;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        App app = Application.Current as App;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            app.obj.DataHandler_GetTokenCompleted +=new GetTokenEventHandler(obj_DataHandler_GetTokenCompleted); 
            app.obj.DataHandler_GetTracksCompleted +=new GetTracksEventHandler(obj_DataHandler_GetTracksCompleted); 
            app.obj.DataHandler_PlaySongCompleted +=new PlaySongEventHandler(obj_DataHandler_PlaySongCompleted); 
            app.obj.DataHandler_GetToken();
        }

        public void obj_DataHandler_GetTokenCompleted(object sender, EventArgs e)
        {
            app.obj.DataHandler_GetTracks();
        }

        public void obj_DataHandler_GetTracksCompleted(object sender, EventArgs e)
        {
            app.obj.SetTokenId();
            app.obj.DataHandler_PlayTrack();
        }

        public void obj_DataHandler_PlaySongCompleted(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/PlaybackPage.xaml?" , UriKind.Relative));
            
        }
    }
}