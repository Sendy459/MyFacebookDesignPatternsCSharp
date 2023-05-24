using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Engine;
using FacebookWrapper.ObjectModel;

namespace UI
{
    public partial class FormMain : Form
    {
        private readonly Facade r_Facade = Facade.GetInstance;
        private bool m_IsEnteringAnAlbumPhotos = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            r_Facade.Login();
            if (r_Facade.CheckIfUserLogged())
            {
                new Thread(applyOnlineStatus).Start();
                loadRecentPosts();
                albumBindingSource.DataSource = r_Facade.GetUserAlbums();
            }
        }

        private void loadBirthday()
        {
            titleOptionPicked.Text = "Your next birthday";
            Label label = new Label
            {
                Font = new Font("Century Gothic", 10),
                Text = r_Facade.GetBirthdayLabelText(),
                Top = titleOptionPicked.Bottom + 15,
                Left = 35,
                ForeColor = Color.Gold,
                AutoSize = true,
                Name = "birthdayLabel"
            };
            displayPanel.Controls.Add(label);

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(150, 150),
                ImageLocation = @"happy-birthday.gif",
                SizeMode = PictureBoxSizeMode.StretchImage,
                Top = label.Bottom + 15,
                Left = (displayPanel.Width - 150) / 2
            };
            displayPanel.Controls.Add(pictureBox);
        }

        private void loadRecentPosts()
        {
            int numberOfPosts = 10;
            int offset = recentPosts.Bottom + 10;
            int counterPosts = 0;
            int i = 0;
            while (i < r_Facade.GetNumberOfUserPosts() && counterPosts != numberOfPosts)
            {
                if (r_Facade.GetPostMessage(i) != null)
                {
                    Label timePosted = new Label
                    {
                        Text = r_Facade.GetPostDate(i),
                        Top = offset,
                        Font = new Font("Century", 9)
                    };
                    timePosted.Left = (postPanel.Width / 2) - (timePosted.Width / 2);
                    timePosted.AutoSize = true;
                    timePosted.ForeColor = Color.Gold;
                    Label post = new Label
                    {
                        Text = r_Facade.GetPostMessage(i),
                        Top = timePosted.Bottom - 5
                    };
                    post.Left = post.Width;
                    post.Font = new Font("Century", 15);
                    post.AutoSize = true;
                    offset = post.Bottom + 35;
                    postPanel.Controls.Add(post);
                    postPanel.Controls.Add(timePosted);
                    counterPosts++;
                }

                i++;
            }

            postPanel.Controls.Add(new ScrollableControl());
        }

        private void applyOnlineStatus()
        {
            pictureBoxProfile.Invoke(new Action(() =>
            {
                pictureBoxProfile.Visible = true;
                pictureBoxProfile.Load(r_Facade.GetProfilePicture());
            }));

            nameLoggedInUser.Invoke(new Action(() =>
            {
                nameLoggedInUser.Text = r_Facade.GetNickname();
                nameLoggedInUser.MaximumSize = new Size(80, 0);
            }));

            dotOnlineOrOffline.ForeColor = Color.Green;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            r_Facade.LogOut();
            pictureBoxProfile.Visible = false;
            highlightBox.Visible = false;
            nameLoggedInUser.Text = "Offline";
            titleOptionPicked.Text = "Pick an option";
            dotOnlineOrOffline.ForeColor = Color.Red;
            clearAppData();
        }

        private void clearAppData()
        {
            IEnumerable<Panel> panels = this.Controls.OfType<Panel>();

            foreach (Panel panel in panels)
            {
                if (panel.Name != "sidebarPanel" && panel.Name != "loginPanel"
                    && panel.Name != "panelAlbumDescriptionsChanger")
                {
                    for (int i = panel.Controls.Count - 1; i >= 0; i--)
                    {
                        Control control = panel.Controls[i];
                        if (control.Name != "recentPosts" && control.Name != "titleOptionPicked"
                            && control.Name != "birthday" && control.Name != "horoscope")
                        {
                            panel.Controls.Remove(control);
                        }
                    }
                }
            }
        }

        private void printNoData()
        {
            Label emptyLabel = new Label
            {
                Font = new Font("Century", 12),
                AutoSize = true,
                Text = "No Data to show"
            };
            emptyLabel.Location = new Point(titleOptionPicked.Left - 25, (displayPanel.Height / 2) - (emptyLabel.Height / 2));
            displayPanel.Controls.Add(emptyLabel);
        }

        private void sideBarClickHandler<T>(string i_TitleOption, FacebookObjectCollection<T> i_Object, Button i_Button)
        {
            if (r_Facade.CheckIfUserLogged() == false)
            {
                MessageBox.Show("You must be logged in");
            }
            else
            {
                highlightBox.Top = i_Button.Top;
                highlightBox.Height = i_Button.Height;
                loadHighlightBoxAnimation();

                titleOptionPicked.Text = i_TitleOption;
                titleOptionPicked.Update();
                filterByPanel.Visible = false;

                if (i_Object == null || i_Object.Count == 0)
                {
                    clearDisplayPanel();
                    printNoData();
                }
                else
                {
                    InitColsGridPictureBoxes(i_Object);
                    if (i_Object is FacebookObjectCollection<Album>)
                    {
                        CreateLabelAlbumsAreClickable();
                    }
                }
            }
        }

        private void InitColsAndGridForIterator(IEnumerable<Album> i_Iterator)
        {
            FacebookObjectCollection<Album> albums = new FacebookObjectCollection<Album>();

            foreach (Album album in i_Iterator)
            {
                albums.Add(album);
            }

            InitColsGridPictureBoxes(albums);
        }

        private void CreateLabelAlbumsAreClickable()
        {
            Label infoClickableAlbums = new Label
            {
                Font = new Font("Century", 10),
                AutoSize = true,
                Text = "Click album to open it"
            };
            infoClickableAlbums.Top = titleOptionPicked.Top - infoClickableAlbums.Height - 5;
            infoClickableAlbums.Left = (displayPanel.Width / 2) - (infoClickableAlbums.Width / 2) - 45;
            displayPanel.Controls.Add(infoClickableAlbums);
        }

        private void loadHighlightBoxAnimation()
        {
            timerHighlightBox.Enabled = true;
            timerHighlightBox.Start();
            highlightBox.Visible = true;
            highlightBox.BackColor = Color.FromArgb(0, 255, 215, 0);
        }

        private void resetCheckedListBox(CheckedListBox i_CheckedListBox)
        {
            // Removing the last choice if existing, by square tick and then selectedIndex
            if (i_CheckedListBox.SelectedIndex != -1)
            {
                i_CheckedListBox.SetItemCheckState(i_CheckedListBox.SelectedIndex, CheckState.Unchecked);
                i_CheckedListBox.SetSelected(i_CheckedListBox.SelectedIndex, false);
            }
        }

        private void albums_Click(object sender, EventArgs e)
        {
            resetCheckedListBox(FilterByOptionPicker);
            resetCheckedListBox(NumberOptionPicker);
            FilterByOptionPicker.SetSelected((int)Enums.eFilterByOption.NO_FILTER, true); // Ticked by default

            sideBarClickHandler("Your Albums", r_Facade.GetUserAlbums(), albums);
            if (r_Facade.CheckIfUserLogged() == true)
            {
                filterByPanel.Visible = true;
            }
        }

        private void events_Click(object sender, EventArgs e)
        {
            sideBarClickHandler("Your Events", r_Facade.GetUserEvents(), events);
        }

        private void groups_Click(object sender, EventArgs e)
        {
            sideBarClickHandler("Your Groups", r_Facade.GetUserGroups(), groups);
        }

        private void favoriteTeams_Click(object sender, EventArgs e)
        {
            sideBarClickHandler("Your Favorite Teams", r_Facade.GetUserFavofriteTeams(), favoriteTeams);
        }

        private void likedPages_Click(object sender, EventArgs e)
        {
            sideBarClickHandler("Your Liked Pages", r_Facade.GetUserLikedPages(), likedPages);
        }

        private void loadPictureAndText(object i_Object, LazyPictureBox o_PictureBox, Label o_Label)
        {
            if (i_Object is Album)
            {
                o_PictureBox.Load((i_Object as Album).PictureAlbumURL);
                o_Label.Text = string.Format("{0} ({1})", (i_Object as Album).Name, (i_Object as Album).Photos.Count);
            }
            else if (i_Object is Page)
            {
                o_PictureBox.Load((i_Object as Page).PictureNormalURL);
                o_Label.Text = (i_Object as Page).Name;
            }
            else if (i_Object is Group)
            {
                o_PictureBox.Load((i_Object as Group).PictureNormalURL);
                o_Label.Text = (i_Object as Group).Name;
            }
            else if (i_Object is Event)
            {
                o_PictureBox.Load((i_Object as Event).PictureNormalURL);
                o_Label.Text = (i_Object as Event).Name;
            }
            else if (i_Object is Photo)
            {
                o_PictureBox.Load((i_Object as Photo).PictureNormalURL);
            }
        }

        private void clearDisplayPanel()
        {
            if (panelAlbumDescriptionsChanger.Visible == true)
            {
                if (m_IsEnteringAnAlbumPhotos == false)
                {
                    displayPanel.Height += panelAlbumDescriptionsChanger.Height;
                    panelAlbumDescriptionsChanger.Visible = false;
                }
                else
                {
                    m_IsEnteringAnAlbumPhotos = false;
                }
            }

            for (int i = displayPanel.Controls.Count - 1; i >= 0; i--)
            {
                if (displayPanel.Controls[i].Name != panelAlbumDescriptionsChanger.Name
                   && displayPanel.Controls[i].Name != titleOptionPicked.Name
                   && displayPanel.Controls[i].Name != filterByPanel.Name)
                {
                    displayPanel.Controls.RemoveAt(i);
                }
            }
        }

        private void InitColsGridPictureBoxes<T>(FacebookObjectCollection<T> i_Object)
        {
            clearDisplayPanel();

            int cols = 3;
            int rows = (i_Object.Count % 3) == 0 ? (i_Object.Count / 3) : (i_Object.Count / 3) + 1;
            int offsetTop = i_Object is FacebookObjectCollection<Album> ? 
                titleOptionPicked.Bottom + 10 + filterByPanel.Height : titleOptionPicked.Bottom + 10;
            int offsetLeft = 5;
            int maximumLabelTopPerRow = 0;
            int counterSetup = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (counterSetup == i_Object.Count)
                    {
                        break;
                    }

                    LazyPictureBox pictureBox = new LazyPictureBox();
                    Label label = new Label();

                    pictureBox.Width = 120;
                    pictureBox.Height = 120;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    loadPictureAndText(i_Object[(cols * row) + col], pictureBox, label);
                    if (i_Object is FacebookObjectCollection<Album>)
                    {
                        makeAlbumsClickable(pictureBox, (cols * row) + col);
                    }

                    pictureBox.Top = offsetTop;
                    pictureBox.Left = offsetLeft;
                    displayPanel.Controls.Add(pictureBox);

                    label.Font = new Font("Century", 10);
                    label.MaximumSize = new Size(120, 0);
                    label.Top = pictureBox.Top + 120;
                    label.ForeColor = Color.White;
                    label.Left = offsetLeft;
                    label.AutoSize = true;
                    displayPanel.Controls.Add(label);

                    maximumLabelTopPerRow = Math.Max(maximumLabelTopPerRow, label.Bottom);
                    offsetLeft += 120 + 60;
                    counterSetup++;
                }

                offsetLeft = 10;
                offsetTop = maximumLabelTopPerRow + 20;
            }

            displayPanel.Controls.Add(new ScrollableControl());
            displayPanel.Refresh();
        }

        public class LazyPictureBox : PictureBox
        {
            public LazyPictureBox()
            {
                Image image = Image.FromFile(@"loading.png");
                this.InitialImage = new Bitmap(image, 120, 120);
            }

            public string URL { get; set; }

            public new void Load(string i_UrlToLoad)
            {
                URL = i_UrlToLoad;
            }

            protected override void OnPaint(PaintEventArgs pe)
            {
                if (ImageLocation == null)
                {
                    ImageLocation = this.URL;
                }

                base.OnPaint(pe);
            }
        }

        private void makeAlbumsClickable(PictureBox i_PictureBox, int i_Index)
        {
            i_PictureBox.Name = string.Format("picture{0}", i_Index);
            i_PictureBox.Click += albumPictureBox_Click;
            i_PictureBox.Cursor = Cursors.Hand;
        }

        private void albumPictureBox_Click(object sender, EventArgs e)
        {
            string picture = "picture";
            int index = int.Parse((sender as PictureBox).Name.Substring(picture.Length));
            IEnumerable<Album> iterator = getRelevantIterator(); // For getting the specific albums list based on iterator
            int numberOfPhotosInAlbum = r_Facade.GetNumberOfPhotosInAlbum(index, iterator);
            FacebookObjectCollection<Photo> res = new FacebookObjectCollection<Photo>(numberOfPhotosInAlbum);
            foreach (Photo photo in r_Facade.GetPhotosOfSpecificAlbumBasedOnFilter(index, iterator))
            {
                res.Add(photo);
                if (res.Count == numberOfPhotosInAlbum)
                {
                    break;
                }
            }

            displayPanel.Height -= panelAlbumDescriptionsChanger.Height;
            panelAlbumDescriptionsChanger.Visible = true;
            m_IsEnteringAnAlbumPhotos = true;
            filterByPanel.Visible = false;

            // Updating the data source according to the iterator
            albumBindingSource.DataSource = iterator; 

            // For Resetting to the first album
            albumBindingSource.MoveFirst();

            // Getting to the specific album we clicked
            for (int i = 0; i < index; i++)
            {
                albumBindingSource.MoveNext();
            }

            InitColsGridPictureBoxes(res);
        }

        private IEnumerable<Album> getRelevantIterator()
        {
            Enums.eFilterByOption? filterOptionPicked = getEnumOptionBasedOnIndex(FilterByOptionPicker.SelectedIndex);
            IEnumerable<Album> iterator;
            if (filterOptionPicked != null)
            {
                iterator = r_Facade.FilterBy(filterOptionPicked.Value, NumberOptionPicker.SelectedIndex + 1);
            }
            else
            {
                iterator = r_Facade.FilterBy(Enums.eFilterByOption.NO_FILTER);
            }

            return iterator;
        }

        private void timerPanelBox_Tick(object sender, EventArgs e)
        {
            if (highlightBox.BackColor.A < 255)
            {
                highlightBox.BackColor = Color.FromArgb(highlightBox.BackColor.A + 5, 255, 215, 0);
                highlightBox.Invalidate();
            }
            else
            {
                timerHighlightBox.Enabled = false;
                timerHighlightBox.Stop();
            }
        }

        private async void horoscope_Click(object sender, EventArgs e)
        {
            if (r_Facade.CheckIfUserLogged() == false)
            {
                MessageBox.Show("You must be logged in");
            }
            else
            {
                try
                {
                    await r_Facade.GetHoroscopeTask();
                    createHoroscopeLabels();
                }
                catch
                {
                    MessageBox.Show("Some error occured, horoscope isn't available at the moment");
                }

                if (displayPanel.Controls.Count >= 2 && displayPanel.Controls[1].Name != "zodiac")
                {
                    clearDisplayPanel();
                    highlightBox.Visible = false;
                    createHoroscopeLabels();
                }
            }
        }

        private void createHoroscopeLabels()
        {
            titleOptionPicked.Text = "Your Horoscope";
            Label myZodiacSign = getHoroscopeLabel(string.Format("Your zodiac sign is: {0}", r_Facade.GetZodiacSign()));
            myZodiacSign.Top = titleOptionPicked.Bottom + 15;
            myZodiacSign.Name = "zodiac";

            Label mood = getHoroscopeLabel(string.Format("Your mood is: {0}", r_Facade.GetHoroscope().Mood));
            mood.Top = myZodiacSign.Bottom + 15;

            Label description = getHoroscopeLabel(string.Format("Your daily horoscope is: {0}", r_Facade.GetHoroscope().Description));
            description.Top = mood.Bottom + 15;

            Label luckyNumber = getHoroscopeLabel(string.Format("Your lucky number is: {0}", r_Facade.GetHoroscope().Lucky_number));
            luckyNumber.Top = description.Bottom + 15;

            Label luckyTime = getHoroscopeLabel(string.Format("Your lucky time is: {0}", r_Facade.GetHoroscope().Lucky_time));
            luckyTime.Top = luckyNumber.Bottom + 15;
        }

        private Label getHoroscopeLabel(string i_Text)
        {
            Label label = new Label
            {
                Font = new Font("Century Gothic", 10),
                ForeColor = Color.Gold,
                Text = i_Text,
                MaximumSize = new Size(displayPanel.Width - 20, 0),
                AutoSize = true,
                Left = 10
            };
            displayPanel.Controls.Add(label);

            return label;
        }

        private void birthday_Click(object sender, EventArgs e)
        {
            if (r_Facade.CheckIfUserLogged() == false)
            {
                MessageBox.Show("You must be logged in");
            }
            else
            {
                if (displayPanel.Controls.Count == 1 || (displayPanel.Controls.Count >= 2 && displayPanel.Controls[1].Name != "birthdayLabel"))
                {
                    highlightBox.Visible = false;
                    clearDisplayPanel();
                    loadBirthday();
                }
            }
        }

        private void FilterByOptionPicker_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            enableOnlyOneItemChecked(FilterByOptionPicker, e, FilterByOptionPicker_ItemCheck);
        }

        private void NumberOptionPicker_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            enableOnlyOneItemChecked(NumberOptionPicker, e, NumberOptionPicker_ItemCheck);
        }

        private void enableOnlyOneItemChecked(CheckedListBox i_Sender, ItemCheckEventArgs e, ItemCheckEventHandler funcEvent)
        {
            if (e.NewValue == CheckState.Checked && i_Sender.CheckedItems.Count > 0)
            {
                i_Sender.ItemCheck -= funcEvent;
                i_Sender.SetItemChecked(i_Sender.CheckedIndices[0], false);
                i_Sender.ItemCheck += funcEvent;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FilterByOptionPicker.SetSelected(0, true); // Enable the first item in the checkListBox which is No Filter
            applyChangeColorDelegates();
        }

        private void applyChangeColorDelegates()
        {
            List<Control> controlsToChangeBackColor = new List<Control>()
                { 
                     colorChangerNotifierButton, buttonLogin, buttonLogout, buttonFilter, highlightBox 
                };

            foreach (Control control in controlsToChangeBackColor)
            {
                colorChangerNotifierButton.m_ReportColorChangeDelegates += (int color) => changeBackColor(color, control);
            }

            List<Control> controlsToChangeDifferentBackColor = new List<Control>()
                {
                 albums, likedPages, groups, favoriteTeams, events 
                };

            foreach (Control control in controlsToChangeDifferentBackColor)
            {
                colorChangerNotifierButton.m_ReportColorChangeDelegates += (int color) => changeBackColor((color + 1) % 4, control);
            }

            colorChangerNotifierButton.m_ReportColorChangeDelegates +=
               (int color) => { changeForeColor(color, recentPosts); };

            colorChangerNotifierButton.m_ReportColorChangeDelegates +=
               (int color) => { changeForeColor(color, titleOptionPicked); };
        }

        private void changeForeColor(int color, Control i_Control)
        {
            switch (color)
            {
                case 1:
                    i_Control.ForeColor = Color.Gold;
                    break;
                case 2:
                    i_Control.ForeColor = Color.MediumPurple;
                    break;
                case 3:
                    i_Control.ForeColor = Color.Coral;
                    break;
                case 4:
                    i_Control.ForeColor = Color.AliceBlue;
                    break;
            }
        }

        private void changeBackColor(int color, Control i_Control)
        {
            switch (color)
            {
                case 1:
                    i_Control.BackColor = Color.Gold;
                    break;
                case 2:
                    i_Control.BackColor = Color.MediumPurple;
                    break;
                case 3:
                    i_Control.BackColor = Color.Coral;
                    break;
                case 4:
                    i_Control.BackColor = Color.AliceBlue;
                    break;
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Enums.eFilterByOption? filterOptionPicked = getEnumOptionBasedOnIndex(FilterByOptionPicker.SelectedIndex);
            if (filterOptionPicked == null)
            {
                MessageBox.Show("You must pick an option");
            } 
            else
            {
                IEnumerable<Album> iterator = r_Facade.FilterBy(filterOptionPicked.Value, NumberOptionPicker.SelectedIndex + 1);
                InitColsAndGridForIterator(iterator);
            }
        }

        private Enums.eFilterByOption? getEnumOptionBasedOnIndex(int i_SelectedIndex)
        {
            Enums.eFilterByOption? res = Enums.eFilterByOption.NO_FILTER;
            switch (i_SelectedIndex)
            {
                case (int)Enums.eFilterByOption.LESS_THAN:
                    res = Enums.eFilterByOption.LESS_THAN;
                    break;
                case (int)Enums.eFilterByOption.MORE_THAN:
                    res = Enums.eFilterByOption.MORE_THAN;
                    break;
            }

            // If none selected
            if (FilterByOptionPicker.SelectedIndex == -1 || NumberOptionPicker.SelectedIndex == -1)
            {
                res = null;
            }

            return res;
        }

        private void FilterByOptionPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterByOptionPicker.SelectedIndex != -1)
            {
                FilterByOptionPicker.SetItemChecked(FilterByOptionPicker.SelectedIndex, true);
                if (FilterByOptionPicker.SelectedIndex == (int)Enums.eFilterByOption.NO_FILTER)
                {
                    NumberOptionPicker.Enabled = false;
                }
                else
                {
                    NumberOptionPicker.Enabled = true;
                }
            }
        }

        private void NumberOptionPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NumberOptionPicker.SelectedIndex != -1)
            {
                NumberOptionPicker.SetItemChecked(NumberOptionPicker.SelectedIndex, true);
            }
        }
    }
}
