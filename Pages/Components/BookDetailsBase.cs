using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using SecondServer.Data;
using Microsoft.EntityFrameworkCore;
namespace SecondServer.Pages.Components
{
    public class BookDetailsBase : ComponentBase
    {
        public Book Book { get; set; }
        public string Avilable { get; private set; }
        [Inject]
        public BookDbContext db { get; set; }
        [Parameter]
        public string BookId { get; set; }
        [Parameter]
        public string BookTitle { get; set; }
       
        protected override Task OnInitializedAsync()
        {
            Book = db.Book.Include("AuthorId").FirstOrDefault(b => b.BookId == int.Parse(BookId));
            Avilable =Book.Avaialbe ? "Yes Buy Now ? " : "Sorry Checkin Later ";
            return base.OnInitializedAsync();
        }

    }
}