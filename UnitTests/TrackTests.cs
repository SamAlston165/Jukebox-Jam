using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Track;

namespace UnitTests
{
    [TestClass]
    public class TrackTests
    {
        [TestMethod]
        public void CanGetandSetTrackArtist()
        {
            //act
            //Testing that track properties can manipulated
            const string artist = "Bill Withers";

            //arrange
            //Properties of the track can be set dynamically 

            var track = new DBTrack()
            {
                Artist = artist
            };

            //assert
            //Check if property matches the dynamic setter

            Assert.AreEqual(artist, track.Artist);
        }

        [TestMethod]
        public void CanGetandSetTrackAlbum()
        {
            //act
            //Testing that track properties can manipulated

            const string album = "some album";

            //arrange
            //Properties of the track can be set dynamically 

            var track = new DBTrack()
            {
                Album = album
            };

            //assert
            //Check if property matches the dynamic setter

            Assert.AreEqual(album, track.Album);
        }

        [TestMethod]
        public void CanGetandSetTrackYear()
        {
            //act
            //Testing that track properties can manipulated

            const string year = "3030";

            //arrange
            //Properties of the track can be set dynamically 

            var track = new DBTrack()
            {
                Year = year
            };

            //assert
            //Check if property matches the dynamic setter

            Assert.AreEqual(year, track.Year);
        }

        [TestMethod]
        public void CanGetandSetTrackGenre()
        {
            //act
            //Testing that track properties can manipulated

            const string genre = "Soul";

            //arrange
            //Properties of the track can be set dynamically 

            var track = new DBTrack()
            {
                Genre = genre
            };

            //assert
            //Check if property matches the dynamic setter

            Assert.AreEqual(genre, track.Genre);
        }

        [TestMethod]
        public void CanGetandSetTrackTitle()
        {
            //act
            //Testing that track properties can manipulated

            const string title = "A good song";

            //arrange
            //Properties of the track can be set dynamically 

            var track = new DBTrack()
            {
                Title = title
            };

            //assert
            //Check if property matches the dynamic setter

            Assert.AreEqual(title, track.Title);
        }

        [TestMethod]
        public void ToStringReturnsArtistAndTitle()
        {
            //arrange
            const string artist = "A good artist";
            const string title = "A good song";
            string expected = artist + " - " + title;
            var track = new DBTrack()
            {
                Artist = artist,
                Title = title
            };

            //act
            string trackString = track.ToString();

            //assert
            Assert.AreEqual(expected, trackString);
        }

        [TestMethod]
        public void TrackReturnsCorrectPath()
        {
            //arrange
            const string artist = "A good artist";
            const string title = "A good song";
            string expected = "/A-good-artist/A-good-song.mp3";
            var track = new DBTrack()
            {
                Artist = artist,
                Title = title
            };

            //act
            string pathString = track.GetPath();

            //assert
            Assert.AreEqual(expected, pathString);
        }
    }
}
