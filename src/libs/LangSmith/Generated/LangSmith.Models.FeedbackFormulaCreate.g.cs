
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackFormulaCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.FeedbackFormulaCreateAggregationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.FeedbackFormulaCreateAggregationType AggregationType { get; set; }

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
        /// Initializes a new instance of the <see cref="FeedbackFormulaCreate" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="sessionId"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="aggregationType"></param>
        /// <param name="formulaParts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackFormulaCreate(
            string feedbackKey,
            global::LangSmith.FeedbackFormulaCreateAggregationType aggregationType,
            global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormulaWeightedVariable> formulaParts,
            global::System.Guid? datasetId,
            global::System.Guid? sessionId)
        {
            this.FeedbackKey = feedbackKey ?? throw new global::System.ArgumentNullException(nameof(feedbackKey));
            this.AggregationType = aggregationType;
            this.FormulaParts = formulaParts ?? throw new global::System.ArgumentNullException(nameof(formulaParts));
            this.DatasetId = datasetId;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackFormulaCreate" /> class.
        /// </summary>
        public FeedbackFormulaCreate()
        {
        }
    }
}