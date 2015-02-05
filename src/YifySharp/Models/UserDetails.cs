using System;

namespace YifySharp.Models
{
    public class UserDetails
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Group { get; set; }
        public string Url { get; set; }
        public string AboutText { get; set; }
        public string SmallAvatarImage { get; set; }
        public string MediumAvatarImage { get; set; }
        public string DateJoined { get; set; }
        public int DateJoinedUnix { get; set; }
        public DateTime DateLastSeen { get; set; }
        public int DateLastSeenUnix { get; set; }
    }
}