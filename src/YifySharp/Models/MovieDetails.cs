using System;
using System.Collections.Generic;

namespace YifySharp.Models
{
    public class MovieDetails
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string ImdbCode { get; set; }
        public string Title { get; set; }
        public string TitleLong { get; set; }
        public int Year { get; set; }
        public double Rating { get; set; }
        public int Runtime { get; set; }
        public List<string> Genres { get; set; }
        public string Language { get; set; }
        public string MpaRating { get; set; }

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