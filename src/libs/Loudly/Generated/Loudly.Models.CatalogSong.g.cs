
#nullable enable

namespace Loudly
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CatalogSong
    {
        /// <summary>
        /// Unique identifier of the song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Title of the song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Artist name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artist")]
        public string? Artist { get; set; }

        /// <summary>
        /// Genres associated with the song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genres")]
        public global::System.Collections.Generic.IList<string>? Genres { get; set; }

        /// <summary>
        /// Moods associated with the song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moods")]
        public global::System.Collections.Generic.IList<string>? Moods { get; set; }

        /// <summary>
        /// Duration of the song in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public float? Duration { get; set; }

        /// <summary>
        /// Tempo in BPM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bpm")]
        public int? Bpm { get; set; }

        /// <summary>
        /// Musical key of the song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// URL to the music file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_file_path")]
        public string? MusicFilePath { get; set; }

        /// <summary>
        /// URL to the waveform data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wave_form_file_path")]
        public string? WaveFormFilePath { get; set; }

        /// <summary>
        /// Creation timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogSong" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the song.
        /// </param>
        /// <param name="title">
        /// Title of the song.
        /// </param>
        /// <param name="artist">
        /// Artist name.
        /// </param>
        /// <param name="genres">
        /// Genres associated with the song.
        /// </param>
        /// <param name="moods">
        /// Moods associated with the song.
        /// </param>
        /// <param name="duration">
        /// Duration of the song in seconds.
        /// </param>
        /// <param name="bpm">
        /// Tempo in BPM.
        /// </param>
        /// <param name="key">
        /// Musical key of the song.
        /// </param>
        /// <param name="musicFilePath">
        /// URL to the music file.
        /// </param>
        /// <param name="waveFormFilePath">
        /// URL to the waveform data.
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CatalogSong(
            string? id,
            string? title,
            string? artist,
            global::System.Collections.Generic.IList<string>? genres,
            global::System.Collections.Generic.IList<string>? moods,
            float? duration,
            int? bpm,
            string? key,
            string? musicFilePath,
            string? waveFormFilePath,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Title = title;
            this.Artist = artist;
            this.Genres = genres;
            this.Moods = moods;
            this.Duration = duration;
            this.Bpm = bpm;
            this.Key = key;
            this.MusicFilePath = musicFilePath;
            this.WaveFormFilePath = waveFormFilePath;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogSong" /> class.
        /// </summary>
        public CatalogSong()
        {
        }
    }
}