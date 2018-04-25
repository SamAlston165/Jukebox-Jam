using System;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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
            var track = new Mock<ITrack>();

            APlaylist sut = new APlaylist();

            //act
            sut.AddTrack(track.Object);
            int result = sut.IndexOf(track.Object);

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PreviousTrackIsSuccessfulAndReturnsTrue()
        {
            //set up a playlist with two tracks, set the second to current,
            //and test that previousTrack() sets first to current
            string expectedResult = "David Bowie - Under Pressure";

            //arrange
            var track1 = new Mock<ITrack>();
            var track2 = new Mock<ITrack>();
            track1.Setup(r => r.ToString()).Returns(expectedResult);

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1.Object);
            sut.AddTrack(track2.Object);
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

            string expectedResult = "David Bowie - Under Pressure";

            //arrange
            var track1 = new Mock<ITrack>();
            var track2 = new Mock<ITrack>();
            track1.Setup(r => r.ToString()).Returns(expectedResult);

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1.Object);
            sut.AddTrack(track2.Object);
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
            
            string expectedResult = "David Bowie - Under Pressure";

            //arrange
            var track1 = new Mock<ITrack>();
            var track2 = new Mock<ITrack>();
            track2.Setup(r => r.ToString()).Returns(expectedResult);

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1.Object);
            sut.AddTrack(track2.Object);
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

            string expectedResult = "David Bowie - Under Pressure";

            //arrange
            var track1 = new Mock<ITrack>();
            var track2 = new Mock<ITrack>();
            track2.Setup(r => r.ToString()).Returns(expectedResult);

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1.Object);
            sut.AddTrack(track2.Object);
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

            string expectedResult = "David Bowie - Under Pressure";

            //arrange
            var track1 = new Mock<ITrack>();
            track1.Setup(r => r.ToString()).Returns(expectedResult);

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1.Object);
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
            var track1 = new Mock<ITrack>();

            APlaylist sut = new APlaylist();
            sut.AddTrack(track1.Object);

            //act
            sut.RemoveTrack(0);
            int result = sut.IndexOf(track1.Object);

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
            var track1 = new Mock<ITrack>();
            var track2 = new Mock<ITrack>();

            APlaylist sut = new APlaylist();
            sut.AddTrack(track1.Object);
            sut.AddTrack(track2.Object);

            //act
            sut.MoveTrack(0, 1);
            int result = sut.IndexOf(track1.Object);

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
            var track1 = new Mock<ITrack>();
            var track2 = new Mock<ITrack>();

            APlaylist sut = new APlaylist();
            sut.AddTrack(track1.Object);
            sut.AddTrack(track2.Object);

            //act
            sut.MoveTrack(5, 0);
            int result = sut.IndexOf(track1.Object);

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
            var track1 = new Mock<ITrack>();
            var track2 = new Mock<ITrack>();

            APlaylist sut = new APlaylist();
            sut.AddTrack(track1.Object);
            sut.AddTrack(track2.Object);

            //act
            sut.MoveTrack(0, 5);
            int result = sut.IndexOf(track1.Object);

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void SetCurrentTrackIsSuccessful()
        {
            string expectedResult = "David Bowie - Under Pressure";
            
            //arrange
            var track1 = new Mock<ITrack>();
            track1.Setup(r => r.ToString()).Returns(expectedResult);

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1.Object);

            //act
            sut.SetCurrentTrack(0);
            string result = sut.CurrentTrack.ToString();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void SetCurrentTrackDoesNothingWhenIndexIsOutOfRange()
        {
            string expectedResult = "David Bowie - Under Pressure";

            //arrange
            var track1 = new Mock<ITrack>();
            track1.Setup(r => r.ToString()).Returns(expectedResult);

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1.Object);
            sut.SetCurrentTrack(0);

            //act
            sut.SetCurrentTrack(5);
            string result = sut.CurrentTrack.ToString();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CurrentTrackPathIsSuccessfulWhenTrackIsNotNull()
        {
            string expectedResult = "http://apathToaSong.mp3";

            //arrange
            var track1 = new Mock<ITrack>();
            track1.Setup(r => r.GetPath()).Returns(expectedResult);

            ActivePlaylist sut = new ActivePlaylist(new APlaylist());
            sut.AddTrack(track1.Object);
            sut.SetCurrentTrack(0);

            //act
            string result = sut.CurrentTrack.GetPath();

            //assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
