using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;


namespace Engine
{
    internal class StrategyImplementation
    {
        public class LessThanXPhotos : IStrategyIterator
        {
            public bool ShouldBeInIterator(Album i_Album, int i_NumberOfPhotos)
            {
                bool res = false;
                if (i_Album.Photos.Count <= i_NumberOfPhotos)
                {
                    res = true;
                }

                return res;
            }
        }

        public class MoreThanXPhotos : IStrategyIterator
        {
            public bool ShouldBeInIterator(Album i_Album, int i_NumberOfPhotos)
            {
                bool res = false;
                if (i_Album.Photos.Count > i_NumberOfPhotos)
                {
                    res = true;
                }

                return res;
            }
        }

        public class DefaultItarator : IStrategyIterator
        {
            public bool ShouldBeInIterator(Album i_Album, int i_NumberOfPhotos)
            {
                return true;
            }
        }
    }
}
