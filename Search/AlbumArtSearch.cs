using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class AlbumArtSearch : IImageSearch
    {
        private string host;

        public AlbumArtSearch(string host, int port)
        {
            this.host = $"{host}:{port.ToString()}";
        }

        public string GetAlbumArtPath(string artist, string album)
        {
            //query this string to our server
            /*String queryURL = $"http://159.65.235.100/covers/{currentTrack.artist}/{currentTrack.album}";*/

            //make http request to queryURL

            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(host + "/covers/" + artist + "/" + album);
                //"http://159.65.235.100:6024/covers/{currentTrack.artist}/{currentTrack.album}");
            //HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://159.65.235.100:6024/covers/asia/asia");

            //response from queryURL is a string which is the imageURL
            HttpWebResponse HttpWResp = (HttpWebResponse)myReq.GetResponse();

            // Insert code that uses the response object.
            WebHeaderCollection header = HttpWResp.Headers;
            string responseText = string.Empty;
            var encoding = ASCIIEncoding.ASCII;
            using (var reader = new System.IO.StreamReader(HttpWResp.GetResponseStream(), encoding))
            {
                responseText = reader.ReadToEnd();
            }

            //Console.WriteLine(responseText);

            //update picture box based on new url
            //pictureBox1.ImageLocation = responseText;
            return responseText;
        }
    }
}
