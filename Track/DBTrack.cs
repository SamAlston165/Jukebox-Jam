using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Track
{
    public class DBTrack : ITrack
    {
        //instance variables
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }

        private string host;

        //empty constructor
        public DBTrack()
        {
            this.Artist = "";
            this.Title = "";
            this.Album = "";
            this.Genre = "";
            this.Year = "";
        }

        public void SetHost(string host)
        {
            this.host = host;
        }

        public DBTrack(string artist, string title, string genre)
        {
            this.Artist = artist;
            this.Title = title;
            this.Album = "";
            this.Genre = genre;
            this.Year = "";
        }

        //full constructor
        public DBTrack(string artist, string title, string genre, string year, string album)
        {
            this.Artist = artist;
            this.Title = title;
            this.Album = album;
            this.Genre = genre;
            this.Year = year;

        }

        //method for returning string representation of track
        public override string ToString()
        {
            return this.Artist + " - " + this.Title;
        }

        //method for generating url based on song info
        public string GetPath()
        {
            string formatedArtist = this.Artist.Replace(' ', '-');
            string formatedSong = this.Title.Replace(' ', '-');

            return host + $"/{formatedArtist}/{formatedSong}.mp3";
        }
    }
}
