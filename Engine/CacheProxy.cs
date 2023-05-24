using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class CacheProxy : ICache
    {
        private RemoteAPI m_RemoteAPI = new RemoteAPI();
        private UpdatedHoroscope m_UpdatedHoroscope = new UpdatedHoroscope();

        public async Task<Horoscope> GetHoroscope()
        {
            if (m_UpdatedHoroscope.MyHoroscope == null)
            {
                await SetHoroscope();
            }

            return m_UpdatedHoroscope.MyHoroscope;
        }

        public async Task SetHoroscope()
        {
            await m_RemoteAPI.SetHoroscope();
            m_UpdatedHoroscope.MyHoroscope = await m_RemoteAPI.GetHoroscope();         
        }

        public void Reset()
        {
            m_RemoteAPI.Reset();
            m_UpdatedHoroscope.MyHoroscope = null;
        }
    }
}
