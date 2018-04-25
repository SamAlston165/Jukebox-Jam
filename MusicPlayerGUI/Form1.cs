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
using Views;
using System.Net;

namespace MusicPlayerGUI
{
    public partial class Form1 : Form
    {
        //chat
        private ILogin login;
        private IUser user;
        //private IChatSender chatSender;
        //private IChatReceiver chatReceiver;
        private Socket socket;
        public delegate void UpdateTextBoxMethod(string text);

        //playlist
        private IActivePlaylist playlist;
        private IAudioPlayer audioPlayer;

        //current track and album art
        //private ICurrentTrack currentTrack;
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
            int trackPort = 6024;

            //
            //chat
            //
            //InitializeChat();
            login = new Login();
            user = new AUser("");
            //the next line shows how a user will be authenticated
            //user = login.AuthorizeUser("username", "password");

            //chatSender = new ChatSender(user);
            //chatReceiver = new ChatReceiver();

            //
            // playlist
            //
            playlist = new ActivePlaylist(new APlaylist());
            audioPlayer = new DBAudioPlayer(new AudioPlayer(), trackHost, trackPort);

            //
            //current track and album art
            //
            //currentTrack = new CurrentTrack();
            //imageSearch = new ImageSearch();

            //
            //search
            //
            trackSearch = new DBSearch(trackHost, trackPort);
            SearchAllTracks();
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
            // chatSender.SendMessage(chatTextEntryBox.Text);
            // this.chatFeedBox.Text += Environment.NewLine + "User: " + this.chatTextEntryBox.Text;
            // this.chatTextEntryBox.Text = "";

            string message = String.Empty;
            message = this.chatTextEntryBox.Text;
            socket.Emit("chat", (message));
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
                this.chatFeedBox.Text = text;
            }
        }

        private void updateStatus()
        {

        }

        private void InitializeChat()
        {
            socket = IO.Socket("http://159.65.235.100:6024");
            socket.On(Socket.EVENT_CONNECT, () =>
            {
                socket.Emit("chat", (data) =>
                {
                    Console.WriteLine("Chat is connected");
                });
            });

            socket.On("chat", (data) =>
            {
                var messages = new { messages = "" };
                var messageVal = JsonConvert.DeserializeAnonymousType((string)data, messages);
                updateMessages((string)messages.messages);
            });
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            user = login.AuthorizeUser(userNameTextBox.Text, passwordTextBox.Text);
            if (user == null)
            {
                loginSuccessOrFailLabel.Text = "login fail";
            }
            else
            {
                loginSuccessOrFailLabel.Text = "logged in as " + user.Username;
            }
        }

        //
        //placeholder for showing album art
        //
        private void showAlbumArtButton_Click(object sender, EventArgs e)
        {
            //query this string to our server
            /*String queryURL = $"http://159.65.235.100/covers/{currentTrack.artist}/{currentTrack.album}";*/

            //make http request to queryURL

            //HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://159.65.235.100:6024/covers/{currentTrack.artist}/{currentTrack.album}");
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://159.65.235.100:6024/covers/asia/asia");

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

            Console.WriteLine(responseText);

            //update picture box based on new url
            pictureBox1.ImageLocation = responseText;
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

                string currentTrackDetails = "Artist: " + playlist.CurrentTrack.Artist + Environment.NewLine
                    + "Title: " + playlist.CurrentTrack.Title + Environment.NewLine
                    + "Album: " + playlist.CurrentTrack.Album + Environment.NewLine
                    + "Genre: " + playlist.CurrentTrack.Genre + Environment.NewLine
                    + "Year: " + playlist.CurrentTrack.Year + Environment.NewLine;

                currentTrackTextBox.Text = currentTrackDetails;
            }
            catch (Exception ex)
            {
                currentTrackTextBox.Text = ex.Message;
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
                currentTrackTextBox.Text = ex.Message;
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
