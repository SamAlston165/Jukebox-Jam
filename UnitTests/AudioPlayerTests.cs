using System;
using Audio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class AudioPlayerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "An invalid URL was loaded.")]
        public void InvalidURLThrowsException()
        {
            //arrange
            string invalidURL = "";
            var sut = new AudioPlayer();

            //act
            sut.LoadTrack(invalidURL);
        }

        [TestMethod]
        public void ValidURLLoads()
        {
            //arrange
            string validURL = "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-1.mp3";
            var sut = new AudioPlayer();

            //act
            sut.LoadTrack(validURL);

            //assert
            //assert that an exception has not been thrown and this line can be reached
            Assert.AreEqual(validURL, validURL);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Play did not throw an exception.")]
        public void PlayThrowsExceptionWithNoTrackLoaded()
        {
            //arrange
            var sut = new AudioPlayer();

            //act
            sut.Play();
        }


        [TestMethod]
        public void PlayWorksWithValidURL()
        {
            //arrange
            string validURL = "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-1.mp3";
            AudioPlayer sut = new AudioPlayer();
            sut.LoadTrack(validURL);

            //act
            sut.Play();

            //assert
            //assert that an exception has not been thrown and this line can be reached
            Assert.AreEqual(validURL, validURL);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Play did not throw an exception.")]
        public void PlayThrowsExceptionIfCalledAfterAudioIsStopped()
        {
            //arrange
            string validURL = "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-1.mp3";
            AudioPlayer sut = new AudioPlayer();
            sut.LoadTrack(validURL);
            sut.Play();
            sut.Stop();

            //act
            sut.Play();
        }
    }
}
