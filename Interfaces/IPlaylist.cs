using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPlaylist
    {
        void AddTrack(ITrack newTrack);
        bool RemoveTrack(int index);
        bool MoveTrack(int currentIndex, int newIndex);

        int IndexOf(ITrack track);
        ITrack GetTrack(int index);
        int Count();
    }
}
