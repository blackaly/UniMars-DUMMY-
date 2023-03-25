using UniMars.Models.Domains;
using UniMars.Models.Enums;

namespace UniMars.Models.DTOs
{
    public class PostDTO
    {
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public int Likes { get; set; }
        public PostPrivacy PostPrivacy { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
