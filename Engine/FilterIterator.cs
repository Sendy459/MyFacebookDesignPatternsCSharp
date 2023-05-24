using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Engine
{
    internal sealed class FilterIterator
    {
        private static FilterIterator s_Instance = null;

        private FilterIterator() 
        {
        }

        public static FilterIterator Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    IStrategyIterator strategyIterator = new StrategyImplementation.DefaultItarator();
                    s_Instance = new FilterIterator();
                    s_Instance.StrategyIterator = strategyIterator;
                }

                return s_Instance;
            }
        }

        public IStrategyIterator StrategyIterator { get; set; }

        private int m_NumberOfPhotos;

        public IEnumerable<Album> Filter(FacebookObjectCollection<Album> i_Albums)
        {
            foreach (Album album in i_Albums)
            {
                if (StrategyIterator.ShouldBeInIterator(album, m_NumberOfPhotos))
                {
                    yield return album;
                }
            }
        }

        public void UpdateNumberOfPhotos(int i_NumberOfPhotos)
        {
            m_NumberOfPhotos = i_NumberOfPhotos;
        }
    }
}
