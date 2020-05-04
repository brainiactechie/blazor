using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using SecondServer.models;

namespace SecondServer.Services
{
    public class QuranService : IQuranData
    {
        private readonly HttpClient http;

        public QuranService(HttpClient http)
        {
            this.http = http;
        }
        public Task<IEnumerable<LocalityType>> GetLocalities()
        {

            throw new System.NotImplementedException();

        }

        public Task<LocalityType> GetLocality(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Surah> GetSurah(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<ListViewModel>> GetSurahs()
        {
            
            // var surahs = await http.GetStreamAsync(url);
            // var json = await JsonSerializer.DeserializeAsync<IEnumerable<ListViewModel>>(surahs,new JsonSerializerOptions(){PropertyNameCaseInsensitive = true});
            // return json;
            return await JsonSerializer.DeserializeAsync<IEnumerable<ListViewModel>>(await http.GetStreamAsync("quran/getall") , new JsonSerializerOptions(){PropertyNameCaseInsensitive =true});
        }
    }
}