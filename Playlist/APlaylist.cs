using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    public class APlaylist : IPlaylist
    {
        public string Title { get; private set; }
        private List<ITrack> trackList;

        //Empty Constructor
        public APlaylist()
        {
            this.Title = "";
            this.trackList = new List<ITrack>();
        }

        //method for adding song to the playlist
        public void AddTrack(ITrack newTrack)
        {
            this.trackList.Add(newTrack);
        }

        //method for removing song at specified index
        public bool RemoveTrack(int index)
        {
            if (IsAValidTrackListIndex(index))
            {
                this.trackList.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        //method for move songs up and down the playlist
        public bool MoveTrack(int currentIndex, int newIndex)
        {
            if(IsAValidTrackListIndex(currentIndex) 
                && IsAValidTrackListIndex(newIndex))
            {
                ITrack trackToMove = this.trackList.ElementAt(currentIndex);
                RemoveTrack(currentIndex);
                this.trackList.Insert(newIndex, trackToMove);
                return true;
            }
            else
            {
                return false;
            }
        }
        //REWRITE SO AS NOT TO VIOLATE ABSTRACTION
        public ITrack GetTrack(int index)
        {
            if(IsAValidTrackListIndex(index))
            {
                return this.trackList.ElementAt(index);
            }
            else
            {
                return null;
            }
        }

        public int IndexOf(ITrack track)
        {
            return trackList.IndexOf(track);
        }

        public int Count()
        {
            return trackList.Count();
        }

        private bool IsAValidTrackListIndex(int index)
        {
            return index > -1 && index < this.trackList.Count;
        }
    }
}
