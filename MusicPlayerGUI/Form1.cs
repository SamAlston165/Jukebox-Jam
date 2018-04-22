using Audio;
using Chat;
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
using Views;

namespace MusicPlayerGUI
{
    public partial class Form1 : Form
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


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string trackHost = "http://159.65.235.100";
            int trackPort = 6024;

            login = new Login();

            //user = login.AuthorizeUser("username", "password");
            user = new AUser("");
            chatSender = new ChatSender(user);
            chatReceiver = new ChatReceiver();

            activePlaylist = new ActivePlaylist(new APlaylist());
            audioPlayer = new DBAudioPlayer(new AudioPlayer(), trackHost, trackPort);
            currentTrack = new CurrentTrack();

            //imageSearch = new ImageSearch();
            //playlistSearch = new PlaylistSearch();
            trackSearch = new DBSearch(trackHost, trackPort);

            this.songInfoBox.Text = "Now Playing:" + Environment.NewLine + Environment.NewLine + "Your Song" + Environment.NewLine + "Elton John";
        }
        /*
         To define the chat functionality we need to gather the text from the current rich texbtox when the send button is clicked and then append it to the upper
         right textbox.
         After this we need to clear the data on the input textbox.
             */
        private void btnSend_Click(object sender, EventArgs e)
        {
            this.chatFeedBox.Text += Environment.NewLine + "User: " + this.chatTextEntryBox.Text;
            this.chatTextEntryBox.Text = "";

            chatSender.SendMessage(chatTextEntryBox.Text);
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
	}
}
