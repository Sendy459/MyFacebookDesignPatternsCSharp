using System;
using System.Threading.Tasks;

namespace Engine
{
    public class UpdatedHoroscope
    {
        private Horoscope m_MyHoroscope;
        private DateTime m_LastModified;

        public Horoscope MyHoroscope
        {
            get
            {
                if (DateTime.Now.Day != m_LastModified.Day)
                {
                    return null;
                }
                else
                {
                    return m_MyHoroscope;
                }
            }

            set
            {
                m_LastModified = DateTime.Now;
                m_MyHoroscope = value;
            }
        }
    }
}
