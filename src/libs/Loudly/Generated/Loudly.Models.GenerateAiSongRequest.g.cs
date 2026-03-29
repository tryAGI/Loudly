
#nullable enable

namespace Loudly
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateAiSongRequest
    {
        /// <summary>
        /// The main genre or subgenre. Use GET /b2b/ai/genres to see available genres and micro-genres.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genre")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Genre { get; set; }

        /// <summary>
        /// A secondary genre to blend with the main genre. Use GET /b2b/ai/genres to see available genres.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genre_blend")]
        public string? GenreBlend { get; set; }

        /// <summary>
        /// Desired song duration in seconds. Must be between 30 and 420.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Energy level of the generated song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("energy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loudly.JsonConverters.GenerateAiSongRequestEnergyJsonConverter))]
        public global::Loudly.GenerateAiSongRequestEnergy? Energy { get; set; }

        /// <summary>
        /// Tempo in BPM. For optimal results, choose a value in the recommended range from GET /b2b/ai/genres.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bpm")]
        public int? Bpm { get; set; }

        /// <summary>
        /// The root note of the musical key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_root")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loudly.JsonConverters.GenerateAiSongRequestKeyRootJsonConverter))]
        public global::Loudly.GenerateAiSongRequestKeyRoot? KeyRoot { get; set; }

        /// <summary>
        /// The quality of the musical key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loudly.JsonConverters.GenerateAiSongRequestKeyQualityJsonConverter))]
        public global::Loudly.GenerateAiSongRequestKeyQuality? KeyQuality { get; set; }

        /// <summary>
        /// A list of instruments to include. Available instruments depend on the selected genre<br/>
        /// and are found in GET /b2b/ai/genres. Instruments can be repeated for multiple instances.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruments")]
        public global::System.Collections.Generic.IList<string>? Instruments { get; set; }

        /// <summary>
        /// Choose a structure from GET /b2b/ai/structures.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structure_id")]
        public int? StructureId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAiSongRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateAiSongRequest(
            string genre,
            string? genreBlend,
            int? duration,
            global::Loudly.GenerateAiSongRequestEnergy? energy,
            int? bpm,
            global::Loudly.GenerateAiSongRequestKeyRoot? keyRoot,
            global::Loudly.GenerateAiSongRequestKeyQuality? keyQuality,
            global::System.Collections.Generic.IList<string>? instruments,
            int? structureId)
        {
            this.Genre = genre ?? throw new global::System.ArgumentNullException(nameof(genre));
            this.GenreBlend = genreBlend;
            this.Duration = duration;
            this.Energy = energy;
            this.Bpm = bpm;
            this.KeyRoot = keyRoot;
            this.KeyQuality = keyQuality;
            this.Instruments = instruments;
            this.StructureId = structureId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAiSongRequest" /> class.
        /// </summary>
        public GenerateAiSongRequest()
        {
        }
    }
}