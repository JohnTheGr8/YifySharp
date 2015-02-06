using System.Collections.Generic;
using System.Linq;

namespace YifySharp.Models
{
    public class MovieInfo : MovieInfoBase
    {
        /// <summary>
        /// Url to a small cover image of the movie
        /// </summary>
        public string SmallCoverImage { get; set; }

        /// <summary>
        /// Url to a medium-sized cover image of the movie
        /// </summary>
        public string MediumCoverImage { get; set; }

        public string State { get; set; }
    }
}