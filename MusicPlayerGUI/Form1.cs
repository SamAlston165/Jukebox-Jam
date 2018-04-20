using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "Now Playing:" + Environment.NewLine + Environment.NewLine + "Your Song" + Environment.NewLine + "Elton John";
        }
        /*
         To define the chat functionality we need to gather the text from the current rich texbtox when the send button is clicked and then append it to the upper
         right textbox.
         After this we need to clear the data on the input textbox.
             */
        private void btnSend_Click(object sender, EventArgs e)
        {
            this.richTextBox2.Text += Environment.NewLine + "User: " + this.richTextBox3.Text;
            this.richTextBox3.Text = "";
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
	}
}
