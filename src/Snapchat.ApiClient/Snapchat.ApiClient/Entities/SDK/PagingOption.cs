namespace Snapchat.ApiClient
{
    /// <summary>
    /// Represents API paging options.
    /// </summary>
    public class PagingOption
    {
        /// <summary>
        /// Gets or sets API page limit.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Gets or sets number of pages to be fetched from API.
        /// </summary>
        public int NumberOfPages { get; set; }
    }
}