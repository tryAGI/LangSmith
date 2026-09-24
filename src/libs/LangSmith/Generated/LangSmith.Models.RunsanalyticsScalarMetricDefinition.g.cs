
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunsanalyticsScalarMetricDefinition
    {
        /// <summary>
        /// Entity selects what a type=count metric counts. Only valid when type=count;<br/>
        /// defaults to MetricEntityRun. entity=feedback requires params.feedback_key<br/>
        /// and counts individual feedback records rather than runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RunsanalyticsMetricEntityJsonConverter))]
        public global::LangSmith.RunsanalyticsMetricEntity? Entity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RunsanalyticsMetricFieldJsonConverter))]
        public global::LangSmith.RunsanalyticsMetricField? Field { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// required when type=percentile
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::LangSmith.RunsanalyticsMetricParams? Params { get; set; }

        /// <summary>
        /// An operand is non-composite, so ratio is rejected here too.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RunsanalyticsMetricTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.RunsanalyticsMetricType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsanalyticsScalarMetricDefinition" /> class.
        /// </summary>
        /// <param name="type">
        /// An operand is non-composite, so ratio is rejected here too.
        /// </param>
        /// <param name="entity">
        /// Entity selects what a type=count metric counts. Only valid when type=count;<br/>
        /// defaults to MetricEntityRun. entity=feedback requires params.feedback_key<br/>
        /// and counts individual feedback records rather than runs.
        /// </param>
        /// <param name="field"></param>
        /// <param name="filter"></param>
        /// <param name="params">
        /// required when type=percentile
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunsanalyticsScalarMetricDefinition(
            global::LangSmith.RunsanalyticsMetricType type,
            global::LangSmith.RunsanalyticsMetricEntity? entity,
            global::LangSmith.RunsanalyticsMetricField? field,
            string? filter,
            global::LangSmith.RunsanalyticsMetricParams? @params)
        {
            this.Entity = entity;
            this.Field = field;
            this.Filter = filter;
            this.Params = @params;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsanalyticsScalarMetricDefinition" /> class.
        /// </summary>
        public RunsanalyticsScalarMetricDefinition()
        {
        }

    }
}