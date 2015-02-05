using System;
using System.Collections.Generic;

namespace YifySharp.Models
{
    public class MovieInfo : MovieInfoBase
    {
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