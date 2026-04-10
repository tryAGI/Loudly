#nullable enable

namespace Loudly
{
    public partial interface ICatalogClient
    {
        /// <summary>
        /// Fetch catalog songs<br/>
        /// Retrieves songs from the catalog, optionally filtered by mood, genre, key, and paginated.
        /// </summary>
        /// <param name="mood"></param>
        /// <param name="genre"></param>
        /// <param name="key"></param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loudly.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loudly.CatalogSong>> GetCatalogSongsAsync(
            string? mood = default,
            string? genre = default,
            string? key = default,
            int? page = default,
            global::Loudly.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}