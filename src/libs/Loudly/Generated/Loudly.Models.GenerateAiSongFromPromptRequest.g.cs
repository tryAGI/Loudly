
#nullable enable

namespace Loudly
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateAiSongFromPromptRequest
    {
        /// <summary>
        /// A text description of the desired song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Desired song duration in seconds (30-420). If the prompt includes a duration,<br/>
        /// it will be overwritten by this parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAiSongFromPromptRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A text description of the desired song.
        /// </param>
        /// <param name="duration">
        /// Desired song duration in seconds (30-420). If the prompt includes a duration,<br/>
        /// it will be overwritten by this parameter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateAiSongFromPromptRequest(
            string prompt,
            int? duration)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAiSongFromPromptRequest" /> class.
        /// </summary>
        public GenerateAiSongFromPromptRequest()
        {
        }
    }
}