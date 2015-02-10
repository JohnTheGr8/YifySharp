namespace YifySharp
{
    public class YifyResponse<T>
    {
        /// <summary>
        /// The status of the API call, will be either 'ok' or 'error'
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The status message of the API call
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// The results returned from the query
        /// </summary>
        public T Data { get; set; }
    }
}