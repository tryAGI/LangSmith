
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Schema for grouped experiment (tracer session) query.
    /// </summary>
    public sealed partial class GroupedExperimentsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats_start_time")]
        public global::System.DateTime? StatsStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name_contains")]
        public string? NameContains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_value_id")]
        public global::System.Collections.Generic.IList<global::System.Guid>? TagValueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_version")]
        public string? DatasetVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_approx_stats")]
        public bool? UseApproxStats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<string> MetadataKeys { get; set; } = default!;

        /// <summary>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_limit")]
        public int? ExperimentLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedExperimentsRequest" /> class.
        /// </summary>
        /// <param name="statsStartTime"></param>
        /// <param name="nameContains"></param>
        /// <param name="tagValueId"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="filter"></param>
        /// <param name="useApproxStats">
        /// Default Value: false
        /// </param>
        /// <param name="metadataKeys"></param>
        /// <param name="experimentLimit">
        /// Default Value: 1000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupedExperimentsRequest(
            global::System.Collections.Generic.IList<string> metadataKeys,
            global::System.DateTime? statsStartTime,
            string? nameContains,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId,
            string? datasetVersion,
            string? filter,
            bool? useApproxStats,
            int? experimentLimit)
        {
            this.MetadataKeys = metadataKeys ?? throw new global::System.ArgumentNullException(nameof(metadataKeys));
            this.StatsStartTime = statsStartTime;
            this.NameContains = nameContains;
            this.TagValueId = tagValueId;
            this.DatasetVersion = datasetVersion;
            this.Filter = filter;
            this.UseApproxStats = useApproxStats;
            this.ExperimentLimit = experimentLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedExperimentsRequest" /> class.
        /// </summary>
        public GroupedExperimentsRequest()
        {
        }
    }
}