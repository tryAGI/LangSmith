
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackFormulaUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FeedbackKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.FeedbackFormulaUpdateAggregationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.FeedbackFormulaUpdateAggregationType AggregationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formula_parts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormulaWeightedVariable> FormulaParts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackFormulaUpdate" /> class.
        /// </summary>
        /// <param name="feedbackKey"></param>
        /// <param name="aggregationType"></param>
        /// <param name="formulaParts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackFormulaUpdate(
            string feedbackKey,
            global::LangSmith.FeedbackFormulaUpdateAggregationType aggregationType,
            global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormulaWeightedVariable> formulaParts)
        {
            this.FeedbackKey = feedbackKey ?? throw new global::System.ArgumentNullException(nameof(feedbackKey));
            this.AggregationType = aggregationType;
            this.FormulaParts = formulaParts ?? throw new global::System.ArgumentNullException(nameof(formulaParts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackFormulaUpdate" /> class.
        /// </summary>
        public FeedbackFormulaUpdate()
        {
        }
    }
}