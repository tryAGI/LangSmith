
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryTraceAggregates
    {
        /// <summary>
        /// `first_token_time` is when the first output token was produced anywhere in the trace (RFC3339), when recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_token_time")]
        public global::System.DateTime? FirstTokenTime { get; set; }

        /// <summary>
        /// `total_cost` is total estimated USD cost across every run in the trace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// `total_tokens` is prompt plus completion tokens summed across every run in the trace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryTraceAggregates" /> class.
        /// </summary>
        /// <param name="firstTokenTime">
        /// `first_token_time` is when the first output token was produced anywhere in the trace (RFC3339), when recorded.
        /// </param>
        /// <param name="totalCost">
        /// `total_cost` is total estimated USD cost across every run in the trace.
        /// </param>
        /// <param name="totalTokens">
        /// `total_tokens` is prompt plus completion tokens summed across every run in the trace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryTraceAggregates(
            global::System.DateTime? firstTokenTime,
            double? totalCost,
            int? totalTokens)
        {
            this.FirstTokenTime = firstTokenTime;
            this.TotalCost = totalCost;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryTraceAggregates" /> class.
        /// </summary>
        public QueryTraceAggregates()
        {
        }

    }
}