#nullable enable

namespace Loudly
{
    public partial interface IAiClient
    {
        /// <summary>
        /// Get available AI genres<br/>
        /// Returns a list of available genres for AI song generation. Each genre includes<br/>
        /// a description, an image URL, and suggested template names and instruments.<br/>
        /// This endpoint helps you choose values for POST /b2b/ai/songs.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loudly.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loudly.AiGenre>> GetAiGenresAsync(
            global::Loudly.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}