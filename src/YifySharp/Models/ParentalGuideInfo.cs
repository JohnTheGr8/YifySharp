using System.Collections.Generic;

namespace YifySharp.Models
{
    public class ParentalGuideInfo
    {
        public int ParentalGuideCount { get; set; }

        public List<Guide> ParentalGuides { get; set; }
    }

    public class Guide
    {
        public string Type { get; set; }
        public string ParentalGuideText { get; set; }
    }
}