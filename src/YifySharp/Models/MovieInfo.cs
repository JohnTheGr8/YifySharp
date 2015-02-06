using System;
using System.Collections.Generic;
using System.Linq;

namespace YifySharp.Models
{
    public class MovieInfo : MovieInfoBase
    {
        public string TitleLong { get; set; }
        public string SmallCoverImage { get; set; }
        public string MediumCoverImage { get; set; }
        public string State { get; set; }

        public DateTime DateUploaded { get; set; }
        public int DateUploadedUnix { get; set; }

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
    }
}