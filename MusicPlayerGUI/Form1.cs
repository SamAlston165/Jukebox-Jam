using Audio;
using Interfaces;
using Playlist;
using Quobject.SocketIoClientDotNet.Client;
using Search;
using System;
using System.Windows.Forms;
using User;

namespace MusicPlayerGUI
{
    public partial class Form1 : Form
    {
        //chat
        private ILogin login;
        private IUser user;
        private Socket socket;
        public delegate void UpdateTextBoxMethod(string text);

        //playlist
        private IActivePlaylist playlist;
        private IAudioPlayer audioPlayer;

        //current track and album art
        private IImageSearch imageSearch;

        //search
        private ISearch trackSearch;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string trackHost = "http://159.65.235.100";
            int trackPort = 8080;
            
            //chat
            InitializeChat(trackHost, trackPort);
            login = new Login();
            user = new AUser("");
            
            // playlist
            playlist = new ActivePlaylist(new APlaylist());
            audioPlayer = new AudioPlayer();
            
            //album art
            imageSearch = new AlbumArtSearch(trackHost, trackPort);
            
            //search
            trackSearch = new DBSearch(trackHost, trackPort);
            SearchAllTracks();

            artistLabel.Text = "";
            titleLabel.Text = "";
            albumLabel.Text = "";
            genreLabel.Text = "";

            loginSuccessOrFailLabel.Text = "";
        }

        private void SearchAllTracks()
        {
            searchResultsListBox.Items.Clear();
            try
            {
                foreach (ITrack foundTrack in trackSearch.FindTracks("songs", ""))
                {
                    searchResultsListBox.Items.Add(foundTrack);
                }
            } catch(Exception e)
            {
                //if server is not running, return static list of tracks
                trackSearch = new StaticSongList();
                SearchAllTracks();
            }
        }

        /*
         To define the chat functionality we need to gather the text from the current rich texbtox when the send button is clicked and then append it to the upper
         right textbox.
         After this we need to clear the data on the input textbox.
             */
        private void btnSend_Click(object sender, EventArgs e)
        {
            // chatSender.SendMessage(chatTextEntryBox.Text);
            // this.chatFeedBox.Text += Environment.NewLine + "User: " + this.chatTextEntryBox.Text;
            // this.chatTextEntryBox.Text = "";

            string username = String.Empty;
            string message = String.Empty;
            if (user != null)
            {
                username = user.Username;
            }

            message = username + ": " + this.chatTextEntryBox.Text;
            socket.Emit("chat", (message));

            chatTextEntryBox.Text = "";
        }

