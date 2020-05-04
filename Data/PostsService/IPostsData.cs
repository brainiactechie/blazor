using System.Threading.Tasks;
using System.Collections.Generic;
using SecondServer.models;
namespace SecondServer.Data.PostsService
{
    public interface IPostsData{
        public Task<IEnumerable<Post>> GetPosts();
        public Task<Post> PostDeatils(int id);
    }
}