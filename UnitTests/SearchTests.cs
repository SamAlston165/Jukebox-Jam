using System;
using System.Collections.Generic;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Search;

namespace UnitTests
{
    /// <summary>
    /// Because DBSearch uses an HTTPClient object, these tests throw
    /// errors when run all at once. They pass when run one at a time. 
    /// And the server must be running for them to pass.
    /// </summary>
    [TestClass]
    public class SearchTests
    {
        [TestMethod]
        public void SearchAllSongsIsSuccessful()
        {
            string trackHost = "http://159.65.235.100";
            int trackPort = 8080;

            //arrange
            DBSearch search = new DBSearch(trackHost, trackPort);

            //act
            var results = search.FindTracks("songs", "");

            //assert
            Assert.IsTrue(results.Count > 0);
        }
        
        [TestMethod]
        public void SearchByArtistIsSuccessful()
        {
            string trackHost = "http://159.65.235.100";
            int trackPort = 8080;

            //arrange
            DBSearch search = new DBSearch(trackHost, trackPort);

            //act
            var results = search.FindTracks("Artist", "David Bowie");

            //assert
            Assert.IsTrue(results.Count > 0);
        }
        
        [TestMethod]
        public void SearchByTitleIsSuccessful()
        {
            string trackHost = "http://159.65.235.100";
            int trackPort = 8080;

            //arrange
            DBSearch search = new DBSearch(trackHost, trackPort);

            //act
            var results = search.FindTracks("Title", "Under Pressure");

            //assert
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void SearchByGenreIsSuccessful()
        {
            string trackHost = "http://159.65.235.100";
            int trackPort = 8080;

            //arrange
            DBSearch search = new DBSearch(trackHost, trackPort);

            //act
            var results = search.FindTracks("Genre", "Classic Rock");

            //assert
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void SearchTermNotOnServerReturnsZeroResults()
        {
            string trackHost = "http://159.65.235.100";
            int trackPort = 8080;

            //arrange
            DBSearch search = new DBSearch(trackHost, trackPort);

            //act
            var results = search.FindTracks("Artist", "asdf");

            //assert
            Assert.IsTrue(results.Count == 0);
        }
    }
}
