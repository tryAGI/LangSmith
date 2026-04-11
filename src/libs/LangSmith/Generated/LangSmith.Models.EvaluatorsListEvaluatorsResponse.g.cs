
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorsListEvaluatorsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluator>? Evaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsListEvaluatorsResponse" /> class.
        /// </summary>
        /// <param name="evaluators"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsListEvaluatorsResponse(
            global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluator>? evaluators,
            int? total)
        {
            this.Evaluators = evaluators;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsListEvaluatorsResponse" /> class.
        /// </summary>
        public EvaluatorsListEvaluatorsResponse()
        {
        }
    }
}