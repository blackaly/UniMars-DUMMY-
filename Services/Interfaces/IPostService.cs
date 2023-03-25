using UniMars.Models.Domains;

namespace UniMars.Services.Interfaces
{
    public interface IPostService
    {
        Task<Post> CreatePost(Post post);
    }
}
