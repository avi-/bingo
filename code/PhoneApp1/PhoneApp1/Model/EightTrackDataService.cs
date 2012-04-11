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
        Action<EightTracksMixes, Exception> GetEightTrackMixesCallback;
        Action<EightTrackPlayToken, Exception> GetEightTrackPlayTokenCallback;
        Action<EightTrackPlaySong, Exception> PlayEightTrackPlaySongCallback;

        public Uri eighttracksmix = new Uri("http://8tracks.com/mixes.json?api_key=5aca54a2ba7c7a3ef7c5d7410738021bdcf742ec");
        public Uri eightrackplaytoken = new Uri("http://8tracks.com/sets/new.json?api_key=5aca54a2ba7c7a3ef7c5d7410738021bdcf742ec");

        public void getEightTrackMixes(Action<EightTracksMixes,Exception>callback)
        {
            WebClient web = new WebClient();
            web.DownloadStringCompleted += new DownloadStringCompletedEventHandler(getEightTrackMixes_Completed);

            GetEightTrackMixesCallback = callback;
            web.DownloadStringAsync(eighttracksmix);
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
            GetEightTrackMixesCallback(myResults, null);

        }

        public void getEightTrackPlayToken(Action<EightTrackPlayToken,Exception>callback)
        {
            WebClient web = new WebClient();
            web.DownloadStringCompleted += new DownloadStringCompletedEventHandler(getEightTrackPlayToken_Completed);
            GetEightTrackPlayTokenCallback = callback;
            web.DownloadStringAsync(eightrackplaytoken);

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
            GetEightTrackPlayTokenCallback(myResults, null);

        }

        public void playEightTrackSong(string playtoken, string songID,Action<EightTrackPlaySong,Exception>callback)
        {
            string uri = "http://8tracks.com/sets/" + playtoken + "/play.json?api_key=5aca54a2ba7c7a3ef7c5d7410738021bdcf742ec&mix_id=" + songID;
            Uri playuri = new Uri(uri);
            WebClient web = new WebClient();
            web.DownloadStringCompleted += new DownloadStringCompletedEventHandler(playEightTrackSong_Completed);

            PlayEightTrackPlaySongCallback = callback;
            web.DownloadStringAsync(playuri);
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
            PlayEightTrackPlaySongCallback(myResults, null);
        }
    }
}
