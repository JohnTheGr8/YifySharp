using System;

namespace YifySharp.Models
{
    public class UpcomingMovieInfo
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string ImdbCode { get; set; }
        public string MediumCoverImage { get; set; }
        public DateTime DateAddedd { get; set; }
        public int DateAddeddUnix { get; set; }
    }
}
