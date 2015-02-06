using System.Collections.Generic;

namespace YifySharp.Models
{
    public class MovieDetails : MovieInfoBase
    {
        /// <summary>
        /// Movie download count
        /// </summary>
        public int DownloadCount { get; set; }

        /// <summary>
        /// Movie like count
        /// </summary>
        public int LikeCount { get; set; }
        
        /// <summary>
        /// Movie's critics score on RottenTomatoes
        /// </summary>
        public int RtCriticsScore { get; set; }

        /// <summary>
        /// Movie's critics rating on RottenTomatoes
        /// </summary>
        public string RtCriticsRating { get; set; }

        /// <summary>
        /// Movie's audience score on RottenTomatoes
        /// </summary>
        public int RtAudienceScore { get; set; }

        /// <summary>
        /// Movie's audience rating on RottenTomatoes
        /// </summary>
        public string RtAudienceRating { get; set; }

        /// <summary>
        /// Short movie description
        /// </summary>
        public string DescriptionIntro { get; set; }

        /// <summary>
        /// Full movie description
        /// </summary>
        public string DescriptionFull { get; set; }

        /// <summary>
        /// YouTube Code to movie's trailer
        /// </summary>
        public string YtTrailerCode { get; set; }

        /// <summary>
        /// List of movie-related artwork
        /// </summary>
        public List<ImageInfo> Images { get; set; }

        /// <summary>
        /// List of movie's directors
        /// </summary>
        public List<MovieDirector> Directors { get; set; }

        /// <summary>
        /// List of movie cast
        /// </summary>
        public List<MovieActor> Actors { get; set; }

        /// <summary>
        /// Get link to the movie's trailer on YouTube
        /// </summary>
        public string YoutubeTrailerLink
        {
            get
            {
                return string.Format("https://www.youtube.com/watch?v={0}", YtTrailerCode);
            }
        }
    }

    public class MovieDirector
    {
        /// <summary>
        /// Director's full name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Link to small-sized image of director
        /// </summary>
        public string SmallImage { get; set; }

        /// <summary>
        /// Link to medium-sized image of director
        /// </summary>
        public string MediumImage { get; set; }
    }

    public class MovieActor
    {
        /// <summary>
        /// Actor's full name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The name of the character played by the actor
        /// </summary>
        public string CharacterName { get; set; }

        /// <summary>
        /// Link to small-sized image of actor
        /// </summary>
        public string SmallImage { get; set; }

        /// <summary>
        /// Link to medium-sized image of actor
        /// </summary>
        public string MediumImage { get; set; }

    }
}