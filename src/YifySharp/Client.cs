using RestSharp;
using YifySharp.Models;
using YifySharp.Extensions;

namespace YifySharp
{
    public class YifyClient
    {
        private readonly string urlFormat = "https://yts.re/api/v2/{0}.json";

        public MovieList GetMovieList(int limit = 20, int page = 1, MovieQuality quality = MovieQuality.All, int? minimumRating = 0, string queryTerm = "0", 
            string genre = "All", MovieSortOption sortBy = MovieSortOption.DateAdded, MovieOrderOption orderBy = MovieOrderOption.Descending)
        {
            var request = new RestRequest(Method.GET);

            request.AddParameter("limit", limit);
            request.AddParameter("page", page);
            request.AddParameter("quality", quality.GetDescription());
            request.AddParameter("minimum_rating", minimumRating);
            request.AddParameter("query_term", queryTerm);
            request.AddParameter("genre", genre);
            request.AddParameter("sort_by", sortBy.GetDescription());
            request.AddParameter("order_by", orderBy.GetDescription());

            return Execute<MovieList>(request, "list_movies").Data;
        }

        public MovieDetails GetMovieDetails(int movieId, bool withImages = false, bool withCast = false)
        {
            var request = new RestRequest(Method.GET);

            request.AddParameter("movie_id", movieId);
            request.AddParameter("with_images", withImages.ToString());
            request.AddParameter("with_cast", "false");

            return Execute<MovieDetails>(request, "movie_details").Data;
        }

        public SuggestionList GetMovieSuggestions(int movieId)
        {
            var request = new RestRequest(Method.GET);

            request.AddParameter("movie_id", movieId);

            return Execute<SuggestionList>(request, "movie_suggestions").Data;
        }

        public MovieComments GetMovieComments(int movieId)
        {
            var request = new RestRequest(Method.GET);

            request.AddParameter("movie_id", movieId);

            return Execute<MovieComments>(request, "movie_comments").Data;
        }

        public MovieReviews GetReviews(int movieId)
        {
            var request = new RestRequest(Method.GET);

            request.AddParameter("movie_id", movieId);

            return Execute<MovieReviews>(request, "movie_reviews").Data;
        }

        public ParentalGuideInfo GetParentalGuides(int movieId)
        {
            var request = new RestRequest(Method.GET);

            request.AddParameter("movie_id", movieId);

            return Execute<ParentalGuideInfo>(request, "movie_parental_guides").Data;
        }

        public UpcomingList GetUpcomingList()
        {
            var request = new RestRequest(Method.GET);

            return Execute<UpcomingList>(request, "list_upcoming").Data;
        }

        public UserDetails GetUserDetails(int user_id)
        {
            var request = new RestRequest(Method.GET);

            request.AddParameter("user_id", user_id);

            return Execute<UserDetails>(request, "user_details").Data;
        }

        private YifyResponse<T> Execute<T>(RestRequest request, string requestEndpoint)
        {
            var baseUrl = string.Format(urlFormat, requestEndpoint);
            var client = new RestClient(baseUrl);

            var response = client.Execute<YifyResponse<T>>(request);

            return response.Data;
        }
    }
}