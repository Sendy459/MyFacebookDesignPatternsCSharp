using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Engine
{
    internal sealed class AppEngine
    {
        private static readonly AppEngine sr_Instance = new AppEngine();
        private readonly ICache r_CacheProxy = new CacheProxy();
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;

        public static AppEngine GetEngine
        {
            get
            {
                return sr_Instance;
            }
        }

        public ICache CacheProxy
        {
            get
            {
                return r_CacheProxy;
            }
        }

        private AppEngine()
        {
        }

        public User LoggedInUser
        {
            get { return m_LoggedInUser; }
        }

        public void Login()
        {
            m_LoginResult = FacebookService.Login(
                    "417742883669658",
                    "email",
                    "public_profile",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts");
            m_LoggedInUser = m_LoginResult.LoggedInUser;
        }

        public string GetZodiacSign()
        {
            string[] date = m_LoggedInUser.Birthday.Split('/');
            DateTime birthday = new DateTime(int.Parse(date[2]), int.Parse(date[0]), int.Parse(date[1]));
            int date_number = (birthday.Month * 100) + birthday.Day;
            string res = string.Empty;

            string[] zodiacs = new string[]
            {
                "capricorn", "aquarius", "pisces", "ares", "taurus",
                "gemini", "cancer", "leo", "virgo", "libra", "scorpio", "sagittarius"
            };
            int[] zodiacTimes = new int[] { 0, 120, 220, 321, 420, 521, 621, 723, 823, 923, 1023, 1122 };

            if (date_number >= 1023)
            {
                res = "sagittarius";
            }
            else
            {
                for (int i = 1; i < zodiacs.Length; i++)
                {
                    if (date_number >= zodiacTimes[i - 1] && date_number < zodiacTimes[i])
                    {
                        res = zodiacs[i - 1];
                        break;
                    }
                }
            }

            return res;
        }

        private DateTime GetBirthday()
        {
            string[] date = m_LoggedInUser.Birthday.Split('/');

            return new DateTime(int.Parse(date[2]), int.Parse(date[0]), int.Parse(date[1]));
        }

        public DateTime GetClosestBirthday()
        {
            DateTime i_Birthday = GetBirthday();
            DateTime timeNow = DateTime.Now;
            int yearClosestBirthday = timeNow.Year;
            if (timeNow.Month < i_Birthday.Month)
            {
                yearClosestBirthday = timeNow.Year;
            }
            else if (timeNow.Month == i_Birthday.Month)
            {
                if (timeNow.Day <= i_Birthday.Day)
                {
                    yearClosestBirthday = timeNow.Year;
                }
                else
                {
                    yearClosestBirthday = timeNow.Year + 1;
                }
            }
            else if (timeNow.Month > i_Birthday.Month)
            {
                yearClosestBirthday = timeNow.Year + 1;
            }

            return new DateTime(yearClosestBirthday, i_Birthday.Month, i_Birthday.Day);
        }

        public int GetNextAge()
        {
            return GetClosestBirthday().Year - GetBirthday().Year;
        }

        public TimeSpan CalculateDaysDifference()
        {
            return GetClosestBirthday().Subtract(DateTime.Now);
        }

        public void LogOut()
        {
            FacebookService.LogoutWithUI();
            m_LoggedInUser = null;
        }

        public FacebookObjectCollection<Page> ConvertFacebookPagesArrToList()
        {
            FacebookObjectCollection<Page> fbPages = null;

            if (m_LoggedInUser != null && m_LoggedInUser.FavofriteTeams != null)
            {
                Page[] pages = m_LoggedInUser.FavofriteTeams;
                fbPages = new FacebookObjectCollection<Page>(pages.Count());
                foreach (Page page in pages)
                {
                    fbPages.Add(page);
                }
            }

            return fbPages;
        }

        public IEnumerable<Album> FilterBy(Enums.eFilterByOption i_FilterByOption, int i_NumberOfPhotos = 0) 
        {
            switch (i_FilterByOption)
            {
                case Enums.eFilterByOption.NO_FILTER:
                    FilterIterator.Instance.StrategyIterator = new StrategyImplementation.DefaultItarator();
                    break;
                case Enums.eFilterByOption.LESS_THAN:
                    FilterIterator.Instance.StrategyIterator = new StrategyImplementation.LessThanXPhotos();
                    break;
                case Enums.eFilterByOption.MORE_THAN:
                    FilterIterator.Instance.StrategyIterator = new StrategyImplementation.MoreThanXPhotos();
                    break;
            }

            FilterIterator.Instance.UpdateNumberOfPhotos(i_NumberOfPhotos);
           
            return FilterIterator.Instance.Filter(m_LoggedInUser.Albums);
        }
    }
}