
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorsUpdateEvaluatorResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator")]
        public global::LangSmith.EvaluatorsEvaluator? Evaluator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsUpdateEvaluatorResponse" /> class.
        /// </summary>
        /// <param name="evaluator"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsUpdateEvaluatorResponse(
            global::LangSmith.EvaluatorsEvaluator? evaluator)
        {
            this.Evaluator = evaluator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsUpdateEvaluatorResponse" /> class.
        /// </summary>
        public EvaluatorsUpdateEvaluatorResponse()
        {
        }
    }
}