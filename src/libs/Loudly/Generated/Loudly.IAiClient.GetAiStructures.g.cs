#nullable enable

namespace Loudly
{
    public partial interface IAiClient
    {
        /// <summary>
        /// Get available song structures<br/>
        /// Returns a list of available song structures that can be used when generating<br/>
        /// AI music with POST /b2b/ai/songs.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loudly.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loudly.AiStructure>> GetAiStructuresAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}