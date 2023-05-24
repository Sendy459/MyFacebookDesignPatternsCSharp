using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Engine
{
    public sealed class Facade
    {
        private static readonly Facade sr_Instance = new Facade();
        private readonly AppEngine r_AppEngine = AppEngine.GetEngine;

        private Facade() 
        {
        }
        
        public static Facade GetInstance
        {
            get
            {
                return sr_Instance;
            }
        }

        public string GetBirthdayLabelText()
        {
            string daysDifference = r_AppEngine.CalculateDaysDifference().ToString("%d");
            string nextAge = r_AppEngine.GetNextAge().ToString();

            return string.Format("{0} days remaining till your {1} birthday", daysDifference, nextAge);
        }

        public void Login()
        {
            r_AppEngine.Login();
        }

        public void LogOut()
        {
            r_AppEngine.LogOut();
            r_AppEngine.CacheProxy.Reset();
        }

        public bool CheckIfUserLogged()
        {
            return r_AppEngine.LoggedInUser != null;
        }

        public int GetNumberOfUserPosts()
        {
            return r_AppEngine.LoggedInUser.Posts.Count;
        }

        public int GetNumberOfUserAlbums()
        {
            return r_AppEngine.LoggedInUser.Albums.Count;
        }

        public FacebookObjectCollection<Photo> GetPhotosOfSpecificAlbumBasedOnFilter(int i_Index, IEnumerable<Album> i_FilteredAlbumsList)
        {
            return i_FilteredAlbumsList.ToList()[i_Index].Photos;
        }


        public int GetNumberOfPhotosInAlbum(int i_Index, IEnumerable<Album> i_FilteredAlbumsList)
        {
            return GetPhotosOfSpecificAlbumBasedOnFilter(i_Index, i_FilteredAlbumsList).Count;
        }

        public string GetPostMessage(int i_Index)
        {
            return r_AppEngine.LoggedInUser.Posts[i_Index].Message;
        }

        public string GetPostDate(int i_Index)
        {
            return r_AppEngine.LoggedInUser.Posts[i_Index].UpdateTime.Value.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public string GetProfilePicture()
        {
            return r_AppEngine.LoggedInUser.PictureNormalURL;
        }

        public string GetNickname()
        {
            return r_AppEngine.LoggedInUser.Name;
        }

        public FacebookObjectCollection<Album> GetUserAlbums()
        {
            return r_AppEngine.LoggedInUser?.Albums;
        }

        public FacebookObjectCollection<Event> GetUserEvents()
        {
            return r_AppEngine.LoggedInUser?.Events;
        }

        public FacebookObjectCollection<Group> GetUserGroups()
        {
            return r_AppEngine.LoggedInUser?.Groups;
        }

        public FacebookObjectCollection<Page> GetUserLikedPages()
        {
            return r_AppEngine.LoggedInUser?.LikedPages;
        }

        public FacebookObjectCollection<Page> GetUserFavofriteTeams()
        {
            return r_AppEngine.ConvertFacebookPagesArrToList();
        }

        public Task<Horoscope> GetHoroscopeTask()
        {
            return r_AppEngine.CacheProxy.GetHoroscope();
        }

        public Horoscope GetHoroscope()
        {
            return r_AppEngine.CacheProxy.GetHoroscope().Result;
        }

        public string GetZodiacSign()
        {
            return r_AppEngine.GetZodiacSign();
        }

        public IEnumerable<Album> FilterBy(Enums.eFilterByOption i_FilterByOption, int i_NumberOfPhotos = 0)
        {
            return r_AppEngine.FilterBy(i_FilterByOption, i_NumberOfPhotos);
        }
    }
}