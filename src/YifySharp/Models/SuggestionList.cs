using System.Collections.Generic;

namespace YifySharp.Models
{
    public class SuggestionList
    {
        public int MovieSuggestionsCount { get; set; }

        public List<MovieInfo> MovieSuggestions { get; set; }
    }
}