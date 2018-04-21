namespace TestGUI
{
    partial class TestGUIForm
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
            this.playlistListBox = new System.Windows.Forms.ListBox();
            this.searchResultsListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentTrackTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // playlistListBox
            // 
            this.playlistListBox.FormattingEnabled = true;
            this.playlistListBox.Location = new System.Drawing.Point(12, 10);
            this.playlistListBox.Name = "playlistListBox";
            this.playlistListBox.Size = new System.Drawing.Size(197, 303);
            this.playlistListBox.TabIndex = 0;
            this.playlistListBox.DoubleClick += new System.EventHandler(this.playlistListBox_DoubleClick);
            // 
            // searchResultsListBox
            // 
            this.searchResultsListBox.FormattingEnabled = true;
            this.searchResultsListBox.Location = new System.Drawing.Point(296, 23);
            this.searchResultsListBox.Name = "searchResultsListBox";
            this.searchResultsListBox.Size = new System.Drawing.Size(187, 251);
            this.searchResultsListBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(215, 134);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(387, 280);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(152, 20);
            this.searchTextBox.TabIndex = 9;
            this.searchTextBox.Text = "random gibberish";
            // 
            // searchTypeComboBox
            // 
            this.searchTypeComboBox.FormattingEnabled = true;
            this.searchTypeComboBox.Items.AddRange(new object[] {
            "Artist",
            "Title",
            "Album",
            "Genre",
            "Year"});
            this.searchTypeComboBox.Location = new System.Drawing.Point(296, 280);
            this.searchTypeComboBox.Name = "searchTypeComboBox";
            this.searchTypeComboBox.Size = new System.Drawing.Size(85, 21);
            this.searchTypeComboBox.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(561, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 11;
            // 
            // currentTrackTextBox
            // 
            this.currentTrackTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTrackTextBox.Location = new System.Drawing.Point(489, 38);
            this.currentTrackTextBox.Name = "currentTrackTextBox";
            this.currentTrackTextBox.Size = new System.Drawing.Size(220, 96);
            this.currentTrackTextBox.TabIndex = 12;
            this.currentTrackTextBox.Text = "";
            // 
            // TestGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 375);
            this.Controls.Add(this.currentTrackTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchTypeComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchResultsListBox);
            this.Controls.Add(this.playlistListBox);
            this.Name = "TestGUIForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playlistListBox;
        private System.Windows.Forms.ListBox searchResultsListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox searchTypeComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox currentTrackTextBox;
    }
}

