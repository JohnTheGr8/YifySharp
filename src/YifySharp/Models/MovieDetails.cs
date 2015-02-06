using System;
using System.Collections.Generic;
using System.Linq;

namespace YifySharp.Models
{
    public class MovieDetails : MovieInfoBase
    {
        public string TitleLong { get; set; }
        public int DownloadCount { get; set; }
        public int LikeCount { get; set; }
        public int RtCriticsScore { get; set; }
        public string RtCritingsRating { get; set; }
        public int RtAudienceScore { get; set; }
        public string RtAudienceRating { get; set; }
        public string DescriptionIntro { get; set; }
        public string DescriptionFull { get; set; }
        public string YtTrailerCode { get; set; }
        public DateTime DateUploaded { get; set; }
        public int DateUploadedUnix { get; set; }
        public List<ImageInfo> Images { get; set; }

        public List<MovieDirector> Directors { get; set; }
        public List<MovieActor> Actors { get; set; }

        private List<TorrentInfo> _torrents = new List<TorrentInfo>();
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
        public string Name { get; set; }
        public string SmallImage { get; set; }
        public string MediumImage { get; set; }
    }

    public class MovieActor
    {
        public string Name { get; set; }
        public string CharacterName { get; set; }
        public string SmallImage { get; set; }
        public string MediumImage { get; set; }

    }
}