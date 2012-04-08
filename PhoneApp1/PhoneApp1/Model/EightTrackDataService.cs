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
        public Uri eighttracksmix = new Uri("http://8tracks.com/mixes.json?api_key=5aca54a2ba7c7a3ef7c5d7410738021bdcf742ec"); 

        public void getEightTrackMixes()
        {
            WebClient web = new WebClient();
            web.DownloadStringCompleted += new DownloadStringCompletedEventHandler(getEightTrackMixes_Completed);
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

        }
    }
}
