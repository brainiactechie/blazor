using System.Collections.Generic;
using System.Threading.Tasks;
using SecondServer.models;
namespace SecondServer.Services
{
    public interface IQuranData{
        Task<IEnumerable<ListViewModel>> GetSurahs();
        Task<Surah> GetSurah(int id);
        Task<LocalityType> GetLocality(int id);
        Task<IEnumerable<LocalityType>> GetLocalities();
    }
}