#nullable enable

namespace Loudly
{
    public partial interface IAiClient
    {
        /// <summary>
        /// Get a random text prompt<br/>
        /// Returns a random text prompt to inspire text-to-music generation<br/>
        /// using POST /b2b/ai/prompt/songs.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loudly.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loudly.RandomPrompt> GetRandomPromptAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}