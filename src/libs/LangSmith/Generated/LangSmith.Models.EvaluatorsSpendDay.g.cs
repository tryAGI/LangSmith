
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorsSpendDay
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_usd")]
        public double? SpendUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_count")]
        public int? TraceCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsSpendDay" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="spendUsd"></param>
        /// <param name="traceCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsSpendDay(
            string? date,
            double? spendUsd,
            int? traceCount)
        {
            this.Date = date;
            this.SpendUsd = spendUsd;
            this.TraceCount = traceCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsSpendDay" /> class.
        /// </summary>
        public EvaluatorsSpendDay()
        {
        }

    }
}