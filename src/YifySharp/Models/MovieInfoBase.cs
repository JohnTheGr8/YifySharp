using System.Collections.Generic;

namespace YifySharp.Models
{
    public class MovieInfoBase
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
    }
}
