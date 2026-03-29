
#nullable enable

namespace Loudly
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageLimit
    {
        /// <summary>
        /// The type of request (e.g. ai_song, catalog_song).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_type")]
        public string? RequestType { get; set; }

        /// <summary>
        /// The total usage limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The amount of usage consumed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        public int? Used { get; set; }

        /// <summary>
        /// The remaining usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        public int? Left { get; set; }

        /// <summary>
        /// Start date of the usage period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_from")]
        public string? DateFrom { get; set; }

        /// <summary>
        /// End date of the usage period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_to")]
        public string? DateTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimit" /> class.
        /// </summary>
        /// <param name="requestType">
        /// The type of request (e.g. ai_song, catalog_song).
        /// </param>
        /// <param name="limit">
        /// The total usage limit.
        /// </param>
        /// <param name="used">
        /// The amount of usage consumed.
        /// </param>
        /// <param name="left">
        /// The remaining usage.
        /// </param>
        /// <param name="dateFrom">
        /// Start date of the usage period.
        /// </param>
        /// <param name="dateTo">
        /// End date of the usage period.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageLimit(
            string? requestType,
            int? limit,
            int? used,
            int? left,
            string? dateFrom,
            string? dateTo)
        {
            this.RequestType = requestType;
            this.Limit = limit;
            this.Used = used;
            this.Left = left;
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimit" /> class.
        /// </summary>
        public UsageLimit()
        {
        }
    }
}