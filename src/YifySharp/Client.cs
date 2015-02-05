using RestSharp;
using YifySharp.Models;

namespace YifySharp
{
    public class YifyClient
    {
        private readonly string urlFormat = "https://yts.re/api/v2/{0}.json";

        public MovieList GetMovieList(int limit = 20, int page = 1, string quality = "All", int? minimum_rating = 0, string query_term = "0", string genre = "All", string sort_by = "date_added", string order_by = "desc")
        {
            var request = new RestRequest(Method.GET);

            request.AddParameter("limit", limit);
            request.AddParameter("page", page);
            request.AddParameter("quality", quality);
            request.AddParameter("minimum_rating", minimum_rating);
            request.AddParameter("query_term", query_term);
            request.AddParameter("genre", genre);
            request.AddParameter("sort_by", sort_by);
            request.AddParameter("order_by", order_by);

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