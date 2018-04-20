using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Implementations
{
    public class CurrentTrack : ICurrentTrack
    {
        private ITrack track;

        public string Artist { get => track.Artist; }
        public string Title { get => track.Title; }
        public string Album { get => track.Album; }
        public string Genre { get => track.Genre; }
        public string Year { get => track.Year; }
        public string GetPath() { return track.GetPath(); }

        public CurrentTrack()
        {
            this.track = new Track();
        }

        public void SetTrack(ITrack track)
        {
            this.track = track;
        }

        public Image GetAlbumArt()
        {
            throw new NotImplementedException();
        }
    }
}
