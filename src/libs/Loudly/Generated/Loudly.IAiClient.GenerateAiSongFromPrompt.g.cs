#nullable enable

namespace Loudly
{
    public partial interface IAiClient
    {
        /// <summary>
        /// Generate AI song (text prompt)<br/>
        /// Generates an AI song based on a text prompt. You can optionally specify duration.<br/>
        /// If the prompt includes a duration, it will be overwritten by the duration parameter<br/>
        /// if specified separately.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loudly.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loudly.AiSong> GenerateAiSongFromPromptAsync(

            global::Loudly.GenerateAiSongFromPromptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate AI song (text prompt)<br/>
        /// Generates an AI song based on a text prompt. You can optionally specify duration.<br/>
        /// If the prompt includes a duration, it will be overwritten by the duration parameter<br/>
        /// if specified separately.
        /// </summary>
        /// <param name="prompt">
        /// A text description of the desired song.
        /// </param>
        /// <param name="duration">
        /// Desired song duration in seconds (30-420). If the prompt includes a duration,<br/>
        /// it will be overwritten by this parameter.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loudly.AiSong> GenerateAiSongFromPromptAsync(
            string prompt,
            int? duration = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}