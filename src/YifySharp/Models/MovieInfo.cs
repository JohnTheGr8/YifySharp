using System;
using System.Collections.Generic;

namespace YifySharp.Models
{
    public class MovieInfo
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

        public string SmallCoverImage { get; set; }
        public string MediumCoverImage { get; set; }
        public string State { get; set; }
        public List<Torrent> Torrents { get; set; }
        public DateTime DateUploaded { get; set; }
        public int DateUploadedUnix { get; set; }
    }

    public class Torrent
    {
        public string Url { get; set; }
        public string Hash { get; set; }
        public string Quality { get; set; }
        public int Seeds { get; set; }
        public int Peers { get; set; }
        public string Size { get; set; }
        public int SizeBytes { get; set; }
        public DateTime DateUploaded { get; set; }
        public int DateUploadedUnix { get; set; }
    }
}