using System;
using RestSharp.Contrib;

namespace YifySharp.Models
{
    public class TorrentInfo
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

        internal string MovieTitle;

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
