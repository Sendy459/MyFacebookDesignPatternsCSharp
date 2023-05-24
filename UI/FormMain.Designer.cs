namespace UI
{
    public partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.postPanel = new System.Windows.Forms.Panel();
            this.colorChangerNotifierButton = new UI.ColorChangerNotifier();
            this.recentPosts = new System.Windows.Forms.Label();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.filterByPanel = new System.Windows.Forms.Panel();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterByOptionPicker = new System.Windows.Forms.CheckedListBox();
            this.NumberOptionPicker = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleOptionPicked = new System.Windows.Forms.Label();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.dotOnlineOrOffline = new System.Windows.Forms.Label();
            this.nameLoggedInUser = new System.Windows.Forms.Label();
            this.likedPages = new System.Windows.Forms.Button();
            this.favoriteTeams = new System.Windows.Forms.Button();
            this.albums = new System.Windows.Forms.Button();
            this.groups = new System.Windows.Forms.Button();
            this.events = new System.Windows.Forms.Button();
            this.birthdayPanel = new System.Windows.Forms.Panel();
            this.birthday = new System.Windows.Forms.Button();
            this.horoscope = new System.Windows.Forms.Button();
            this.timerHighlightBox = new System.Windows.Forms.Timer(this.components);
            this.highlightBox = new System.Windows.Forms.Button();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.panelAlbumDescriptionsChanger = new System.Windows.Forms.Panel();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.postPanel.SuspendLayout();
            this.displayPanel.SuspendLayout();
            this.filterByPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.birthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.panelAlbumDescriptionsChanger.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(76, 50);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(116, 22);
            descriptionLabel.TabIndex = 57;
            descriptionLabel.Text = "Description:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(76, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(71, 22);
            nameLabel.TabIndex = 58;
            nameLabel.Text = "Name:";
            // 
            // postPanel
            // 
            this.postPanel.AutoScroll = true;
            this.postPanel.Controls.Add(this.colorChangerNotifierButton);
            this.postPanel.Controls.Add(this.recentPosts);
            this.postPanel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.postPanel.Location = new System.Drawing.Point(247, 0);
            this.postPanel.Name = "postPanel";
            this.postPanel.Size = new System.Drawing.Size(523, 268);
            this.postPanel.TabIndex = 64;
            // 
            // colorChangerNotifierButton
            // 
            this.colorChangerNotifierButton.BackColor = System.Drawing.Color.Gold;
            this.colorChangerNotifierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorChangerNotifierButton.Location = new System.Drawing.Point(362, 2);
            this.colorChangerNotifierButton.Name = "colorChangerNotifierButton";
            this.colorChangerNotifierButton.Size = new System.Drawing.Size(160, 33);
            this.colorChangerNotifierButton.TabIndex = 59;
            this.colorChangerNotifierButton.Text = "Change Color";
            this.colorChangerNotifierButton.UseVisualStyleBackColor = false;
            // 
            // recentPosts
            // 
            this.recentPosts.AutoSize = true;
            this.recentPosts.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.recentPosts.Location = new System.Drawing.Point(211, 37);
            this.recentPosts.Name = "recentPosts";
            this.recentPosts.Size = new System.Drawing.Size(126, 23);
            this.recentPosts.TabIndex = 58;
            this.recentPosts.Text = "Recent posts";
            this.recentPosts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayPanel
            // 
            this.displayPanel.AutoScroll = true;
            this.displayPanel.Controls.Add(this.filterByPanel);
            this.displayPanel.Controls.Add(this.titleOptionPicked);
            this.displayPanel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.displayPanel.Location = new System.Drawing.Point(247, 283);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(523, 300);
            this.displayPanel.TabIndex = 63;
            // 
            // filterByPanel
            // 
            this.filterByPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filterByPanel.Controls.Add(this.buttonFilter);
            this.filterByPanel.Controls.Add(this.label2);
            this.filterByPanel.Controls.Add(this.FilterByOptionPicker);
            this.filterByPanel.Controls.Add(this.NumberOptionPicker);
            this.filterByPanel.Controls.Add(this.label1);
            this.filterByPanel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.filterByPanel.Location = new System.Drawing.Point(3, 57);
            this.filterByPanel.Name = "filterByPanel";
            this.filterByPanel.Size = new System.Drawing.Size(495, 118);
            this.filterByPanel.TabIndex = 67;
            this.filterByPanel.Visible = false;
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.Gold;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.Location = new System.Drawing.Point(355, 57);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(115, 33);
            this.buttonFilter.TabIndex = 63;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 62;
            this.label2.Text = "Photos In Album";
            // 
            // FilterByOptionPicker
            // 
            this.FilterByOptionPicker.BackColor = System.Drawing.Color.LightSeaGreen;
            this.FilterByOptionPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterByOptionPicker.FormattingEnabled = true;
            this.FilterByOptionPicker.Items.AddRange(new object[] {
            "No Filter",
            "Less Than ",
            "More Than"});
            this.FilterByOptionPicker.Location = new System.Drawing.Point(119, 21);
            this.FilterByOptionPicker.Name = "FilterByOptionPicker";
            this.FilterByOptionPicker.Size = new System.Drawing.Size(128, 77);
            this.FilterByOptionPicker.TabIndex = 60;
            this.FilterByOptionPicker.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.FilterByOptionPicker_ItemCheck);
            this.FilterByOptionPicker.SelectedIndexChanged += new System.EventHandler(this.FilterByOptionPicker_SelectedIndexChanged);
            // 
            // NumberOptionPicker
            // 
            this.NumberOptionPicker.BackColor = System.Drawing.Color.LightSeaGreen;
            this.NumberOptionPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberOptionPicker.Enabled = false;
            this.NumberOptionPicker.FormattingEnabled = true;
            this.NumberOptionPicker.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.NumberOptionPicker.Location = new System.Drawing.Point(253, 21);
            this.NumberOptionPicker.Name = "NumberOptionPicker";
            this.NumberOptionPicker.Size = new System.Drawing.Size(73, 77);
            this.NumberOptionPicker.TabIndex = 59;
            this.NumberOptionPicker.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.NumberOptionPicker_ItemCheck);
            this.NumberOptionPicker.SelectedIndexChanged += new System.EventHandler(this.NumberOptionPicker_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 61;
            this.label1.Text = "Filter By:";
            // 
            // titleOptionPicked
            // 
            this.titleOptionPicked.AutoSize = true;
            this.titleOptionPicked.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.titleOptionPicked.Location = new System.Drawing.Point(197, 31);
            this.titleOptionPicked.Name = "titleOptionPicked";
            this.titleOptionPicked.Size = new System.Drawing.Size(142, 23);
            this.titleOptionPicked.TabIndex = 57;
            this.titleOptionPicked.Text = "Pick an option";
            this.titleOptionPicked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.loginPanel);
            this.sidebarPanel.Controls.Add(this.likedPages);
            this.sidebarPanel.Controls.Add(this.favoriteTeams);
            this.sidebarPanel.Controls.Add(this.albums);
            this.sidebarPanel.Controls.Add(this.groups);
            this.sidebarPanel.Controls.Add(this.events);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(228, 643);
            this.sidebarPanel.TabIndex = 62;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.loginPanel.Controls.Add(this.buttonLogout);
            this.loginPanel.Controls.Add(this.buttonLogin);
            this.loginPanel.Controls.Add(this.pictureBoxProfile);
            this.loginPanel.Controls.Add(this.dotOnlineOrOffline);
            this.loginPanel.Controls.Add(this.nameLoggedInUser);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginPanel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(228, 147);
            this.loginPanel.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Gold;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Location = new System.Drawing.Point(124, 14);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(104, 47);
            this.buttonLogout.TabIndex = 57;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Gold;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(0, 14);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(104, 47);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(13, 69);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(70, 66);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 41;
            this.pictureBoxProfile.TabStop = false;
            // 
            // dotOnlineOrOffline
            // 
            this.dotOnlineOrOffline.AutoSize = true;
            this.dotOnlineOrOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dotOnlineOrOffline.ForeColor = System.Drawing.Color.Red;
            this.dotOnlineOrOffline.Location = new System.Drawing.Point(107, 91);
            this.dotOnlineOrOffline.Name = "dotOnlineOrOffline";
            this.dotOnlineOrOffline.Size = new System.Drawing.Size(20, 26);
            this.dotOnlineOrOffline.TabIndex = 56;
            this.dotOnlineOrOffline.Text = "•";
            // 
            // nameLoggedInUser
            // 
            this.nameLoggedInUser.AutoSize = true;
            this.nameLoggedInUser.ForeColor = System.Drawing.Color.White;
            this.nameLoggedInUser.Location = new System.Drawing.Point(133, 95);
            this.nameLoggedInUser.Name = "nameLoggedInUser";
            this.nameLoggedInUser.Size = new System.Drawing.Size(69, 22);
            this.nameLoggedInUser.TabIndex = 55;
            this.nameLoggedInUser.Text = "Offline";
            // 
            // likedPages
            // 
            this.likedPages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.likedPages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.likedPages.FlatAppearance.BorderSize = 0;
            this.likedPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likedPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.likedPages.Image = ((System.Drawing.Image)(resources.GetObject("likedPages.Image")));
            this.likedPages.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.likedPages.Location = new System.Drawing.Point(0, 538);
            this.likedPages.Name = "likedPages";
            this.likedPages.Size = new System.Drawing.Size(225, 105);
            this.likedPages.TabIndex = 5;
            this.likedPages.Text = "Liked Pages";
            this.likedPages.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.likedPages.UseVisualStyleBackColor = true;
            this.likedPages.Click += new System.EventHandler(this.likedPages_Click);
            // 
            // favoriteTeams
            // 
            this.favoriteTeams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.favoriteTeams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favoriteTeams.FlatAppearance.BorderSize = 0;
            this.favoriteTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favoriteTeams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.favoriteTeams.Image = ((System.Drawing.Image)(resources.GetObject("favoriteTeams.Image")));
            this.favoriteTeams.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.favoriteTeams.Location = new System.Drawing.Point(3, 438);
            this.favoriteTeams.Name = "favoriteTeams";
            this.favoriteTeams.Size = new System.Drawing.Size(222, 94);
            this.favoriteTeams.TabIndex = 4;
            this.favoriteTeams.Text = "Favorite Teams";
            this.favoriteTeams.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.favoriteTeams.UseVisualStyleBackColor = true;
            this.favoriteTeams.Click += new System.EventHandler(this.favoriteTeams_Click);
            // 
            // albums
            // 
            this.albums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.albums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.albums.FlatAppearance.BorderSize = 0;
            this.albums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.albums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.albums.Image = ((System.Drawing.Image)(resources.GetObject("albums.Image")));
            this.albums.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.albums.Location = new System.Drawing.Point(3, 152);
            this.albums.Name = "albums";
            this.albums.Size = new System.Drawing.Size(222, 96);
            this.albums.TabIndex = 1;
            this.albums.Text = "Albums";
            this.albums.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.albums.UseVisualStyleBackColor = true;
            this.albums.Click += new System.EventHandler(this.albums_Click);
            // 
            // groups
            // 
            this.groups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groups.FlatAppearance.BorderSize = 0;
            this.groups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.groups.Image = ((System.Drawing.Image)(resources.GetObject("groups.Image")));
            this.groups.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.groups.Location = new System.Drawing.Point(0, 343);
            this.groups.Name = "groups";
            this.groups.Size = new System.Drawing.Size(225, 89);
            this.groups.TabIndex = 3;
            this.groups.Text = "Groups";
            this.groups.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.groups.UseVisualStyleBackColor = true;
            this.groups.Click += new System.EventHandler(this.groups_Click);
            // 
            // events
            // 
            this.events.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.events.Cursor = System.Windows.Forms.Cursors.Hand;
            this.events.FlatAppearance.BorderSize = 0;
            this.events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.events.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.events.Image = ((System.Drawing.Image)(resources.GetObject("events.Image")));
            this.events.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.events.Location = new System.Drawing.Point(3, 254);
            this.events.Name = "events";
            this.events.Size = new System.Drawing.Size(222, 83);
            this.events.TabIndex = 2;
            this.events.Text = "Events";
            this.events.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.events.UseVisualStyleBackColor = true;
            this.events.Click += new System.EventHandler(this.events_Click);
            // 
            // birthdayPanel
            // 
            this.birthdayPanel.Controls.Add(this.birthday);
            this.birthdayPanel.Controls.Add(this.horoscope);
            this.birthdayPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.birthdayPanel.Location = new System.Drawing.Point(228, 586);
            this.birthdayPanel.Name = "birthdayPanel";
            this.birthdayPanel.Size = new System.Drawing.Size(542, 57);
            this.birthdayPanel.TabIndex = 58;
            // 
            // birthday
            // 
            this.birthday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.birthday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birthday.FlatAppearance.BorderSize = 0;
            this.birthday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.birthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.birthday.Image = ((System.Drawing.Image)(resources.GetObject("birthday.Image")));
            this.birthday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.birthday.Location = new System.Drawing.Point(0, 3);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(135, 54);
            this.birthday.TabIndex = 67;
            this.birthday.Text = "Your Next Birthday";
            this.birthday.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.birthday.UseVisualStyleBackColor = true;
            this.birthday.Click += new System.EventHandler(this.birthday_Click);
            // 
            // horoscope
            // 
            this.horoscope.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.horoscope.Cursor = System.Windows.Forms.Cursors.Hand;
            this.horoscope.FlatAppearance.BorderSize = 0;
            this.horoscope.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.horoscope.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.horoscope.Image = ((System.Drawing.Image)(resources.GetObject("horoscope.Image")));
            this.horoscope.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.horoscope.Location = new System.Drawing.Point(407, 3);
            this.horoscope.Name = "horoscope";
            this.horoscope.Size = new System.Drawing.Size(135, 54);
            this.horoscope.TabIndex = 6;
            this.horoscope.Text = "Your Horoscope";
            this.horoscope.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.horoscope.UseVisualStyleBackColor = true;
            this.horoscope.Click += new System.EventHandler(this.horoscope_Click);
            // 
            // timerHighlightBox
            // 
            this.timerHighlightBox.Interval = 20;
            this.timerHighlightBox.Tick += new System.EventHandler(this.timerPanelBox_Tick);
            // 
            // highlightBox
            // 
            this.highlightBox.BackColor = System.Drawing.Color.Gold;
            this.highlightBox.FlatAppearance.BorderSize = 0;
            this.highlightBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlightBox.Location = new System.Drawing.Point(228, 158);
            this.highlightBox.Name = "highlightBox";
            this.highlightBox.Size = new System.Drawing.Size(13, 89);
            this.highlightBox.TabIndex = 66;
            this.highlightBox.UseVisualStyleBackColor = false;
            this.highlightBox.Visible = false;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "-אין תיאור-"));
            this.descriptionTextBox.Location = new System.Drawing.Point(198, 47);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(257, 30);
            this.descriptionTextBox.TabIndex = 58;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(194, 15);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(261, 23);
            this.nameLabel1.TabIndex = 59;
            this.nameLabel1.Text = "label1";
            // 
            // panelAlbumDescriptionsChanger
            // 
            this.panelAlbumDescriptionsChanger.Controls.Add(this.descriptionTextBox);
            this.panelAlbumDescriptionsChanger.Controls.Add(nameLabel);
            this.panelAlbumDescriptionsChanger.Controls.Add(descriptionLabel);
            this.panelAlbumDescriptionsChanger.Controls.Add(this.nameLabel1);
            this.panelAlbumDescriptionsChanger.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.panelAlbumDescriptionsChanger.Location = new System.Drawing.Point(248, 499);
            this.panelAlbumDescriptionsChanger.Name = "panelAlbumDescriptionsChanger";
            this.panelAlbumDescriptionsChanger.Size = new System.Drawing.Size(520, 83);
            this.panelAlbumDescriptionsChanger.TabIndex = 60;
            this.panelAlbumDescriptionsChanger.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(770, 643);
            this.Controls.Add(this.panelAlbumDescriptionsChanger);
            this.Controls.Add(this.highlightBox);
            this.Controls.Add(this.birthdayPanel);
            this.Controls.Add(this.postPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.displayPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Facebook";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.postPanel.ResumeLayout(false);
            this.postPanel.PerformLayout();
            this.displayPanel.ResumeLayout(false);
            this.displayPanel.PerformLayout();
            this.filterByPanel.ResumeLayout(false);
            this.filterByPanel.PerformLayout();
            this.sidebarPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.birthdayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.panelAlbumDescriptionsChanger.ResumeLayout(false);
            this.panelAlbumDescriptionsChanger.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel postPanel;
        private System.Windows.Forms.Label recentPosts;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Label titleOptionPicked;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button likedPages;
        private System.Windows.Forms.Button favoriteTeams;
        private System.Windows.Forms.Button albums;
        private System.Windows.Forms.Button groups;
        private System.Windows.Forms.Button events;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label dotOnlineOrOffline;
        private System.Windows.Forms.Label nameLoggedInUser;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel birthdayPanel;
        private System.Windows.Forms.Timer timerHighlightBox;
        private System.Windows.Forms.Button highlightBox;
        private System.Windows.Forms.Button horoscope;
        private System.Windows.Forms.Button birthday;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Panel panelAlbumDescriptionsChanger;
        private System.Windows.Forms.CheckedListBox NumberOptionPicker;
        private System.Windows.Forms.CheckedListBox FilterByOptionPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel filterByPanel;
        private System.Windows.Forms.Button buttonFilter;
        private ColorChangerNotifier colorChangerNotifierButton;
    }
}