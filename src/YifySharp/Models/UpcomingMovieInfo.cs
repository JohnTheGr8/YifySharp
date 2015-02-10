using System;

namespace YifySharp.Models
{
    public class UpcomingMovieInfo
    {
        /// <summary>
        /// Movie title, without release year
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Movie's release year
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Code of movie's imdb page
        /// </summary>
        public string ImdbCode { get; set; }

        /// <summary>
        /// Link to medium-sized cover image of movie
        /// </summary>
        public string MediumCoverImage { get; set; }

        /// <summary>
        /// The date the movie was added
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// The date the movie was added, in epoch format
        /// </summary>
        public int DateAddedUnix { get; set; }
    }
}
