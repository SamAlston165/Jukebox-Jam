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
            if (searchType == "songs" && searchText == "")
            {
                return new List<ITrack>
                {
                    //not local but static
                    new StaticTrack(
                        "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-1.mp3"),
                    new StaticTrack(
                        "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-2.mp3"),
                    new StaticTrack(
                        "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-3.mp3")


                /*
                 * my locals - used when i had no internet (greg)
                    new StaticTrack(
                    "C:\\Users\\owner\\Downloads\\Music\\01-kanye_west-gorgeous-41st.mp3"),
                    new StaticTrack(
                    "C:\\Users\\owner\\Downloads\\Music\\02-jadakiss-mornings_was_hashbrowns_freestyle-3am.mp3"),
                    new StaticTrack(
                    "C:\\Users\\owner\\Downloads\\Music\\2pac - changes.mp3")
                    */
                };
            }
            else
            {
                return new List<ITrack>
                {
                    new StaticTrack(searchType),
                    new StaticTrack(searchText),
                    new StaticTrack("https://www.soundhelix.com/examples/mp3/SoundHelix-Song-1.mp3")
                };
            }
        }
    }
}
