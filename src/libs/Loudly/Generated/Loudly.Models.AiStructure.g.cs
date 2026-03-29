
#nullable enable

namespace Loudly
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiStructure
    {
        /// <summary>
        /// Unique identifier of the structure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the structure (e.g. Intro-Verse-Chorus).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the structure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL to the structure image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiStructure" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the structure.
        /// </param>
        /// <param name="name">
        /// Name of the structure (e.g. Intro-Verse-Chorus).
        /// </param>
        /// <param name="description">
        /// Description of the structure.
        /// </param>
        /// <param name="imageUrl">
        /// URL to the structure image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiStructure(
            string? id,
            string? name,
            string? description,
            string? imageUrl)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiStructure" /> class.
        /// </summary>
        public AiStructure()
        {
        }
    }
}