using System;

namespace YifySharp.Models
{
    public class UserDetails
    {
        /// <summary>
        /// User identification number
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User's username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// User's group name
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Link to user's page in yts.re
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// User's description text
        /// </summary>
        public string AboutText { get; set; }

        /// <summary>
        /// Link to small-sized avatar of user
        /// </summary>
        public string SmallAvatarImage { get; set; }

        /// <summary>
        /// Link to medium-sized avatar of user
        /// </summary>
        public string MediumAvatarImage { get; set; }

        /// <summary>
        /// The date the user registered
        /// </summary>
        public string DateJoined { get; set; }

        /// <summary>
        /// The date the user registered, in epoch format
        /// </summary>
        public int DateJoinedUnix { get; set; }

        /// <summary>
        /// The date the user was last seen online
        /// </summary>
        public DateTime DateLastSeen { get; set; }

        /// <summary>
        /// The date the user was last seen online, in epoch format
        /// </summary>
        public int DateLastSeenUnix { get; set; }
    }
}