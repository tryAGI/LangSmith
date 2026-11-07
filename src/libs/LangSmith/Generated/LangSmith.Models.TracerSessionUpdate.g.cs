
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Update class for TracerSession.
    /// </summary>
    public sealed partial class TracerSessionUpdate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_dataset_id")]
        public global::System.Guid? DefaultDatasetId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_tier")]
        public global::LangSmith.TraceTier? TraceTier { get; set; }

        /// <summary>
        /// Retention in days for traces while trace_tier is longlived. One of the deployment's allowed values (allowed_longlived_ttl_days in /info), up to the maximum of the deployment. The value is kept while trace_tier is shortlived. Null means the project uses the workspace retention. Omit the field to keep the current value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longlived_ttl_days")]
        public int? LonglivedTtlDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="traceTier"></param>
        /// <param name="longlivedTtlDays">
        /// Retention in days for traces while trace_tier is longlived. One of the deployment's allowed values (allowed_longlived_ttl_days in /info), up to the maximum of the deployment. The value is kept while trace_tier is shortlived. Null means the project uses the workspace retention. Omit the field to keep the current value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionUpdate(
            string? name,
            string? description,
            global::System.Guid? defaultDatasetId,
            global::System.DateTime? endTime,
            object? extra,
            global::LangSmith.TraceTier? traceTier,
            int? longlivedTtlDays)
        {
            this.Name = name;
            this.Description = description;
            this.DefaultDatasetId = defaultDatasetId;
            this.EndTime = endTime;
            this.Extra = extra;
            this.TraceTier = traceTier;
            this.LonglivedTtlDays = longlivedTtlDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionUpdate" /> class.
        /// </summary>
        public TracerSessionUpdate()
        {
        }

    }
}