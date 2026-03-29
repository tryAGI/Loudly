
#nullable enable

namespace Loudly
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CatalogTags
    {
        /// <summary>
        /// Available mood tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mood")]
        public global::System.Collections.Generic.IList<string>? Mood { get; set; }

        /// <summary>
        /// Available genre tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genre")]
        public global::System.Collections.Generic.IList<string>? Genre { get; set; }

        /// <summary>
        /// Available musical key tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public global::System.Collections.Generic.IList<string>? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogTags" /> class.
        /// </summary>
        /// <param name="mood">
        /// Available mood tags.
        /// </param>
        /// <param name="genre">
        /// Available genre tags.
        /// </param>
        /// <param name="key">
        /// Available musical key tags.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CatalogTags(
            global::System.Collections.Generic.IList<string>? mood,
            global::System.Collections.Generic.IList<string>? genre,
            global::System.Collections.Generic.IList<string>? key)
        {
            this.Mood = mood;
            this.Genre = genre;
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogTags" /> class.
        /// </summary>
        public CatalogTags()
        {
        }
    }
}