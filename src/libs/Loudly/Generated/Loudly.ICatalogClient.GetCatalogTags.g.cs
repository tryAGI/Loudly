#nullable enable

namespace Loudly
{
    public partial interface ICatalogClient
    {
        /// <summary>
        /// Fetch available tags<br/>
        /// Returns available tags (mood, genre, key) that can be used to filter catalog songs.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loudly.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loudly.CatalogTags> GetCatalogTagsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}