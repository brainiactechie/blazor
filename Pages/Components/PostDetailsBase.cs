using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using SecondServer.models;
using SecondServer.Data.PostsService;
namespace SecondServer.Pages.Components
{
    public class PostDetailsBase : ComponentBase
    {
        public Post Post { get; set; }
        [Parameter]
        public string PostID { get; set; }
        [Inject]
        public IPostsData postService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Post = await postService.PostDeatils(int.Parse(PostID));
       }
    }
}