using System.Collections.Generic;

namespace YifySharp.Models
{
    public class MovieList
    {
        public int MovieCount { get; set; }
        public int Limit { get; set; }
        public int PageNumber { get; set; }

        public List<MovieInfo> Movies { get; set; }
    }
}