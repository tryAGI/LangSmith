
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorsEvaluatorRunRule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corrections_dataset_id")]
        public string? CorrectionsDatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        public string? DatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public string? GroupBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_few_shot_examples")]
        public int? NumFewShotExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_name")]
        public string? SessionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_corrections_dataset")]
        public bool? UseCorrectionsDataset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsEvaluatorRunRule" /> class.
        /// </summary>
        /// <param name="correctionsDatasetId"></param>
        /// <param name="datasetId"></param>
        /// <param name="datasetName"></param>
        /// <param name="groupBy"></param>
        /// <param name="id"></param>
        /// <param name="numFewShotExamples"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="useCorrectionsDataset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsEvaluatorRunRule(
            string? correctionsDatasetId,
            string? datasetId,
            string? datasetName,
            string? groupBy,
            string? id,
            int? numFewShotExamples,
            string? sessionId,
            string? sessionName,
            bool? useCorrectionsDataset)
        {
            this.CorrectionsDatasetId = correctionsDatasetId;
            this.DatasetId = datasetId;
            this.DatasetName = datasetName;
            this.GroupBy = groupBy;
            this.Id = id;
            this.NumFewShotExamples = numFewShotExamples;
            this.SessionId = sessionId;
            this.SessionName = sessionName;
            this.UseCorrectionsDataset = useCorrectionsDataset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsEvaluatorRunRule" /> class.
        /// </summary>
        public EvaluatorsEvaluatorRunRule()
        {
        }
    }
}