namespace MusicPlayerGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.channelBox = new System.Windows.Forms.ListBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.label1 = new System.Windows.Forms.Label();
			this.chatFeedBox = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.chatTextEntryBox = new System.Windows.Forms.RichTextBox();
			this.sendButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.nextButton = new System.Windows.Forms.Button();
			this.stopButton = new System.Windows.Forms.Button();
			this.pauseButton = new System.Windows.Forms.Button();
			this.playButton = new System.Windows.Forms.Button();
			this.previousButton = new System.Windows.Forms.Button();
			this.playlistSearchButton = new System.Windows.Forms.Button();
			this.playlistSearchTextBox = new System.Windows.Forms.TextBox();
			this.editChannelButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.searchBackground = new System.Windows.Forms.RichTextBox();
			this.songSearchTextBox = new System.Windows.Forms.TextBox();
			this.editPlaylistBox = new System.Windows.Forms.GroupBox();
			this.moveDownButton = new System.Windows.Forms.Button();
			this.removeButton = new System.Windows.Forms.Button();
			this.moveUpButton = new System.Windows.Forms.Button();
			this.searchTypeDropDown = new System.Windows.Forms.ComboBox();
			this.playlistBox = new System.Windows.Forms.ListBox();
			this.searchResultsBox = new System.Windows.Forms.ListView();
			this.addToPlaylistButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.userNameTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.logInButton = new System.Windows.Forms.Button();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.editPlaylistBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// channelBox
			// 
			this.channelBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.channelBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.channelBox.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.channelBox.FormattingEnabled = true;
			this.channelBox.ItemHeight = 15;
			this.channelBox.Items.AddRange(new object[] {
            "+ Channel 1",
            "+ Channel 2",
            "+ Channel 3",
            "+ Channel 4",
            "+ Channel 5"});
			this.channelBox.Location = new System.Drawing.Point(0, 31);
			this.channelBox.Name = "channelBox";
			this.channelBox.Size = new System.Drawing.Size(120, 300);
			this.channelBox.TabIndex = 0;
			this.channelBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Channels";
			// 
			// chatFeedBox
			// 
			this.chatFeedBox.BackColor = System.Drawing.SystemColors.Window;
			this.chatFeedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.chatFeedBox.Location = new System.Drawing.Point(684, 31);
			this.chatFeedBox.Name = "chatFeedBox";
			this.chatFeedBox.Size = new System.Drawing.Size(104, 179);
			this.chatFeedBox.TabIndex = 3;
			this.chatFeedBox.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(716, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Chat";
			// 
			// chatTextEntryBox
			// 
			this.chatTextEntryBox.BackColor = System.Drawing.SystemColors.Info;
			this.chatTextEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.chatTextEntryBox.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chatTextEntryBox.Location = new System.Drawing.Point(684, 206);
			this.chatTextEntryBox.Name = "chatTextEntryBox";
			this.chatTextEntryBox.Size = new System.Drawing.Size(104, 85);
			this.chatTextEntryBox.TabIndex = 5;
			this.chatTextEntryBox.Text = "";
			this.chatTextEntryBox.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
			// 
			// sendButton
			// 
			this.sendButton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sendButton.Location = new System.Drawing.Point(684, 297);
			this.sendButton.Name = "sendButton";
			this.sendButton.Size = new System.Drawing.Size(104, 34);
			this.sendButton.TabIndex = 6;
			this.sendButton.Text = "Send";
			this.sendButton.UseVisualStyleBackColor = false;
			this.sendButton.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(277, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 25);
			this.label3.TabIndex = 7;
			this.label3.Text = "Playlist";
			// 
			// nextButton
			// 
			this.nextButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.nextButton.BackgroundImage = global::MusicPlayerGUI.Properties.Resources.nextTrackButton_BackgroundImage;
			this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.nextButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.nextButton.Location = new System.Drawing.Point(579, 356);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(70, 70);
			this.nextButton.TabIndex = 12;
			this.nextButton.UseVisualStyleBackColor = false;
			// 
			// stopButton
			// 
			this.stopButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.stopButton.BackgroundImage = global::MusicPlayerGUI.Properties.Resources.stopButton_BackgroundImage;
			this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.stopButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.stopButton.Location = new System.Drawing.Point(264, 356);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(70, 70);
			this.stopButton.TabIndex = 11;
			this.stopButton.UseVisualStyleBackColor = false;
			// 
			// pauseButton
			// 
			this.pauseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pauseButton.BackgroundImage = global::MusicPlayerGUI.Properties.Resources.pauseButton_BackgroundImage;
			this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.pauseButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.pauseButton.Location = new System.Drawing.Point(470, 356);
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Size = new System.Drawing.Size(70, 70);
			this.pauseButton.TabIndex = 10;
			this.pauseButton.UseVisualStyleBackColor = false;
			// 
			// playButton
			// 
			this.playButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.playButton.BackgroundImage = global::MusicPlayerGUI.Properties.Resources.playButton_BackgroundImage;
			this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.playButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.playButton.Location = new System.Drawing.Point(366, 356);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(70, 70);
			this.playButton.TabIndex = 9;
			this.playButton.UseVisualStyleBackColor = false;
			this.playButton.Click += new System.EventHandler(this.playButton_Click);
			// 
			// previousButton
			// 
			this.previousButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.previousButton.BackgroundImage = global::MusicPlayerGUI.Properties.Resources.prevTrackButton_BackgroundImage;
			this.previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.previousButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.previousButton.Location = new System.Drawing.Point(148, 356);
			this.previousButton.Name = "previousButton";
			this.previousButton.Size = new System.Drawing.Size(70, 70);
			this.previousButton.TabIndex = 8;
			this.previousButton.UseVisualStyleBackColor = false;
			// 
			// playlistSearchButton
			// 
			this.playlistSearchButton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.playlistSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playlistSearchButton.Location = new System.Drawing.Point(324, 45);
			this.playlistSearchButton.Name = "playlistSearchButton";
			this.playlistSearchButton.Size = new System.Drawing.Size(75, 20);
			this.playlistSearchButton.TabIndex = 14;
			this.playlistSearchButton.Text = "Search";
			this.playlistSearchButton.UseVisualStyleBackColor = false;
			this.playlistSearchButton.Click += new System.EventHandler(this.playlistSearchButton_Click);
			// 
			// playlistSearchTextBox
			// 
			this.playlistSearchTextBox.Location = new System.Drawing.Point(137, 46);
			this.playlistSearchTextBox.Name = "playlistSearchTextBox";
			this.playlistSearchTextBox.Size = new System.Drawing.Size(181, 20);
			this.playlistSearchTextBox.TabIndex = 15;
			// 
			// editChannelButton
			// 
			this.editChannelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editChannelButton.Location = new System.Drawing.Point(12, 288);
			this.editChannelButton.Name = "editChannelButton";
			this.editChannelButton.Size = new System.Drawing.Size(75, 23);
			this.editChannelButton.TabIndex = 16;
			this.editChannelButton.Text = "Edit";
			this.editChannelButton.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(568, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 25);
			this.label4.TabIndex = 17;
			this.label4.Text = "Search";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// searchBackground
			// 
			this.searchBackground.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.searchBackground.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchBackground.Location = new System.Drawing.Point(546, 31);
			this.searchBackground.Name = "searchBackground";
			this.searchBackground.Size = new System.Drawing.Size(132, 300);
			this.searchBackground.TabIndex = 18;
			this.searchBackground.Text = "";
			// 
			// songSearchTextBox
			// 
			this.songSearchTextBox.Location = new System.Drawing.Point(553, 46);
			this.songSearchTextBox.Name = "songSearchTextBox";
			this.songSearchTextBox.Size = new System.Drawing.Size(120, 20);
			this.songSearchTextBox.TabIndex = 20;
			// 
			// editPlaylistBox
			// 
			this.editPlaylistBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.editPlaylistBox.Controls.Add(this.moveDownButton);
			this.editPlaylistBox.Controls.Add(this.removeButton);
			this.editPlaylistBox.Controls.Add(this.moveUpButton);
			this.editPlaylistBox.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editPlaylistBox.Location = new System.Drawing.Point(458, 46);
			this.editPlaylistBox.Name = "editPlaylistBox";
			this.editPlaylistBox.Size = new System.Drawing.Size(73, 265);
			this.editPlaylistBox.TabIndex = 21;
			this.editPlaylistBox.TabStop = false;
			this.editPlaylistBox.Text = "Edit Playlist";
			// 
			// moveDownButton
			// 
			this.moveDownButton.Image = ((System.Drawing.Image)(resources.GetObject("moveDownButton.Image")));
			this.moveDownButton.Location = new System.Drawing.Point(9, 193);
			this.moveDownButton.Name = "moveDownButton";
			this.moveDownButton.Size = new System.Drawing.Size(55, 43);
			this.moveDownButton.TabIndex = 2;
			this.moveDownButton.UseVisualStyleBackColor = true;
			// 
			// removeButton
			// 
			this.removeButton.Image = ((System.Drawing.Image)(resources.GetObject("removeButton.Image")));
			this.removeButton.Location = new System.Drawing.Point(9, 115);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(55, 49);
			this.removeButton.TabIndex = 1;
			this.removeButton.UseVisualStyleBackColor = true;
			// 
			// moveUpButton
			// 
			this.moveUpButton.Image = ((System.Drawing.Image)(resources.GetObject("moveUpButton.Image")));
			this.moveUpButton.Location = new System.Drawing.Point(9, 47);
			this.moveUpButton.Name = "moveUpButton";
			this.moveUpButton.Size = new System.Drawing.Size(55, 41);
			this.moveUpButton.TabIndex = 0;
			this.moveUpButton.UseVisualStyleBackColor = true;
			// 
			// searchTypeDropDown
			// 
			this.searchTypeDropDown.FormattingEnabled = true;
			this.searchTypeDropDown.Items.AddRange(new object[] {
            "Artist",
            "Title",
            "Genre",
            "Year"});
			this.searchTypeDropDown.Location = new System.Drawing.Point(553, 81);
			this.searchTypeDropDown.Name = "searchTypeDropDown";
			this.searchTypeDropDown.Size = new System.Drawing.Size(121, 21);
			this.searchTypeDropDown.TabIndex = 22;
			// 
			// playlistBox
			// 
			this.playlistBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.playlistBox.FormattingEnabled = true;
			this.playlistBox.Location = new System.Drawing.Point(126, 31);
			this.playlistBox.Name = "playlistBox";
			this.playlistBox.Size = new System.Drawing.Size(414, 303);
			this.playlistBox.TabIndex = 23;
			// 
			// searchResultsBox
			// 
			this.searchResultsBox.Location = new System.Drawing.Point(552, 113);
			this.searchResultsBox.Name = "searchResultsBox";
			this.searchResultsBox.Size = new System.Drawing.Size(121, 97);
			this.searchResultsBox.TabIndex = 3;
			this.searchResultsBox.UseCompatibleStateImageBehavior = false;
			// 
			// addToPlaylistButton
			// 
			this.addToPlaylistButton.Location = new System.Drawing.Point(573, 216);
			this.addToPlaylistButton.Name = "addToPlaylistButton";
			this.addToPlaylistButton.Size = new System.Drawing.Size(75, 23);
			this.addToPlaylistButton.TabIndex = 24;
			this.addToPlaylistButton.Text = "Add";
			this.addToPlaylistButton.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.pictureBox1.Location = new System.Drawing.Point(0, 331);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 118);
			this.pictureBox1.TabIndex = 25;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// userNameTextBox
			// 
			this.userNameTextBox.Location = new System.Drawing.Point(684, 356);
			this.userNameTextBox.Name = "userNameTextBox";
			this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.userNameTextBox.TabIndex = 26;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(684, 396);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
			this.passwordTextBox.TabIndex = 27;
			// 
			// logInButton
			// 
			this.logInButton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.logInButton.Location = new System.Drawing.Point(701, 422);
			this.logInButton.Name = "logInButton";
			this.logInButton.Size = new System.Drawing.Size(75, 23);
			this.logInButton.TabIndex = 28;
			this.logInButton.Text = "Log in";
			this.logInButton.UseVisualStyleBackColor = false;
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(707, 340);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(58, 13);
			this.usernameLabel.TabIndex = 29;
			this.usernameLabel.Text = "Username:";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(707, 379);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(56, 13);
			this.passwordLabel.TabIndex = 30;
			this.passwordLabel.Text = "Password:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.usernameLabel);
			this.Controls.Add(this.logInButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.userNameTextBox);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.addToPlaylistButton);
			this.Controls.Add(this.searchResultsBox);
			this.Controls.Add(this.editPlaylistBox);
			this.Controls.Add(this.playlistSearchButton);
			this.Controls.Add(this.playlistSearchTextBox);
			this.Controls.Add(this.playlistBox);
			this.Controls.Add(this.searchTypeDropDown);
			this.Controls.Add(this.songSearchTextBox);
			this.Controls.Add(this.searchBackground);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.editChannelButton);
			this.Controls.Add(this.nextButton);
			this.Controls.Add(this.stopButton);
			this.Controls.Add(this.pauseButton);
			this.Controls.Add(this.playButton);
			this.Controls.Add(this.previousButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.sendButton);
			this.Controls.Add(this.chatTextEntryBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.chatFeedBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.channelBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MinimumSize = new System.Drawing.Size(820, 493);
			this.Name = "Form1";
			this.Text = "JukeBox Jam";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.editPlaylistBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox channelBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox chatFeedBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox chatTextEntryBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button nextButton;
		private System.Windows.Forms.Button playlistSearchButton;
		private System.Windows.Forms.TextBox playlistSearchTextBox;
		private System.Windows.Forms.Button editChannelButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox searchBackground;
		private System.Windows.Forms.TextBox songSearchTextBox;
		private System.Windows.Forms.GroupBox editPlaylistBox;
		private System.Windows.Forms.Button moveDownButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Button moveUpButton;
		private System.Windows.Forms.ComboBox searchTypeDropDown;
		private System.Windows.Forms.ListBox playlistBox;
		private System.Windows.Forms.ListView searchResultsBox;
		private System.Windows.Forms.Button addToPlaylistButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox userNameTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Button logInButton;
		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.Label passwordLabel;
	}
}

