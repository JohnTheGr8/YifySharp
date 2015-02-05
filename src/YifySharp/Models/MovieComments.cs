using System;
using System.Collections.Generic;

namespace YifySharp.Models
{
    public class MovieComments
    {
        public int CommentCount { get; set; }

        public List<CommentInfo> Comments { get; set; }
    }

    public class CommentInfo
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string UserProfileUrl { get; set; }
        public string SmallUserAvatarImage { get; set; }
        public string MediumUserAvatarImage { get; set; }
        public string UserGroup { get; set; }
        public int LikeCount { get; set; }
        public string CommentText { get; set; }
        public DateTime DateAdded { get; set; }
        public int DateAddedUnix { get; set; }
    }
}