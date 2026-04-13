
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorsUpdateLLMEvaluatorRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_hash_or_tag")]
        public string? CommitHashOrTag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_few_shot_examples")]
        public int? NumFewShotExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_repo_handle")]
        public string? PromptRepoHandle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_corrections_dataset")]
        public bool? UseCorrectionsDataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable_mapping")]
        public object? VariableMapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsUpdateLLMEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="commitHashOrTag"></param>
        /// <param name="numFewShotExamples"></param>
        /// <param name="promptRepoHandle"></param>
        /// <param name="useCorrectionsDataset"></param>
        /// <param name="variableMapping"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsUpdateLLMEvaluatorRequest(
            string? commitHashOrTag,
            int? numFewShotExamples,
            string? promptRepoHandle,
            bool? useCorrectionsDataset,
            object? variableMapping)
        {
            this.CommitHashOrTag = commitHashOrTag;
            this.NumFewShotExamples = numFewShotExamples;
            this.PromptRepoHandle = promptRepoHandle;
            this.UseCorrectionsDataset = useCorrectionsDataset;
            this.VariableMapping = variableMapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsUpdateLLMEvaluatorRequest" /> class.
        /// </summary>
        public EvaluatorsUpdateLLMEvaluatorRequest()
        {
        }
    }
}