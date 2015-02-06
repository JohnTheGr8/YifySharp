using System.Collections.Generic;

namespace YifySharp.Models
{
    public class ParentalGuideInfo
    {
        public int ParentalGuideCount { get; set; }

        public List<ParentalGuide> ParentalGuides { get; set; }
    }

    public class ParentalGuide
    {
        /// <summary>
        /// Type of parental guide (violence, nudity etc)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Guide description
        /// </summary>
        public string ParentalGuideText { get; set; }
    }
}