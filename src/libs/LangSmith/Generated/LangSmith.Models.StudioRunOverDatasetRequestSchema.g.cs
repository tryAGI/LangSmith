
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StudioRunOverDatasetRequestSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ProjectName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid DatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_rules")]
        public global::System.Collections.Generic.IList<global::System.Guid>? EvaluatorRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioRunOverDatasetRequestSchema" /> class.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="datasetId"></param>
        /// <param name="evaluatorRules"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StudioRunOverDatasetRequestSchema(
            string projectName,
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::System.Guid>? evaluatorRules,
            object? metadata)
        {
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.DatasetId = datasetId;
            this.EvaluatorRules = evaluatorRules;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioRunOverDatasetRequestSchema" /> class.
        /// </summary>
        public StudioRunOverDatasetRequestSchema()
        {
        }
    }
}