
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TracerSessionsUpdateSessionRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_dataset_id")]
        public global::System.Guid? DefaultDatasetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longlived_ttl_days")]
        public int? LonglivedTtlDays { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.TracerSessionsUpdateSessionRequestTraceTierJsonConverter))]
        public global::LangSmith.TracerSessionsUpdateSessionRequestTraceTier? TraceTier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionsUpdateSessionRequest" /> class.
        /// </summary>
        /// <param name="defaultDatasetId"></param>
        /// <param name="description"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="longlivedTtlDays"></param>
        /// <param name="name"></param>
        /// <param name="traceTier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionsUpdateSessionRequest(
            global::System.Guid? defaultDatasetId,
            string? description,
            global::System.DateTime? endTime,
            object? extra,
            int? longlivedTtlDays,
            string? name,
            global::LangSmith.TracerSessionsUpdateSessionRequestTraceTier? traceTier)
        {
            this.DefaultDatasetId = defaultDatasetId;
            this.Description = description;
            this.EndTime = endTime;
            this.Extra = extra;
            this.LonglivedTtlDays = longlivedTtlDays;
            this.Name = name;
            this.TraceTier = traceTier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionsUpdateSessionRequest" /> class.
        /// </summary>
        public TracerSessionsUpdateSessionRequest()
        {
        }

    }
}