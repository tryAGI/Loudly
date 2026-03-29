
#nullable enable

namespace Loudly
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiSong
    {
        /// <summary>
        /// Unique identifier of the generated song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Title of the generated song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Duration of the song in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public float? Duration { get; set; }

        /// <summary>
        /// URL to the generated music file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_file_path")]
        public string? MusicFilePath { get; set; }

        /// <summary>
        /// URL to the song data XML file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xml_file_path")]
        public string? XmlFilePath { get; set; }

        /// <summary>
        /// URL to the waveform data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wave_form_file_path")]
        public string? WaveFormFilePath { get; set; }

        /// <summary>
        /// Timestamp of when the song was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// BPM of the generated song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bpm")]
        public int? Bpm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public global::Loudly.MusicalKey? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiSong" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the generated song.
        /// </param>
        /// <param name="title">
        /// Title of the generated song.
        /// </param>
        /// <param name="duration">
        /// Duration of the song in seconds.
        /// </param>
        /// <param name="musicFilePath">
        /// URL to the generated music file.
        /// </param>
        /// <param name="xmlFilePath">
        /// URL to the song data XML file.
        /// </param>
        /// <param name="waveFormFilePath">
        /// URL to the waveform data.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of when the song was created.
        /// </param>
        /// <param name="bpm">
        /// BPM of the generated song.
        /// </param>
        /// <param name="key"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiSong(
            string? id,
            string? title,
            float? duration,
            string? musicFilePath,
            string? xmlFilePath,
            string? waveFormFilePath,
            global::System.DateTime? createdAt,
            int? bpm,
            global::Loudly.MusicalKey? key)
        {
            this.Id = id;
            this.Title = title;
            this.Duration = duration;
            this.MusicFilePath = musicFilePath;
            this.XmlFilePath = xmlFilePath;
            this.WaveFormFilePath = waveFormFilePath;
            this.CreatedAt = createdAt;
            this.Bpm = bpm;
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiSong" /> class.
        /// </summary>
        public AiSong()
        {
        }
    }
}