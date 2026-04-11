
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorsCodeEvaluator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_id")]
        public string? EvaluatorId { get; set; }

        /// <summary>
        /// Default: "python"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsCodeEvaluator" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="evaluatorId"></param>
        /// <param name="language">
        /// Default: "python"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsCodeEvaluator(
            string? code,
            string? evaluatorId,
            string? language)
        {
            this.Code = code;
            this.EvaluatorId = evaluatorId;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsCodeEvaluator" /> class.
        /// </summary>
        public EvaluatorsCodeEvaluator()
        {
        }
    }
}