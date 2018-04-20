using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    public class ActivePlaylist : IActivePlaylist
    {
        public ITrack CurrentTrack { get; private set; }
        private IPlaylist playlist;

        public ActivePlaylist(IPlaylist playlist)
        {
            this.playlist = playlist;

            //set the current track to the first track in the playlist
            //if the playlist is empty, make the current track a new track
            bool currentTrackIsSet = SetCurrentTrack(0);
            if(!currentTrackIsSet)
            {
                this.CurrentTrack = new Track();
            }
        }

        public bool NextTrack()
        {
            int currentTrackIndex = this.playlist.IndexOf(this.CurrentTrack);
            int lastTrackIndex = this.playlist.Count() - 1;
            if (currentTrackIndex > -1 && currentTrackIndex < lastTrackIndex)
            {
                ITrack nextTrack = this.playlist.GetTrack(currentTrackIndex + 1);
                this.CurrentTrack = nextTrack;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PreviousTrack()
        {
            int currentTrackIndex = this.playlist.IndexOf(this.CurrentTrack);
            if (currentTrackIndex > 0)
            {
                ITrack prevTrack = playlist.GetTrack(currentTrackIndex - 1);
                this.CurrentTrack = prevTrack;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SetCurrentTrack(int index)
        {
            ITrack newCurrentTrack = this.playlist.GetTrack(index);
            if (newCurrentTrack != null)
            {
                this.CurrentTrack = newCurrentTrack;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddTrack(ITrack newTrack)
        {
            playlist.AddTrack(newTrack);
        }

        public bool RemoveTrack(int index)
        {
            return playlist.RemoveTrack(index);
        }

        public bool MoveTrack(int currentIndex, int newIndex)
        {
            return playlist.MoveTrack(currentIndex, newIndex);
        }

        public int IndexOf(ITrack track)
        {
            return playlist.IndexOf(track);
        }

        public ITrack GetTrack(int index)
        {
            return playlist.GetTrack(index);
        }

        public int Count()
        {
            return playlist.Count();
        }
    }
}
