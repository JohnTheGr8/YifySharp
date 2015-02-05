using System;
using System.Collections.Generic;

namespace YifySharp.Models
{
    public class MovieDetails : MovieInfoBase
    {
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
        public List<Torrent> Torrents { get; set; }
        public List<MovieDirector> Directors { get; set; }
        public List<MovieActor> Actors { get; set; }
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