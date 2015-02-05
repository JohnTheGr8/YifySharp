namespace YifySharp
{
    public class YifyResponse<T>
    {
        public string Status { get; set; }

        public string StatusMessage { get; set; }

        public T Data { get; set; }
    }
}