﻿using UniMars.Models.Enums;

namespace UniMars.Models.Domains
{
    public class Post
    {
        public int PostId { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Time { get; set; }
        public int Likes { get; set; }
        public PostPrivacy PostPrivacy { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int CommentId { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
