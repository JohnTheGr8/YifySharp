using System.Collections.Generic;

namespace YifySharp.Models
{
    public class UpcomingList
    {
        public int UpcomingMoviesCount { get; set; }

        public List<UpcomingMovieInfo> UpcomingMovies { get; set; }
    }
}