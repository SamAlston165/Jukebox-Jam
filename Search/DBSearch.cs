using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Track;

namespace Search
{
    public class DBSearch : ISearch
    {
        static HttpClient client = new HttpClient();
        private static string host;

        public DBSearch(string hostAddr, int port)
        {
            host = $"{hostAddr}:{port.ToString()}";
            client.BaseAddress = new Uri("http://localhost:64195");
        }

        public List<ITrack> FindTracks(string route, string term)
        {
            List<DBTrack> result;

            result = RunAsync(route, term).GetAwaiter().GetResult();

            //foreach (Track t in result) { Console.WriteLine(t.ToString()); }

            //convert from list<Track> to list<ITrack>
            List<ITrack> theResults = new List<ITrack>();
            foreach(DBTrack t in result)
            {
                theResults.Add(t);
            }
            return theResults;
        }

        static async Task<List<DBTrack>> RunAsync(string route, string term)
        {
            List<DBTrack> restSong = null;

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                restSong = await GetSongAsync($"{host}/{route}/{term}").ConfigureAwait(false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return restSong;
        }

        static async Task<List<DBTrack>> GetSongAsync(string path)
        {
            List<DBTrack> song = null;
            HttpResponseMessage response = await client.GetAsync(path).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                song = await response.Content.ReadAsAsync<List<DBTrack>>().ConfigureAwait(false);
            }

            return song;
        }
    }
}
