using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Interfaces
{
    public interface ICurrentTrack : ITrack
    {
        void SetTrack(ITrack track);

        Image GetAlbumArt();
    }
}
