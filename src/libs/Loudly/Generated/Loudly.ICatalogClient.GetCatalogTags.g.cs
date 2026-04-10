#nullable enable

namespace Loudly
{
    public partial interface ICatalogClient
    {
        /// <summary>
        /// Fetch available tags<br/>
        /// Returns available tags (mood, genre, key) that can be used to filter catalog songs.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loudly.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loudly.CatalogTags> GetCatalogTagsAsync(
            global::Loudly.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}