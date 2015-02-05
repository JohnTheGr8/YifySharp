using RestSharp;

namespace YifySharp
{
    public class YifyClient
    {
        private readonly string urlFormat = "https://yts.re/api/v2/{0}.json";

        private YifyResponse<T> Execute<T>(RestRequest request, string requestEndpoint)
        {
            var baseUrl = string.Format(urlFormat, requestEndpoint);
            var client = new RestClient(baseUrl);

            var response = client.Execute<YifyResponse<T>>(request);

            return response.Data;
        }
    }
}