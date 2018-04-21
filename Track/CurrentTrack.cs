using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Track
{
    public class CurrentTrack : ICurrentTrack
    {
        private ITrack track;

        /*
        public string Artist { get => track.Artist; }
        public string Title { get => track.Title; }
        public string Album { get => track.Album; }
        public string Genre { get => track.Genre; }
        public string Year { get => track.Year; }
        public string GetPath() { return track.GetPath(); }
        */

        public string Artist { get; set; }
        public string Title { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }
        public string GetPath() { return track.GetPath(); }

        public CurrentTrack()
        {
            this.track = new DBTrack();
        }

        public void SetTrack(ITrack track)
        {
            this.track = track;

            this.Artist = track.Artist;
            this.Title = track.Title;
            this.Album = track.Album;
            this.Genre = track.Genre;
            this.Year = track.Year;
        }

        public Image GetAlbumArt()
        {
            throw new NotImplementedException();
        }
    }
}
