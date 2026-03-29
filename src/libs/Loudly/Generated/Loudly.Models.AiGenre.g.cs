
#nullable enable

namespace Loudly
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiGenre
    {
        /// <summary>
        /// Name of the genre.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the genre.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL to the genre image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Suggested template names for this genre.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_names")]
        public global::System.Collections.Generic.IList<string>? TemplateNames { get; set; }

        /// <summary>
        /// Available instruments for this genre.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruments")]
        public global::System.Collections.Generic.IList<string>? Instruments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGenre" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the genre.
        /// </param>
        /// <param name="description">
        /// Description of the genre.
        /// </param>
        /// <param name="imageUrl">
        /// URL to the genre image.
        /// </param>
        /// <param name="templateNames">
        /// Suggested template names for this genre.
        /// </param>
        /// <param name="instruments">
        /// Available instruments for this genre.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGenre(
            string? name,
            string? description,
            string? imageUrl,
            global::System.Collections.Generic.IList<string>? templateNames,
            global::System.Collections.Generic.IList<string>? instruments)
        {
            this.Name = name;
            this.Description = description;
            this.ImageUrl = imageUrl;
            this.TemplateNames = templateNames;
            this.Instruments = instruments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGenre" /> class.
        /// </summary>
        public AiGenre()
        {
        }
    }
}