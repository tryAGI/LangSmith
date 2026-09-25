
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunsanalyticsMetricDefinition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("denominator")]
        public global::LangSmith.RunsanalyticsScalarMetricDefinition? Denominator { get; set; }

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
        /// Numerator and Denominator are required when type=ratio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numerator")]
        public global::LangSmith.RunsanalyticsScalarMetricDefinition? Numerator { get; set; }

        /// <summary>
        /// percentile p or histogram bucket_count
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::LangSmith.RunsanalyticsMetricParams? Params { get; set; }

        /// <summary>
        /// histogram is reserved and rejected; the tag publishes what is accepted.
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
        /// Initializes a new instance of the <see cref="RunsanalyticsMetricDefinition" /> class.
        /// </summary>
        /// <param name="type">
        /// histogram is reserved and rejected; the tag publishes what is accepted.
        /// </param>
        /// <param name="denominator"></param>
        /// <param name="entity">
        /// Entity selects what a type=count metric counts. Only valid when type=count;<br/>
        /// defaults to MetricEntityRun. entity=feedback requires params.feedback_key<br/>
        /// and counts individual feedback records rather than runs.
        /// </param>
        /// <param name="field"></param>
        /// <param name="numerator">
        /// Numerator and Denominator are required when type=ratio.
        /// </param>
        /// <param name="params">
        /// percentile p or histogram bucket_count
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunsanalyticsMetricDefinition(
            global::LangSmith.RunsanalyticsMetricType type,
            global::LangSmith.RunsanalyticsScalarMetricDefinition? denominator,
            global::LangSmith.RunsanalyticsMetricEntity? entity,
            global::LangSmith.RunsanalyticsMetricField? field,
            global::LangSmith.RunsanalyticsScalarMetricDefinition? numerator,
            global::LangSmith.RunsanalyticsMetricParams? @params)
        {
            this.Denominator = denominator;
            this.Entity = entity;
            this.Field = field;
            this.Numerator = numerator;
            this.Params = @params;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsanalyticsMetricDefinition" /> class.
        /// </summary>
        public RunsanalyticsMetricDefinition()
        {
        }

    }
}