using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IActivePlaylist : IPlaylist
    {
        ITrack CurrentTrack { get; }

        bool PreviousTrack();
        bool NextTrack();

        bool SetCurrentTrack(int index);
    }
}
