using System;
using System.Collections.Generic;

namespace YifySharp.Models
{
    public class MovieReviews
    {
        public int ReviewCount { get; set; }

        public List<MovieReview> Reviews { get; set; }
    }

    public class MovieReview
    {
        public string Username { get; set; }

        public int UserRating { get; set; }

        public string UserLocation { get; set; }

        public string ReviewText { get; set; }

        public DateTime DateWritten { get; set; }

        public int DateWrittenUnix { get; set; }
    }
}