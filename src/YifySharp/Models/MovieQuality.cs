using System.ComponentModel;

namespace YifySharp.Models
{
    public enum MovieQuality
    {
        /// <summary>
        /// Any quality
        /// </summary>
        [Description("All")]
        All,
        /// <summary>
        /// High-Definition 720p
        /// </summary>
        [Description("720p")]
        HD720p,
        /// <summary>
        /// Full High-Definition 1080p
        /// </summary>
        [Description("1080p")]
        FullHD1080p,
        /// <summary>
        /// 3D
        /// </summary>
        [Description("3D")]
        S3D,
    }
}
