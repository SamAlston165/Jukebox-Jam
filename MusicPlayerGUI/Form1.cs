using Audio;
using Interfaces;
using Newtonsoft.Json;
using Playlist;
using Quobject.SocketIoClientDotNet.Client;
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
using System.Net;
using System.Threading;

namespace MusicPlayerGUI
{
    public partial class Form1 : Form
    {
        //User Login
        private ILogin login;
        private IUser user;

        //Chat Functionality
        private Socket socket;
        private delegate void UpdateTextBoxMethod(string text);

        //playlist
        private IActivePlaylist playlist;
        private IAudioPlayer audioPlayer;

        //current track and album art
        //private ICurrentTrack currentTrack;
        private IImageSearch imageSearch;

        //search
        private ISearch trackSearch;

        //Connection to server and port
        private const string serverHost = "http://159.65.235.100";
        private const int serverPort = 8080;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            //chat
            //
            InitializeChat(serverHost, serverPort);
            login = new Login();
            user = new AUser("");
            //the next line shows how a user will be authenticated
            //user = login.AuthorizeUser("username", "password");

            //
            // playlist
            //
            playlist = new ActivePlaylist(new APlaylist());
            audioPlayer = new DBAudioPlayer(new AudioPlayer(), serverHost, serverPort);

            //
            //current track and album art
            //
            //currentTrack = new CurrentTrack();
            imageSearch = new AlbumArtSearch(serverHost, serverPort);

            //
            //search
            //
            trackSearch = new DBSearch(serverHost, serverPort);
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
                audioPlayer = new AudioPlayer();
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
            //Checks if user is logged in 
            //If false throws error message
            try
            {
                //Similar to check if username is null
                if (user.Username != "")
                {
                    String message = String.Empty;
                    message = user.Username + ": " + this.chatTextEntryBox.Text;
                    socket.Emit("chat", (message));
                    this.chatTextEntryBox.Text = "";
                }

                else
                {
                    //Displays error message to user
                    MessageBox.Show("User is not logged in", "Chat",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //Block that doesn't allow for text to be sent if username is similar to null
            finally
            {
                if(user.Username == "")
                {
                    this.chatFeedBox.Text = "";
                }
            }
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
        private void InitializeChat(string host, int port)
        {
            socket = IO.Socket(host + ":" + port.ToString());//"http://159.65.235.100:8080");
            socket.On(Socket.EVENT_CONNECT, () =>
            {
                //Testing purposes
                Console.WriteLine("client connected");

                //Welcome Message
                socket.Emit("chat", "***Chat is connected***");
            });

            socket.On("chat", (data) =>
            {
                //Testing purposes
                Console.WriteLine(data);
               
                //Constant Update Messages
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

        /*
        //
        //placeholder for showing album art
        //
        private void showAlbumArtButton_Click(object sender, EventArgs e)
        {
            //query this string to our server
            //String queryURL = $"http://159.65.235.100/covers/{currentTrack.artist}/{currentTrack.album}";

            //make http request to queryURL

            //HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://159.65.235.100:6024/covers/{currentTrack.artist}/{currentTrack.album}");
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://159.65.235.100:8080/covers/Curtis-Mayfield/Super-Fly");

            //response from queryURL is a string which is the imageURL
            HttpWebResponse HttpWResp = (HttpWebResponse)myReq.GetResponse();

            // Insert code that uses the response object.
            WebHeaderCollection header = HttpWResp.Headers;
            string responseText = string.Empty;
            var encoding = ASCIIEncoding.ASCII;
            using (var reader = new System.IO.StreamReader(HttpWResp.GetResponseStream(), encoding))
            {
                responseText = reader.ReadToEnd();
            }

            //Console.WriteLine(responseText);

            //update picture box based on new url
            pictureBox1.ImageLocation = responseText;
        }
    */
    }
}