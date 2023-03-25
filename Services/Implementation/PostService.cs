using UniMars.Models;
using UniMars.Models.Domains;
using UniMars.Services.Interfaces;

namespace UniMars.Services.Implementation
{
    public class PostService : IPostService
    {
        private readonly ApplicationDbContext _context; 
        public PostService(ApplicationDbContext context)
        {
            _context= context;
        }
        public async Task<Post> CreatePost(Post post)
        {
            await _context.Posts.AddAsync(post);
            return post;
        }
    }
}
