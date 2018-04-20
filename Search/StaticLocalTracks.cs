using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Track;

namespace Search
{
    public class StaticLocalTracks : ISearch
    {
        public List<ITrack> FindTracks(string searchType, string searchText)
        {
            return new List<ITrack>
            {
                new StaticTrack(
                "C:\\Users\\owner\\Downloads\\Music\\01-kanye_west-gorgeous-41st.mp3"),
                new StaticTrack(
                "C:\\Users\\owner\\Downloads\\Music\\02-jadakiss-mornings_was_hashbrowns_freestyle-3am.mp3"),
                new StaticTrack(
                "C:\\Users\\owner\\Downloads\\Music\\2pac - changes.mp3")
            };
        }
    }
}
