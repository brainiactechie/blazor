using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using SecondServer.models;

namespace SecondServer.Data.PostsService
{
    public class PostsService : IPostsData
    {
        private readonly HttpClient http;

        public PostsService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {
             var url = "https://jsonplaceholder.typicode.com/posts";
                return await JsonSerializer.DeserializeAsync<IEnumerable<Post>>(await http.GetStreamAsync(url),new JsonSerializerOptions(){PropertyNameCaseInsensitive =true});
        }

        public async Task<Post> PostDeatils(int id)
        {
            var url = "https://jsonplaceholder.typicode.com/posts/"+id;
            return await JsonSerializer.DeserializeAsync<Post>(await http.GetStreamAsync(url) , new JsonSerializerOptions(){PropertyNameCaseInsensitive = true});
        }
    }
}