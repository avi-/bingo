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
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;
using PhoneApp1.DataServices;

namespace PhoneApp1.Model
{
    public class EightTrackDataService
    {
        string playtoken; string songID;
        public EightTracksMixes objEightTracksMixes;
        public EightTrackPlayToken objEightTrackPlayToken;
        public EightTrackPlaySong objEightTrackPlaySong;
        public Uri eighttracksmix = new Uri("http://8tracks.com/mixes.json?api_key=5aca54a2ba7c7a3ef7c5d7410738021bdcf742ec");
        public Uri eightrackplaytoken = new Uri("http://8tracks.com/sets/new.json?api_key=5aca54a2ba7c7a3ef7c5d7410738021bdcf742ec");

        Action<EightTracksMixes, Exception> GetTracksCallback;        
       
        Action<EightTrackPlayToken, Exception> GetTokenCallback;
       
        Action<EightTrackPlaySong, Exception> PlaySongCallback;
        
        public EightTrackDataService()
        {
          objEightTracksMixes = new EightTracksMixes ();
          objEightTrackPlayToken = new EightTrackPlayToken ();
          objEightTrackPlaySong = new EightTrackPlaySong ();
        }

        

        public void getEightTrackMixes(Action<EightTracksMixes, Exception> callback)
        {
            WebClient web = new WebClient();
            web.DownloadStringCompleted += new DownloadStringCompletedEventHandler(getEightTrackMixes_Completed);
            web.DownloadStringAsync(eighttracksmix);
            GetTracksCallback = callback;
        }

        void getEightTrackMixes_Completed(object sender, DownloadStringCompletedEventArgs e)
        {
            byte[] encodedString = Encoding.UTF8.GetBytes(e.Result);

            //// Put the byte array into a stream and rewind it to the beginning
            MemoryStream ms = new MemoryStream(encodedString);
            ms.Flush();
            ms.Position = 0;

            // convert json result to model
            Stream stream = ms;
            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(EightTracksMixes));
            EightTracksMixes myResults =
            (EightTracksMixes)dataContractJsonSerializer.ReadObject(stream);

            var result = myResults;
            objEightTracksMixes = result;
            GetTracksCallback(result, null);

        }

        public void getEightTrackPlayToken(Action<EightTrackPlayToken, Exception> callback)
        {
            WebClient web = new WebClient();
            web.DownloadStringCompleted += new DownloadStringCompletedEventHandler(getEightTrackPlayToken_Completed);
            web.DownloadStringAsync(eightrackplaytoken);
            GetTokenCallback = callback;
        }

        void getEightTrackPlayToken_Completed(object sender, DownloadStringCompletedEventArgs e)
        {
            byte[] encodedString = Encoding.UTF8.GetBytes(e.Result);

            //// Put the byte array into a stream and rewind it to the beginning
            MemoryStream ms = new MemoryStream(encodedString);
            ms.Flush();
            ms.Position = 0;

            // convert json result to model
            Stream stream = ms;
            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(EightTrackPlayToken));
            EightTrackPlayToken myResults =
            (EightTrackPlayToken)dataContractJsonSerializer.ReadObject(stream);

            var result = myResults;
            objEightTrackPlayToken = result;
            GetTokenCallback(result, null);

        }

        public void setTokenId(string token, string ID)
        {
             playtoken = token;
             songID = ID;
        }

        public void playEightTrackSong(Action<EightTrackPlaySong, Exception>Callback)
        {
            string uri = "http://8tracks.com/sets/" + playtoken + "/play.json?api_key=5aca54a2ba7c7a3ef7c5d7410738021bdcf742ec&mix_id=" + songID;
            Uri playuri = new Uri(uri);
            WebClient web = new WebClient();
            web.DownloadStringCompleted += new DownloadStringCompletedEventHandler(playEightTrackSong_Completed);
            web.DownloadStringAsync(playuri);
            PlaySongCallback = Callback; 
        }

        void playEightTrackSong_Completed(object sender, DownloadStringCompletedEventArgs e)
        {
            byte[] encodedString = Encoding.UTF8.GetBytes(e.Result);

            //// Put the byte array into a stream and rewind it to the beginning
            MemoryStream ms = new MemoryStream(encodedString);
            ms.Flush();
            ms.Position = 0;

            // convert json result to model
            Stream stream = ms;
            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(EightTrackPlaySong));
            EightTrackPlaySong myResults =
            (EightTrackPlaySong)dataContractJsonSerializer.ReadObject(stream);

            var result = myResults;
            objEightTrackPlaySong = result;
            PlaySongCallback(result, null);

        }
    }
}
