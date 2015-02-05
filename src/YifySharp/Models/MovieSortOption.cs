using System.ComponentModel;

namespace YifySharp.Models
{
    public enum MovieSortOption
    {
        /// <summary>
        /// Sort by movie title
        /// </summary>
        [Description("title")]
        Title,
        /// <summary>
        /// Sort by release year
        /// </summary>
        [Description("year")]
        Year,
        /// <summary>
        /// Sort by movie rating
        /// </summary>
        [Description("rating")]
        Rating,
        /// <summary>
        /// Sort by torrent peers
        /// </summary>
        [Description("peers")]
        Peers,
        /// <summary>
        /// Sort by torrent seeds
        /// </summary>
        [Description("seeds")]
        Seeds,
        /// <summary>
        /// Sort by movie downloads
        /// </summary>
        [Description("downloaded_count")]
        DownloadedCount,
        /// <summary>
        /// Sort by movie likes
        /// </summary>
        [Description("like_count")]
        LikeCount,
        /// <summary>
        /// Sort by date added to YIFY
        /// </summary>
        [Description("date_added")]
        DateAdded
    }
}
