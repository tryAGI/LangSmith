
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// A single granular usage data point.
    /// </summary>
    public sealed partial class GranularUsageRecord
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_bucket")]
        public global::System.DateTime? TimeBucket { get; set; }

        /// <summary>
        /// Dimension values for a granular usage record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.GranularUsageDimensions Dimensions { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        public int? Traces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GranularUsageRecord" /> class.
        /// </summary>
        /// <param name="timeBucket"></param>
        /// <param name="dimensions">
        /// Dimension values for a granular usage record.
        /// </param>
        /// <param name="traces">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GranularUsageRecord(
            global::LangSmith.GranularUsageDimensions dimensions,
            global::System.DateTime? timeBucket,
            int? traces)
        {
            this.Dimensions = dimensions ?? throw new global::System.ArgumentNullException(nameof(dimensions));
            this.TimeBucket = timeBucket;
            this.Traces = traces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GranularUsageRecord" /> class.
        /// </summary>
        public GranularUsageRecord()
        {
        }
    }
}