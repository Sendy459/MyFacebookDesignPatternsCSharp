using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Engine
{
    internal interface IStrategyIterator
    {
        bool ShouldBeInIterator(Album i_Album, int i_NumberOfPhotos);
    }
}