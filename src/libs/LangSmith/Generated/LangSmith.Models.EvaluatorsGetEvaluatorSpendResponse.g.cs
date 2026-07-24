
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorsGetEvaluatorSpendResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsSpendGroup>? Groups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_end")]
        public string? PeriodEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_start")]
        public string? PeriodStart { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsGetEvaluatorSpendResponse" /> class.
        /// </summary>
        /// <param name="groups"></param>
        /// <param name="periodEnd"></param>
        /// <param name="periodStart"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsGetEvaluatorSpendResponse(
            global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsSpendGroup>? groups,
            string? periodEnd,
            string? periodStart)
        {
            this.Groups = groups;
            this.PeriodEnd = periodEnd;
            this.PeriodStart = periodStart;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsGetEvaluatorSpendResponse" /> class.
        /// </summary>
        public EvaluatorsGetEvaluatorSpendResponse()
        {
        }

    }
}