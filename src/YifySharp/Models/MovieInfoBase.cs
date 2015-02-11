using System;
using System.Collections.Generic;
using System.Linq;

namespace YifySharp.Models
{
    public class MovieInfoBase
    {
        /// <summary>
        /// Movie identifier number
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Link to the movie page on yts.re
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Code of movie's imdb page
        /// </summary>
        public string ImdbCode { get; set; }

        /// <summary>
        /// Movie title, without release year
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Movie title, including release year
        /// </summary>
        public string TitleLong { get; set; }

        /// <summary>
        /// Movie's release year
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Movie's rating on imdb
        /// </summary>
        public double Rating { get; set; }

        /// <summary>
        /// Movie's runtime in minutes
        /// </summary>
        public int Runtime { get; set; }

        /// <summary>
        /// List of movie genres
        /// </summary>
        public List<string> Genres { get; set; }

        /// <summary>
        /// Main language of the movie
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// The MPAA rating of the movie (PG-13, R etc)
        /// </summary>
        public string MpaRating { get; set; }

        /// <summary>
        /// Date uploaded to YIFY
        /// </summary>
        public DateTime DateUploaded { get; set; }

        /// <summary>
        /// Date uploaded to YIFY (in epoch format)
        /// </summary>
        public uint DateUploadedUnix { get; set; }

        /// <summary>
        /// Get link to the movie's imdb page
        /// </summary>
        public string ImdbPage
        {
            get
            {
                return string.Format("http://www.imdb.com/title/{0}/", ImdbCode);
            }
        }

        private List<TorrentInfo> _torrents = new List<TorrentInfo>();
        /// <summary>
        /// Returns a list of torrents for this movie, each in different quality
        /// </summary>
        public List<TorrentInfo> Torrents
        {
            get { return _torrents; }
            set
            {
                // When setting the torrent list, pass the Movie Title to each one
                _torrents = value;
                _torrents.ToList().ForEach(x => x.MovieTitle = TitleLong);
            }
        }
    }
}
