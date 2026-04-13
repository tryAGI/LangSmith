
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorsLLMEvaluator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_queue_id")]
        public string? AnnotationQueueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_hash_or_tag")]
        public string? CommitHashOrTag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corrections_dataset_id")]
        public string? CorrectionsDatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_id")]
        public string? EvaluatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_few_shot_examples")]
        public int? NumFewShotExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_id")]
        public string? PromptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_repo_handle")]
        public string? PromptRepoHandle { get; set; }

        /// <summary>
        /// Derived from the evaluator's run rules — shared across all rules on this evaluator.<br/>
        /// Nil when the evaluator has no run rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_corrections_dataset")]
        public bool? UseCorrectionsDataset { get; set; }

        /// <summary>
        /// JSONB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable_mapping")]
        public object? VariableMapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsLLMEvaluator" /> class.
        /// </summary>
        /// <param name="annotationQueueId"></param>
        /// <param name="commitHashOrTag"></param>
        /// <param name="correctionsDatasetId"></param>
        /// <param name="evaluatorId"></param>
        /// <param name="numFewShotExamples"></param>
        /// <param name="promptId"></param>
        /// <param name="promptRepoHandle"></param>
        /// <param name="useCorrectionsDataset">
        /// Derived from the evaluator's run rules — shared across all rules on this evaluator.<br/>
        /// Nil when the evaluator has no run rules.
        /// </param>
        /// <param name="variableMapping">
        /// JSONB
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsLLMEvaluator(
            string? annotationQueueId,
            string? commitHashOrTag,
            string? correctionsDatasetId,
            string? evaluatorId,
            int? numFewShotExamples,
            string? promptId,
            string? promptRepoHandle,
            bool? useCorrectionsDataset,
            object? variableMapping)
        {
            this.AnnotationQueueId = annotationQueueId;
            this.CommitHashOrTag = commitHashOrTag;
            this.CorrectionsDatasetId = correctionsDatasetId;
            this.EvaluatorId = evaluatorId;
            this.NumFewShotExamples = numFewShotExamples;
            this.PromptId = promptId;
            this.PromptRepoHandle = promptRepoHandle;
            this.UseCorrectionsDataset = useCorrectionsDataset;
            this.VariableMapping = variableMapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsLLMEvaluator" /> class.
        /// </summary>
        public EvaluatorsLLMEvaluator()
        {
        }
    }
}