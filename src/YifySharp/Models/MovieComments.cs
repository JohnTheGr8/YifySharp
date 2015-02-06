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
        /// <summary>
        /// The commenter's user id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The commenter's username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Link to the commenter's profile
        /// </summary>
        public string UserProfileUrl { get; set; }

        /// <summary>
        /// Link to the commenter's avatar in small size
        /// </summary>
        public string SmallUserAvatarImage { get; set; }

        /// <summary>
        /// Link to the commenter's avatar in medium size
        /// </summary>
        public string MediumUserAvatarImage { get; set; }

        /// <summary>
        /// The commenter's group name
        /// </summary>
        public string UserGroup { get; set; }

        /// <summary>
        /// Number of likes for this particular comment
        /// </summary>
        public int LikeCount { get; set; }

        /// <summary>
        /// The body of the comment
        /// </summary>
        public string CommentText { get; set; }

        /// <summary>
        /// The date this comment was submitted
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// The date this comment was submitted, in epoch format
        /// </summary>
        public int DateAddedUnix { get; set; }
    }
}