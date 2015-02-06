namespace YifySharp.Models
{
    public class ImageInfo
    {
        /// <summary>
        /// A background image for the movie
        /// </summary>
        public string BackgroundImage { get; set; }

        /// <summary>
        /// The movie's cover image in small size
        /// </summary>
        public string SmallCoverImage { get; set; }

        /// <summary>
        /// The movie's cover image in medium size
        /// </summary>
        public string MediumCoverImage { get; set; }

        /// <summary>
        /// The movie's cover image in large size
        /// </summary>
        public string LargeCoverImage { get; set; }

        /// <summary>
        /// A screenshot of the movie in medium size
        /// </summary>
        public string MediumScreenshotImage1 { get; set; }

        /// <summary>
        /// A second screenshot of the movie in medium size
        /// </summary>
        public string MediumScreenshotImage2 { get; set; }

        /// <summary>
        /// A third screenshot of the movie in medium size
        /// </summary>
        public string MediumScreenshotImage3 { get; set; }

        /// <summary>
        /// A screenshot of the movie in large size
        /// </summary>
        public string LargeScreenshotImage1 { get; set; }

        /// <summary>
        /// A second screenshot of the movie in large size
        /// </summary>
        public string LargeScreenshotImage2 { get; set; }

        /// <summary>
        /// A third screenshot of the movie in large size
        /// </summary>
        public string LargeScreenshotImage3 { get; set; }
    }
}