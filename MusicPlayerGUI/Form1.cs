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
        private ILogin login;
        private delegate void UpdateTextBoxMethod(string text);
        private IUser user;
        private IChatSender chatSender;
        private IChatReceiver chatReceiver;
        private Socket socket;
        private IActivePlaylist activePlaylist;
        private IAudioPlayer audioPlayer;
        private ICurrentTrack currentTrack;
        private IImageSearch imageSearch;
        private IPlaylistSearch playlistSearch;
        private ISearch trackSearch;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

            string trackHost = "http://159.65.235.100";
            int trackPort = 6024;

            login = new Login();

            //user = login.AuthorizeUser("username", "password");
            user = new AUser("");

            activePlaylist = new ActivePlaylist(new APlaylist());
            audioPlayer = new DBAudioPlayer(new AudioPlayer(), trackHost, trackPort);
            currentTrack = new CurrentTrack();

            //imageSearch = new ImageSearch();
            //playlistSearch = new PlaylistSearch();
            trackSearch = new DBSearch(trackHost, trackPort);

           // this.songInfoBox.Text = "Now Playing:" + Environment.NewLine + Environment.NewLine + "Your Song" + Environment.NewLine + "Elton John";
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

            //STILL NEEDS TO BE TESTED VIA SERVER
            string message = String.Empty;
            message += user.Username + ": " + this.chatTextEntryBox.Text;
            socket.Emit("chat", (message));
            this.chatTextEntryBox.Text = "";
        }

        private void updateMessages(string text)
        {
            if(this.chatFeedBox.InvokeRequired)
            {
                UpdateTextBoxMethod del = new UpdateTextBoxMethod(updateMessages);
                this.Invoke(del, new object[] { text });
            }
            else
            {
                this.chatFeedBox.Text = text;
            }
        }

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void richTextBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void playlistViewBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void playlistSearchButton_Click(object sender, EventArgs e)
		{

		}


		private void pictureBox1_Click(object sender, EventArgs e)
		{
			
		}

		private void playButton_Click(object sender, EventArgs e)
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
	}
}