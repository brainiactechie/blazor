using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using SecondServer.models;
using SecondServer.Services;

namespace SecondServer.Pages.Quran.SurahList
{
    public class SurahListBase : ComponentBase
    {
        public IEnumerable<ListViewModel> Surahs { get; set; }
        [Inject]
        public IQuranData quranService { get; set; }    
        protected override async Task OnInitializedAsync(){
            Surahs = await quranService.GetSurahs();
        }
    }
}