        private void chatTextEntryBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
            }
        }

        private void updateMessages(string text)
        {
            if (this.chatFeedBox.InvokeRequired)
            {
                UpdateTextBoxMethod del = new UpdateTextBoxMethod(updateMessages);
                this.Invoke(del, new object[] { text });
            }
            else
            {
                this.chatFeedBox.Text += text + Environment.NewLine;
            }
        }

        private void updateStatus()
        {

        }

        private void InitializeChat(string host, int port)
        {
            socket = IO.Socket(host + ":" + port.ToString());//"http://159.65.235.100:8080");
            socket.On(Socket.EVENT_CONNECT, () =>
            {
                Console.WriteLine("client connected");
            });

            socket.On("chat", (data) =>
            {
                Console.WriteLine(data);
                //var messages = new { messages = "" };
                //var messageVal = JsonConvert.DeserializeAnonymousType((string)data, messages);
                updateMessages((string)data);
            });
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            user = login.AuthorizeUser(userNameTextBox.Text, passwordTextBox.Text);
            if (user == null)
            {
                loginSuccessOrFailLabel.Text = "Login failed";
            }
            else
            {
                loginSuccessOrFailLabel.Text = "Logged in as " + user.Username;
            }
            userNameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
        
        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logInButton_Click(sender, e);
            }
        }

        //
        //search functions
        //
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchType = searchTypeDropDown.Text;
            string searchText = songSearchTextBox.Text;
            if (!searchType.Equals("") && !searchText.Equals(""))
            {
                searchResultsListBox.Items.Clear();
                foreach (ITrack foundTrack in trackSearch.FindTracks(searchType, searchText))
                {
                    searchResultsListBox.Items.Add(foundTrack);
                }
            }
        }

        private void songSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton_Click(sender, e);
            }
        }

        private void addToPlaylistButton_Click(object sender, EventArgs e)
        {
            if (searchResultsListBox.SelectedItems != null)
            {
                foreach (object selectedTrack in searchResultsListBox.SelectedItems)
                {
                    playlist.AddTrack((ITrack)selectedTrack);
                }
                UpdatePlaylist();
            }
        }
        
        private void searchResultsListBox_DoubleClick(object sender, EventArgs e)
        {
            addToPlaylistButton_Click(sender, e);
        }

        //
        //playlist functions
        //
        private void UpdatePlaylist()
        {
            playlistBox.Items.Clear();
            for (int i = 0; i < playlist.Count(); i++)
            {
                playlistBox.Items.Add(playlist.GetTrack(i));
            }
        }

        private void UpdateCurrentTrack(ITrack track)
        {
            try
            {
                playlist.SetCurrentTrack(playlist.IndexOf(track));
                audioPlayer.LoadTrack(playlist.CurrentTrack.GetPath());
                audioPlayer.Play();

                artistLabel.Text = playlist.CurrentTrack.Artist;
                titleLabel.Text = playlist.CurrentTrack.Title;
                albumLabel.Text = playlist.CurrentTrack.Album;
                genreLabel.Text = playlist.CurrentTrack.Genre;



                try {
                    string albumArtPath = imageSearch.GetAlbumArtPath(playlist.CurrentTrack.Artist, playlist.CurrentTrack.Album);
                    pictureBox1.ImageLocation = albumArtPath;
                }
                catch (Exception e) { genreLabel.Text += e.Message; }
            }
            catch (Exception ex)
            {
                genreLabel.Text = ex.Message;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            ITrack selectedTrack = (ITrack)playlistBox.SelectedItem;
            if (selectedTrack != null)
            {
                playlist.RemoveTrack(playlist.IndexOf(selectedTrack));
                UpdatePlaylist();
            }
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {

            ITrack selectedTrack = (ITrack)playlistBox.SelectedItem;
            if (selectedTrack != null)
            {
                int currentIndex = playlist.IndexOf(selectedTrack);
                if (currentIndex > 0)
                {
                    int newIndex = currentIndex - 1;

                    //move the track in the playlist
                    playlist.MoveTrack(currentIndex, newIndex);
                    UpdatePlaylist();

                    //and change the selected track in the gui
                    playlistBox.SelectedIndex = newIndex;
                }
            }
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            ITrack selectedTrack = (ITrack)playlistBox.SelectedItem;
            if (selectedTrack != null)
            {
                int currentIndex = playlist.IndexOf(selectedTrack);
                if (currentIndex < playlist.Count() - 1)
                {
                    int newIndex = currentIndex + 1;

                    //move the track in the playlist
                    playlist.MoveTrack(currentIndex, newIndex);
                    UpdatePlaylist();

                    //and change the selected track in the gui
                    playlistBox.SelectedIndex = newIndex;
                }
            }
        }


        //
        //audio functions
        //
        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                audioPlayer.Play();
            }
            catch (Exception ex)
            {
                genreLabel.Text = ex.Message;
            }
        }

        private void playlistBox_DoubleClick(object sender, EventArgs e)
        {
            ITrack selectedTrack = (ITrack)playlistBox.SelectedItem;
            if (selectedTrack != null)
            {
                UpdateCurrentTrack(selectedTrack);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            audioPlayer.Stop();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            audioPlayer.Pause();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            bool trackIsNotLast = playlist.NextTrack();
            if (trackIsNotLast)
            {
                UpdateCurrentTrack(playlist.CurrentTrack);
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
			bool trackIsNotFirst = playlist.PreviousTrack();
            if (trackIsNotFirst)
            {
                UpdateCurrentTrack(playlist.CurrentTrack);
            }
        }
    }
}