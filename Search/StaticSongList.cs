using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Track;

namespace Search
{
    public class StaticSongList : ISearch
    {
        public List<ITrack> FindTracks(string searchType, string searchText)
        {
            return new List<ITrack>
            {
                new StaticTrack(
                    "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-1.mp3"),
                new StaticTrack(
                    "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-2.mp3"),
                new StaticTrack(
                    "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-3.mp3")
            };
        }
    }
}
