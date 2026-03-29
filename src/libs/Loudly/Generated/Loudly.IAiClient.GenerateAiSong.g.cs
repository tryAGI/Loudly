#nullable enable

namespace Loudly
{
    public partial interface IAiClient
    {
        /// <summary>
        /// Generate AI song (parameter-based)<br/>
        /// Generates an AI song based on provided parameters such as genre, genre_blend,<br/>
        /// duration, energy, bpm, key_root, key_quality, instruments, and structure_id.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loudly.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loudly.AiSong> GenerateAiSongAsync(

            global::Loudly.GenerateAiSongRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate AI song (parameter-based)<br/>
        /// Generates an AI song based on provided parameters such as genre, genre_blend,<br/>
        /// duration, energy, bpm, key_root, key_quality, instruments, and structure_id.
        /// </summary>
        /// <param name="genre">
        /// The main genre or subgenre. Use GET /b2b/ai/genres to see available genres and micro-genres.
        /// </param>
        /// <param name="genreBlend">
        /// A secondary genre to blend with the main genre. Use GET /b2b/ai/genres to see available genres.
        /// </param>
        /// <param name="duration">
        /// Desired song duration in seconds. Must be between 30 and 420.
        /// </param>
        /// <param name="energy">
        /// Energy level of the generated song.
        /// </param>
        /// <param name="bpm">
        /// Tempo in BPM. For optimal results, choose a value in the recommended range from GET /b2b/ai/genres.
        /// </param>
        /// <param name="keyRoot">
        /// The root note of the musical key.
        /// </param>
        /// <param name="keyQuality">
        /// The quality of the musical key.
        /// </param>
        /// <param name="instruments">
        /// A list of instruments to include. Available instruments depend on the selected genre<br/>
        /// and are found in GET /b2b/ai/genres. Instruments can be repeated for multiple instances.
        /// </param>
        /// <param name="structureId">
        /// Choose a structure from GET /b2b/ai/structures.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loudly.AiSong> GenerateAiSongAsync(
            string genre,
            string? genreBlend = default,
            int? duration = default,
            global::Loudly.GenerateAiSongRequestEnergy? energy = default,
            int? bpm = default,
            global::Loudly.GenerateAiSongRequestKeyRoot? keyRoot = default,
            global::Loudly.GenerateAiSongRequestKeyQuality? keyQuality = default,
            global::System.Collections.Generic.IList<string>? instruments = default,
            int? structureId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}