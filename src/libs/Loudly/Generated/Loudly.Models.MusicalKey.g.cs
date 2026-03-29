
#nullable enable

namespace Loudly
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MusicalKey
    {
        /// <summary>
        /// Unique identifier of the key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Name of the key (e.g. C major).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether the key is active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicalKey" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the key.
        /// </param>
        /// <param name="name">
        /// Name of the key (e.g. C major).
        /// </param>
        /// <param name="active">
        /// Whether the key is active.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicalKey(
            int? id,
            string? name,
            bool? active)
        {
            this.Id = id;
            this.Name = name;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicalKey" /> class.
        /// </summary>
        public MusicalKey()
        {
        }
    }
}