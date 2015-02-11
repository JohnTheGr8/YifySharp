using System;
using RestSharp;
using YifySharp.Models;
using YifySharp.Extensions;

namespace YifySharp
{
    public class YifyClient
    {
        private readonly string urlFormat = "https://yts.re/api/v2/{0}.json";

        /// <summary>
        /// Returns a list of movies that match the given filters. If queryTerm is not set, a list of the latest torrents is returned.
        /// </summary>
        /// <param name="queryTerm">term used to search movies by title/actors/directors (or their corresponding IMDb code)</param>
        /// <param name="limit">number of results per page</param>
        public MovieList GetMovieList(string queryTerm = null, int limit = 20, int page = 1, MovieQuality quality = MovieQuality.All, int minimumRating = 0, 
            string genre = "All", MovieSortOption sortBy = MovieSortOption.DateAdded, MovieOrderOption orderBy = MovieOrderOption.Descending)
        {
            var request = new RestRequest(Method.GET);

            request.AddParameter("limit", limit);
            request.AddParameter("page", page);
            request.AddParameter("quality", quality.GetDescription());
            request.AddParameter("minimum_rating", minimumRating);
            request.AddParameter("query_term", queryTerm ?? "0");
            request.AddParameter("genre", genre);
            request.AddParameter("sort_by", sortBy.GetDescription());
            request.AddParameter("order_by", orderBy.GetDescription());

            return Execute<MovieList>(request, "list_movies").Data;
        }

        /// <summary>
        /// Returns information about the specified movie
        /// </summary>
        /// <param name="movieId">the movie's id to look up</param>
        /// <param name="withImages">if true, movie-related artwork will be included</param>
        /// <param name="withCast">if true, actor/director information will be included</param>
        public MovieDetails GetMovieDetails(uint movieId, bool withImages = false, bool withCast = false)
        {
            var request = new RestRequest(Method.GET);

            request.AddParameter("movie_id", movieId);
            if (withImages)
                request.AddParameter("with_images", "true");
            if(withCast)
                request.AddParameter("with_cast", "true");

            return Execute<MovieDetails>(request, "movie_details").Data;
        }

        /// <summary>
        /// Returns information about the specified movie
        /// </summary>
        /// <param name="movie">the movie to look up</param>
        /// <param name="withImages">if true, movie-related artwork will be included</param>
        /// <param name="withCast">if true, actor/director information will be included</param>
        public MovieDetails GetMovieDetails(MovieInfoBase movie, bool withImages = false, bool withCast = false)
        {
            return GetMovieDetails(movie.Id);
        }

        /// <summary>
        /// Returns a list of 4 movies related to the specified movie
        /// </summary>
        public SuggestionList GetMovieSuggestions(uint movieId)
        {
            var request = new RestRequest(Method.GET);

            request.AddParameter("movie_id", movieId);

            return Execute<SuggestionList>(request, "movie_suggestions").Data;
        }

        /// <summary>
        /// Returns a list of 4 movies related to the specified movie
        /// </summary>
        public SuggestionList GetMovieSuggestions(MovieInfoBase movie)
        {
            return GetMovieSuggestions(movie.Id);
        }

        /// <summary>
        /// Returns all the comments for the specified movie
        /// </summary>
        public MovieComments GetMovieComments(uint movieId)
        {
            var request = new RestRequest(Method.GET);

            request.AddParameter("movie_id", movieId);

            return Execute<MovieComments>(request, "movie_comments").Data;
        }

        /// <summary>
        /// Returns all the comments for the specified movie
        /// </summary>
        public MovieComments GetMovieComments(MovieInfoBase movie)
        {
            return GetMovieComments(movie.Id);
        }

        /// <summary>
        /// Returns all the IMDb movie reviews for the specified movie
        /// </summary>
        public MovieReviews GetReviews(uint movieId)
        {
            var request = new RestRequest(Method.GET);

            request.AddParameter("movie_id", movieId);

            return Execute<MovieReviews>(request, "movie_reviews").Data;
        }

        /// <summary>
        /// Returns all the IMDb movie reviews for the specified movie
        /// </summary>
        public MovieReviews GetReviews(MovieInfoBase movie)
        {
            return GetReviews(movie.Id);
        }

        /// <summary>
        /// Returns all the parental guide ratings for the specified movie
        /// </summary>
        public ParentalGuideInfo GetParentalGuides(uint movieId)
        {
            var request = new RestRequest(Method.GET);

            request.AddParameter("movie_id", movieId);

            return Execute<ParentalGuideInfo>(request, "movie_parental_guides").Data;
        }

        /// <summary>
        /// Returns all the parental guide ratings for the specified movie
        /// </summary>
        public ParentalGuideInfo GetParentalGuides(MovieInfoBase movie)
        {
            return GetParentalGuides(movie.Id);
        }

        /// <summary>
        /// Returns a list of movies that will soon be uploaded to yts.re
        /// </summary>
        public UpcomingList GetUpcomingList()
        {
            var request = new RestRequest(Method.GET);

            return Execute<UpcomingList>(request, "list_upcoming").Data;
        }

        /// <summary>
        /// Returns profile information for the specified user
        /// </summary>
        /// <param name="userId">The ID of the user to look up</param>
        public UserDetails GetUserDetails(uint userId)
        {
            var request = new RestRequest(Method.GET);

            request.AddParameter("user_id", userId);

            return Execute<UserDetails>(request, "user_details").Data;
        }

        /// <summary>
        /// Executes the request and returns the deserialized response data
        /// </summary>
        /// <typeparam name="T">the type used to deserialize the returned data</typeparam>
        /// <param name="request">the request to execute</param>
        /// <param name="requestEndpoint">the endpoint used to construct the base url for this request</param>
        private YifyResponse<T> Execute<T>(RestRequest request, string requestEndpoint)
        {
            var baseUrl = string.Format(urlFormat, requestEndpoint);
            var client = new RestClient(baseUrl);

            var response = client.Execute<YifyResponse<T>>(request);

            if (response.ErrorException != null)
                throw new ApplicationException(response.ErrorMessage, response.ErrorException);
            if (response.Data.Status == "error")
                throw new ApplicationException(response.Data.StatusMessage);

            return response.Data;
        }
    }
}