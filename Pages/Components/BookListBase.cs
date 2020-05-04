using Microsoft.AspNetCore.Components;
using SecondServer.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
namespace SecondServer.Pages.Components
{
    public class BookListBase : ComponentBase
    {
        public IEnumerable<Book> Books { get; set; }
        [Inject]
        public BookDbContext db { get; set; }
        protected override  Task OnInitializedAsync(){

                Books = db.Book.ToList();
                return base.OnInitializedAsync();
        }
        public string FriendlyUrl(string url){
            var parts = url.Trim().Split(" ");
            return string.Join("-",parts);
        }
    }
}