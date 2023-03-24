namespace UniMars.Models.Domains
{
    public class Post
    {
        public int PostId { get; set; }
        public string Contest { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Time { get; set; }
        public int Likes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
