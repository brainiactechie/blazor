using Microsoft.AspNetCore.Components;
using SecondServer.Data.PostsService;
using SecondServer.models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
namespace SecondServer.Pages.Components
{
    public class PostListBase : ComponentBase
    {
        public IEnumerable<Post> Posts { get; set; }
        [Inject]
        public IPostsData postService { get; set; }
        protected async override Task  OnInitializedAsync(){
            Posts = await postService.GetPosts();
        }

    }
}