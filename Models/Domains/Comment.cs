namespace UniMars.Models.Domains
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentContent { get; set; }
        public DateTime Time { get; set; }
        public int LikeCount { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;
        }
    }
}
