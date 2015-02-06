using System.Collections.Generic;

namespace YifySharp.Models
{
    public class MovieInfoBase
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string ImdbCode { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public double Rating { get; set; }
        public int Runtime { get; set; }
        public List<string> Genres { get; set; }
        public string Language { get; set; }
        public string MpaRating { get; set; }

        public string ImdbPage
        {
            get
            {
                return string.Format("http://www.imdb.com/title/{0}/", ImdbCode);
            }
        }
    }
}
