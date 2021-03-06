﻿namespace MusicPlayerGUI
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
            this.label4 = new System.Windows.Forms.Label();
            this.searchBackground = new System.Windows.Forms.RichTextBox();
            this.songSearchTextBox = new System.Windows.Forms.TextBox();
            this.editPlaylistBox = new System.Windows.Forms.GroupBox();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.searchTypeDropDown = new System.Windows.Forms.ComboBox();
            this.playlistBox = new System.Windows.Forms.ListBox();
            this.addToPlaylistButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.searchResultsListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.loginSuccessOrFailLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.albumLabel = new System.Windows.Forms.Label();
            this.songInfoPanel = new System.Windows.Forms.Panel();
            this.genreLabel = new System.Windows.Forms.Label();
            this.editPlaylistBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.songInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // channelBox
            // 
            this.channelBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.channelBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.channelBox.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelBox.FormattingEnabled = true;
            this.channelBox.ItemHeight = 19;
            this.channelBox.Items.AddRange(new object[] {
            "+ Channel 1",
            "+ Channel 2",
            "+ Channel 3",
            "+ Channel 4",
            "+ Channel 5"});
            this.channelBox.Location = new System.Drawing.Point(0, 38);
            this.channelBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.channelBox.Name = "channelBox";
            this.channelBox.Size = new System.Drawing.Size(189, 361);
            this.channelBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Channels";
            // 
            // chatFeedBox
            // 
            this.chatFeedBox.BackColor = System.Drawing.SystemColors.Window;
            this.chatFeedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatFeedBox.Location = new System.Drawing.Point(912, 38);
            this.chatFeedBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chatFeedBox.Name = "chatFeedBox";
            this.chatFeedBox.Size = new System.Drawing.Size(213, 219);
            this.chatFeedBox.TabIndex = 3;
            this.chatFeedBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(975, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chat";
            // 
            // chatTextEntryBox
            // 
            this.chatTextEntryBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.chatTextEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatTextEntryBox.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatTextEntryBox.Location = new System.Drawing.Point(912, 254);
            this.chatTextEntryBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chatTextEntryBox.Name = "chatTextEntryBox";
            this.chatTextEntryBox.Size = new System.Drawing.Size(213, 104);
            this.chatTextEntryBox.TabIndex = 5;
            this.chatTextEntryBox.Text = "";
            this.chatTextEntryBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatTextEntryBox_KeyDown);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(912, 366);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(215, 42);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(297, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Playlist";
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Navy;
            this.nextButton.BackgroundImage = global::MusicPlayerGUI.Properties.Resources.nextTrackButton_BackgroundImage;
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.ForeColor = System.Drawing.Color.Navy;
            this.nextButton.Location = new System.Drawing.Point(784, 455);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(93, 86);
            this.nextButton.TabIndex = 12;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Navy;
            this.stopButton.BackgroundImage = global::MusicPlayerGUI.Properties.Resources.stopButton_BackgroundImage;
            this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.ForeColor = System.Drawing.Color.Navy;
            this.stopButton.Location = new System.Drawing.Point(364, 455);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(93, 86);
            this.stopButton.TabIndex = 11;
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.Navy;
            this.pauseButton.BackgroundImage = global::MusicPlayerGUI.Properties.Resources.pauseButton_BackgroundImage;
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.ForeColor = System.Drawing.Color.Navy;
            this.pauseButton.Location = new System.Drawing.Point(639, 455);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(93, 86);
            this.pauseButton.TabIndex = 10;
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Navy;
            this.playButton.BackgroundImage = global::MusicPlayerGUI.Properties.Resources.playButton_BackgroundImage;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.ForeColor = System.Drawing.Color.Navy;
            this.playButton.Location = new System.Drawing.Point(500, 455);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(93, 86);
            this.playButton.TabIndex = 9;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.Navy;
            this.previousButton.BackgroundImage = global::MusicPlayerGUI.Properties.Resources.prevTrackButton_BackgroundImage;
            this.previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.ForeColor = System.Drawing.Color.Navy;
            this.previousButton.Location = new System.Drawing.Point(209, 455);
            this.previousButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(93, 86);
            this.previousButton.TabIndex = 8;
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(735, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 33);
            this.label4.TabIndex = 17;
            this.label4.Text = "Search";
            // 
            // searchBackground
            // 
            this.searchBackground.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchBackground.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBackground.Location = new System.Drawing.Point(656, 41);
            this.searchBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBackground.Name = "searchBackground";
            this.searchBackground.Size = new System.Drawing.Size(248, 369);
            this.searchBackground.TabIndex = 18;
            this.searchBackground.Text = "";
            // 
            // songSearchTextBox
            // 
            this.songSearchTextBox.Location = new System.Drawing.Point(656, 74);
            this.songSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.songSearchTextBox.Name = "songSearchTextBox";
            this.songSearchTextBox.Size = new System.Drawing.Size(247, 22);
            this.songSearchTextBox.TabIndex = 20;
            // 
            // editPlaylistBox
            // 
            this.editPlaylistBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.editPlaylistBox.Controls.Add(this.moveDownButton);
            this.editPlaylistBox.Controls.Add(this.removeButton);
            this.editPlaylistBox.Controls.Add(this.moveUpButton);
            this.editPlaylistBox.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPlaylistBox.Location = new System.Drawing.Point(551, 38);
            this.editPlaylistBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editPlaylistBox.Name = "editPlaylistBox";
            this.editPlaylistBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editPlaylistBox.Size = new System.Drawing.Size(97, 372);
            this.editPlaylistBox.TabIndex = 21;
            this.editPlaylistBox.TabStop = false;
            this.editPlaylistBox.Text = "Edit Playlist";
            // 
            // moveDownButton
            // 
            this.moveDownButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.moveDownButton.Image = ((System.Drawing.Image)(resources.GetObject("moveDownButton.Image")));
            this.moveDownButton.Location = new System.Drawing.Point(12, 238);
            this.moveDownButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(73, 53);
            this.moveDownButton.TabIndex = 2;
            this.moveDownButton.UseVisualStyleBackColor = false;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeButton.Image = ((System.Drawing.Image)(resources.GetObject("removeButton.Image")));
            this.removeButton.Location = new System.Drawing.Point(12, 142);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(73, 60);
            this.removeButton.TabIndex = 1;
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.moveUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveUpButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.moveUpButton.Image = ((System.Drawing.Image)(resources.GetObject("moveUpButton.Image")));
            this.moveUpButton.Location = new System.Drawing.Point(12, 58);
            this.moveUpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(73, 50);
            this.moveUpButton.TabIndex = 0;
            this.moveUpButton.UseVisualStyleBackColor = false;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // searchTypeDropDown
            // 
            this.searchTypeDropDown.BackColor = System.Drawing.Color.White;
            this.searchTypeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchTypeDropDown.FormattingEnabled = true;
            this.searchTypeDropDown.Items.AddRange(new object[] {
            "Artist",
            "Title",
            "Genre"});
            this.searchTypeDropDown.Location = new System.Drawing.Point(741, 41);
            this.searchTypeDropDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTypeDropDown.Name = "searchTypeDropDown";
            this.searchTypeDropDown.Size = new System.Drawing.Size(149, 24);
            this.searchTypeDropDown.TabIndex = 22;
            // 
            // playlistBox
            // 
            this.playlistBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.playlistBox.FormattingEnabled = true;
            this.playlistBox.ItemHeight = 16;
            this.playlistBox.Location = new System.Drawing.Point(197, 38);
            this.playlistBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playlistBox.Name = "playlistBox";
            this.playlistBox.Size = new System.Drawing.Size(344, 372);
            this.playlistBox.TabIndex = 23;
            this.playlistBox.DoubleClick += new System.EventHandler(this.playlistBox_DoubleClick);
            // 
            // addToPlaylistButton
            // 
            this.addToPlaylistButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addToPlaylistButton.Location = new System.Drawing.Point(663, 372);
            this.addToPlaylistButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addToPlaylistButton.Name = "addToPlaylistButton";
            this.addToPlaylistButton.Size = new System.Drawing.Size(100, 28);
            this.addToPlaylistButton.TabIndex = 24;
            this.addToPlaylistButton.Text = "<< Add";
            this.addToPlaylistButton.UseVisualStyleBackColor = false;
            this.addToPlaylistButton.Click += new System.EventHandler(this.addToPlaylistButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(0, 407);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(912, 438);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(213, 22);
            this.userNameTextBox.TabIndex = 26;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(912, 487);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(213, 22);
            this.passwordTextBox.TabIndex = 27;
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logInButton.Location = new System.Drawing.Point(965, 523);
            this.logInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(100, 28);
            this.logInButton.TabIndex = 28;
            this.logInButton.Text = "Log in";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(968, 416);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(90, 18);
            this.usernameLabel.TabIndex = 29;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(968, 466);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(88, 18);
            this.passwordLabel.TabIndex = 30;
            this.passwordLabel.Text = "Password:";
            // 
            // searchResultsListBox
            // 
            this.searchResultsListBox.FormattingEnabled = true;
            this.searchResultsListBox.ItemHeight = 16;
            this.searchResultsListBox.Location = new System.Drawing.Point(656, 135);
            this.searchResultsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchResultsListBox.Name = "searchResultsListBox";
            this.searchResultsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.searchResultsListBox.Size = new System.Drawing.Size(247, 228);
            this.searchResultsListBox.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(659, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Search By";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchButton.Location = new System.Drawing.Point(723, 106);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 33;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // loginSuccessOrFailLabel
            // 
            this.loginSuccessOrFailLabel.AutoSize = true;
            this.loginSuccessOrFailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginSuccessOrFailLabel.Location = new System.Drawing.Point(932, 555);
            this.loginSuccessOrFailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginSuccessOrFailLabel.Name = "loginSuccessOrFailLabel";
            this.loginSuccessOrFailLabel.Size = new System.Drawing.Size(164, 17);
            this.loginSuccessOrFailLabel.TabIndex = 35;
            this.loginSuccessOrFailLabel.Text = "loginSuccessOrFailLabel";
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.Location = new System.Drawing.Point(16, 20);
            this.artistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(112, 25);
            this.artistLabel.TabIndex = 36;
            this.artistLabel.Text = "artistLabel";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(17, 44);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(83, 24);
            this.titleLabel.TabIndex = 37;
            this.titleLabel.Text = "titleLabel";
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.albumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumLabel.Location = new System.Drawing.Point(17, 66);
            this.albumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(95, 20);
            this.albumLabel.TabIndex = 38;
            this.albumLabel.Text = "albumLabel";
            // 
            // songInfoPanel
            // 
            this.songInfoPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.songInfoPanel.Controls.Add(this.genreLabel);
            this.songInfoPanel.Controls.Add(this.titleLabel);
            this.songInfoPanel.Controls.Add(this.albumLabel);
            this.songInfoPanel.Controls.Add(this.artistLabel);
            this.songInfoPanel.Location = new System.Drawing.Point(0, 284);
            this.songInfoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.songInfoPanel.Name = "songInfoPanel";
            this.songInfoPanel.Size = new System.Drawing.Size(189, 123);
            this.songInfoPanel.TabIndex = 39;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(17, 86);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(80, 18);
            this.genreLabel.TabIndex = 39;
            this.genreLabel.Text = "genreLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1140, 572);
            this.Controls.Add(this.songInfoPanel);
            this.Controls.Add(this.loginSuccessOrFailLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchResultsListBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addToPlaylistButton);
            this.Controls.Add(this.editPlaylistBox);
            this.Controls.Add(this.searchTypeDropDown);
            this.Controls.Add(this.songSearchTextBox);
            this.Controls.Add(this.searchBackground);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.playlistBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1162, 623);
            this.MinimumSize = new System.Drawing.Size(1162, 623);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JukeBox Jam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.editPlaylistBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.songInfoPanel.ResumeLayout(false);
            this.songInfoPanel.PerformLayout();
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox searchBackground;
		private System.Windows.Forms.TextBox songSearchTextBox;
		private System.Windows.Forms.GroupBox editPlaylistBox;
		private System.Windows.Forms.Button moveDownButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Button moveUpButton;
		private System.Windows.Forms.ComboBox searchTypeDropDown;
		private System.Windows.Forms.ListBox playlistBox;
		private System.Windows.Forms.Button addToPlaylistButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox userNameTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Button logInButton;
		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.ListBox searchResultsListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label loginSuccessOrFailLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Panel songInfoPanel;
        private System.Windows.Forms.Label genreLabel;
    }
}

