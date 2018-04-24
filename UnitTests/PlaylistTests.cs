using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playlist;
using Track;

namespace UnitTests
{
    [TestClass]
    public class PlaylistTests
    {
        [TestMethod]
        public void AddTrackIsSuccessful()
        {
            //when a track is added, it should end up at the end of the track list
            //we are testing with an empty playlist, so we expect the track to be at
            //index 0
            int expectedResult = 0;

            //arrange
            DBTrack track = new DBTrack();
            track.Title = "test track";

            APlaylist sut = new APlaylist();

            //act
            sut.AddTrack(track);
            int result = sut.IndexOf(track);

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PreviousTrackIsSuccessfulAndReturnsTrue()
        {
            //set up a playlist with two tracks, set the second to current,
            //and test that previousTrack() sets first to current

            //arrange
            DBTrack track1 = new DBTrack();
            track1.Title = "test track1";
            string expectedResult = track1.ToString();
            DBTrack track2 = new DBTrack();
            track2.Title = "test track2";

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1);
            sut.AddTrack(track2);
            sut.SetCurrentTrack(1);

            //act
            bool trackWasChanged = sut.PreviousTrack();
            string result = sut.CurrentTrack.ToString();

            //assert
            Assert.AreEqual(true, trackWasChanged);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PreviousTrackDoesNothingWhenFirstTrackIsCurrentAndReturnsFalse()
        {
            //set up a playlist with two tracks, set the first to current,
            //and test that previousTrack() does not change current if there
            //are no previous tracks

            //arrange
            DBTrack track1 = new DBTrack();
            track1.Title = "test track1";
            string expectedResult = track1.ToString();
            DBTrack track2 = new DBTrack();
            track2.Title = "test track2";

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1);
            sut.AddTrack(track2);
            sut.SetCurrentTrack(0);

            //act
            bool trackWasChanged = sut.PreviousTrack();
            string result = sut.CurrentTrack.ToString();

            //assert
            Assert.AreEqual(false, trackWasChanged);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void NextTrackIsSuccessfulAndReturnsTrue()
        {
            //set up a playlist with two tracks, set the first to current,
            //and test that nextTrack() sets second to current

            //arrange
            DBTrack track1 = new DBTrack();
            track1.Title = "test track1";
            DBTrack track2 = new DBTrack();
            track2.Title = "test track2";
            string expectedResult = track2.ToString();

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1);
            sut.AddTrack(track2);
            sut.SetCurrentTrack(0);

            //act
            bool trackWasChanged = sut.NextTrack();
            string result = sut.CurrentTrack.ToString();

            //assert
            Assert.AreEqual(true, trackWasChanged);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void NextTrackDoesNothingWhenLastTrackIsCurrentAndReturnsFalse()
        {
            //set up a playlist with two tracks, set the second to current,
            //and test that nextTrack() does not change current if there
            //are no next tracks

            //arrange
            DBTrack track1 = new DBTrack();
            track1.Title = "test track1";
            DBTrack track2 = new DBTrack();
            track2.Title = "test track2";
            string expectedResult = track2.ToString();

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1);
            sut.AddTrack(track2);
            sut.SetCurrentTrack(1);

            //act
            bool trackWasChanged = sut.NextTrack();
            string result = sut.CurrentTrack.ToString();

            //assert
            Assert.AreEqual(false, trackWasChanged);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CurrentTrackToStringIsSuccessfulWhenTrackIsNotNull()
        {
            //arrange
            DBTrack track1 = new DBTrack();
            track1.Title = "test track1";
            string expectedResult = track1.ToString();

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1);
            sut.SetCurrentTrack(0);

            //act
            string result = sut.CurrentTrack.ToString();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CurrentTrackToStringReturnsEmptyStringWhenTrackIsNull()
        {
            string expectedResult = "";

            //arrange
            DBTrack track1 = null;

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1);
            sut.SetCurrentTrack(0);

            //act
            string result = sut.CurrentTrack.ToString();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void RemoveTrackIsSuccessful()
        {
            //we will remove the track and expect IndexOf to return -1
            int expectedResult = -1;

            //arrange
            DBTrack track1 = new DBTrack();
            track1.Title = "test track1";

            APlaylist sut = new APlaylist();
            sut.AddTrack(track1);

            //act
            sut.RemoveTrack(0);
            int result = sut.IndexOf(track1);

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void MoveTrackIsSuccessful()
        {
            //set up a playlist with two tracks, move the first to the second
            //position and check that it is there

            int expectedResult = 1;

            //arrange
            DBTrack track1 = new DBTrack();
            track1.Title = "test track1";
            DBTrack track2 = new DBTrack();
            track2.Title = "test track2";

            APlaylist sut = new APlaylist();
            sut.AddTrack(track1);
            sut.AddTrack(track2);

            //act
            sut.MoveTrack(0, 1);
            int result = sut.IndexOf(track1);

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void MoveTrackDoesNothingWhenCurrentIndexIsOutOfRange()
        {
            //set up a playlist with two tracks, try to move a track
            //from an invalid index to the first position, and test
            //that the first track is unchanged

            int expectedResult = 0;

            //arrange
            DBTrack track1 = new DBTrack();
            track1.Title = "test track1";
            DBTrack track2 = new DBTrack();
            track2.Title = "test track2";

            APlaylist sut = new APlaylist();
            sut.AddTrack(track1);
            sut.AddTrack(track2);

            //act
            sut.MoveTrack(5, 0);
            int result = sut.IndexOf(track1);

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void MoveTrackDoesNothingWhenNewIndexIsOutOfRange()
        {
            //set up a playlist with two tracks, try to move a track
            //from the first position to an invalid index, and test
            //that the first track is unchanged

            int expectedResult = 0;

            //arrange
            DBTrack track1 = new DBTrack();
            track1.Title = "test track1";
            DBTrack track2 = new DBTrack();
            track2.Title = "test track2";

            APlaylist sut = new APlaylist();
            sut.AddTrack(track1);
            sut.AddTrack(track2);

            //act
            sut.MoveTrack(0, 5);
            int result = sut.IndexOf(track1);

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void SetCurrentTrackIsSuccessful()
        {
            //arrange
            DBTrack track1 = new DBTrack();
            track1.Title = "test track1";
            string expectedResult = track1.ToString();

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1);

            //act
            sut.SetCurrentTrack(0);
            string result = sut.CurrentTrack.ToString();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void SetCurrentTrackDoesNothingWhenIndexIsOutOfRange()
        {
            //arrange
            DBTrack track1 = new DBTrack();
            track1.Title = "test track1";
            string expectedResult = track1.ToString();

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1);
            sut.SetCurrentTrack(0);

            //act
            sut.SetCurrentTrack(5);
            string result = sut.CurrentTrack.ToString();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CurrentTrackURLIsSuccessfulWhenTrackIsNotNull()
        {
            //arrange
            DBTrack track1 = new DBTrack();
            track1.Title = "test track1";
            string expectedResult = track1.GetPath();

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1);
            sut.SetCurrentTrack(0);

            //act
            string result = sut.CurrentTrack.GetPath();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CurrentTrackURLReturnsEmptyStringWhenTrackIsNull()
        {
            string expectedResult = "";

            //arrange
            DBTrack track1 = null;

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1);
            sut.SetCurrentTrack(0);

            //act
            string result = sut.CurrentTrack.GetPath();

            //assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
