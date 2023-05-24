using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Engine
{
    internal class RemoteAPI : ICache
    {
        private Horoscope m_UpdatedHoroscope;

        public Task<Horoscope> GetHoroscope()
        {
            Task<Horoscope> res = Task.FromResult(m_UpdatedHoroscope);
            return res;
        }

        public async Task SetHoroscope()
        {
            if (AppEngine.GetEngine.LoggedInUser != null)
            {
                string url = string.Format("https://aztro.sameerkumar.website/?sign={0}&day={1}", AppEngine.GetEngine.GetZodiacSign(), "today");
                using (HttpClient httpClient = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await httpClient.PostAsync(url, null);
                        response.EnsureSuccessStatusCode();
                        string jsonString = await response.Content.ReadAsStringAsync();
                        JsonSerializer serializer = new JsonSerializer();
                        m_UpdatedHoroscope = JsonConvert.DeserializeObject<Horoscope>(jsonString);
                    }
                    catch (Exception ex)
                    {
                        m_UpdatedHoroscope = null;
                        throw new Exception();
                    }
                }
            }
        }
        
        public void Reset()
        {
            m_UpdatedHoroscope = null;
        }
    }
}
