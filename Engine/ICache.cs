using System;
using System.Threading.Tasks;

namespace Engine
{
    public interface ICache
    {
        Task<Horoscope> GetHoroscope();

        Task SetHoroscope();

        void Reset();
    }
}
