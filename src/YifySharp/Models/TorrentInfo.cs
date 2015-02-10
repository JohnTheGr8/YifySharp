using System;
using RestSharp.Contrib;

namespace YifySharp.Models
{
    public class TorrentInfo
    {
        /// <summary>
        /// Link to the .torrent file
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Torrent's hash
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// Movie quality, will either be 720p, 1080p or 3D
        /// </summary>
        public string Quality { get; set; }

        /// <summary>
        /// The resolution of the movie in format W*H
        /// </summary>
        public string Resolution { get; set; }

        /// <summary>
        /// The framerate (FPS) of the movie
        /// </summary>
        public double FrameRate { get; set; }

        /// <summary>
        /// Number of seeders for this torrent
        /// </summary>
        public int Seeds { get; set; }

        /// <summary>
        /// Number of leechers for this torrent
        /// </summary>
        public int Peers { get; set; }

        /// <summary>
        /// Torrent size in string format
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// Torrent size in bytes
        /// </summary>
        public int SizeBytes { get; set; }

        /// <summary>
        /// Movie's download count
        /// </summary>
        public int DownloadCount { get; set; }

        /// <summary>
        /// The date this torrent was uploaded
        /// </summary>
        public DateTime DateUploaded { get; set; }

        /// <summary>
        /// The date this torrent was uploaded, in epoch format
        /// </summary>
        public int DateUploadedUnix { get; set; }

        /// <summary>
        /// movie title, used to construct the magnet url
        /// </summary>
        internal string MovieTitle;

        /// <summary>
        /// Constructs and returns a magnet url for this torrent
        /// </summary>
        public string MagnetUrl
        {
            get
            {
                const string format = "magnet:?xt=urn:btih:{0}&dn={1}&tr={2}";
                // Use recommended trackers
                var trackers = new[]
                    {
                        "udp://open.demonii.com:1337", "udp://tracker.istole.it:80",
                        "http://tracker.yify-torrents.com/announce", "udp://tracker.publicbt.com:80",
                        "udp://tracker.openbittorrent.com:80", "udp://tracker.coppersurfer.tk:6969",
                        "udp://exodus.desync.com:6969", "http://exodus.desync.com:6969/announce"
                    };
                var trackerData = string.Join("&tr=", trackers);
                // Constrcut torrent name and encode it
                var movieTitle = string.Format("{0} [{1}]", MovieTitle, Quality);
                var urlEncodedMovie = HttpUtility.UrlEncode(movieTitle);                
                // Construct magnet url and return
                return string.Format(format, Hash, urlEncodedMovie, trackerData);
            }
        }
    }
}
