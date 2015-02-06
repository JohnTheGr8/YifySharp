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
        /// <summary>
        /// Username of reviewer
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// User's rating of the movie
        /// </summary>
        public int UserRating { get; set; }

        /// <summary>
        /// Reviewer's location
        /// </summary>
        public string UserLocation { get; set; }

        /// <summary>
        /// A summary of the user's review
        /// </summary>
        public string ReviewSummary { get; set; }

        /// <summary>
        /// User's review text
        /// </summary>
        public string ReviewText { get; set; }
        
        /// <summary>
        /// The date this review was submitted
        /// </summary>
        public DateTime DateWritten { get; set; }

        /// <summary>
        /// The date this review was submitted, in epoch format
        /// </summary>
        public int DateWrittenUnix { get; set; }
    }
}