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
using PhoneApp1.Model;

namespace PhoneApp1.Presenter
{

    public delegate void GetTracksEventHandler(object sender, EventArgs e);
    public delegate void GetTokenEventHandler(object sender, EventArgs e);
    public delegate void PlaySongEventHandler(object sender, EventArgs e);
   


    public class EightTrackDataHandler
    {
        EightTrackDataService _dataservice;
        public event PlaySongEventHandler DataHandler_PlaySongCompleted;
        public event GetTracksEventHandler DataHandler_GetTracksCompleted;
        public event GetTokenEventHandler DataHandler_GetTokenCompleted;

        public EightTrackDataHandler()
        {
            _dataservice = new EightTrackDataService();
        }

        public void SetTokenId()
        {
            
            _dataservice.setTokenId(_dataservice.objEightTrackPlayToken.play_token, _dataservice.objEightTracksMixes.mixes[0].id.ToString());
        }

        public void DataHandler_GetTracks()
        {

            _dataservice.getEightTrackMixes(
                (item, error) =>
                {
                    Exception response;

                    if (error != null)
                    {
                        response = new Exception("Failed");
                    }
                    else
                    {
                        response = new Exception("Success");
                    }


                    if (DataHandler_GetTracksCompleted != null)
                    {
                        EventArgs e = null;
                        DataHandler_GetTracksCompleted(response, e);
                    }

                });
        }

        public void DataHandler_GetToken()
        {

            _dataservice.getEightTrackPlayToken(
                (item, error) =>
                {
                    Exception response;

                    if (error != null)
                    {
                        response = new Exception("Failed");
                    }
                    else
                    {
                        response = new Exception("Success");
                    }


                    if (DataHandler_GetTokenCompleted != null)
                    {
                        EventArgs e = null;
                        DataHandler_GetTokenCompleted(response, e);
                    }

                });
        }

        public void DataHandler_PlayTrack()
        {

            _dataservice.playEightTrackSong(
                (item, error) =>
                {
                    Exception response;

                    if (error != null)
                    {
                        response = new Exception("Failed");
                    }
                    else
                    {
                        response = new Exception("Success");
                    }


                    if (DataHandler_PlaySongCompleted != null)
                    {
                        EventArgs e = null;
                        DataHandler_PlaySongCompleted(response, e);
                    }

                });
        }
  
    }
}
