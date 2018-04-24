using Audio;
using Interfaces;
using Playlist;
using Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Track;
using User;

namespace TestGUI
{
    public partial class TestGUIForm : Form
    {
        private ILogin login;

        private IUser user;
        private IChatSender chatSender;
        private IChatReceiver chatReceiver;

        private IActivePlaylist activePlaylist;
        private IAudioPlayer audioPlayer;
        private ICurrentTrack currentTrack;

        private IImageSearch imageSearch;

        private IPlaylistSearch playlistSearch;

        private ISearch trackSearch;

        public TestGUIForm()
        {
            InitializeComponent();

            string trackHost = "http://159.65.235.100";
            int trackPort = 6024;

            login = new Login();

            //user = login.AuthorizeUser("username", "password");
            user = new AUser("");
            //chatSender = new ChatSender(user);
            //chatReceiver = new ChatReceiver();

            activePlaylist = new ActivePlaylist(new APlaylist());
            audioPlayer = new DBAudioPlayer(new AudioPlayer(), trackHost, trackPort);
            currentTrack = new CurrentTrack();

            //imageSearch = new ImageSearch();
            //playlistSearch = new PlaylistSearch();
            trackSearch = new DBSearch(trackHost, trackPort);

            ShowAllSongs();
        }

        private void ShowAllSongs()
        {
            searchResultsListBox.Items.Clear();
            foreach (ITrack foundTrack in trackSearch.FindTracks("songs", ""))
            {
                searchResultsListBox.Items.Add(foundTrack);
            }
        }



        private void UpdatePlaylist()
        {
            playlistListBox.Items.Clear();
            for (int i = 0; i < activePlaylist.Count(); i++)
            {
                playlistListBox.Items.Add(activePlaylist.GetTrack(i));
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchType = searchTypeComboBox.Text;
            string searchText = searchTextBox.Text;
            if (!searchType.Equals("") && !searchText.Equals(""))
            {
                searchResultsListBox.Items.Clear();
                foreach (ITrack foundTrack in trackSearch.FindTracks(searchType, searchText))
                //foreach (ITrack foundTrack in trackSearch.FindTracks("songs", ""))
                {
                    searchResultsListBox.Items.Add(foundTrack);
                }
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (searchResultsListBox.SelectedItems != null)
            {
                foreach (object selectedTrack in searchResultsListBox.SelectedItems)
                {
                    activePlaylist.AddTrack((ITrack)selectedTrack);
                }
                UpdatePlaylist();
            }
        }

        private void playlistListBox_DoubleClick(object sender, EventArgs e)
        {
            ITrack selectedTrack = (ITrack)playlistListBox.SelectedItem;
            if (selectedTrack != null)
            {
                UpdateCurrentTrack(selectedTrack);
            }
        }

        private void UpdateCurrentTrack(ITrack track)
        {
            currentTrack.SetTrack(track);
            audioPlayer.LoadTrack(currentTrack.GetPath());
            audioPlayer.Play();
            string currentTrackDetails = "Artist: " + currentTrack.Artist + Environment.NewLine
                + "Title: " + currentTrack.Title + Environment.NewLine
                + "Album: " + currentTrack.Album + Environment.NewLine
                + "Genre: " + currentTrack.Genre + Environment.NewLine
                + "Year: " + currentTrack.Year + Environment.NewLine;

            currentTrackTextBox.Text = currentTrackDetails;
        }
    }
}
