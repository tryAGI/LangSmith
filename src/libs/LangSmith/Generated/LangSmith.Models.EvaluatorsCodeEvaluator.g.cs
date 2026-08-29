
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
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public string? Dependencies { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_build_error")]
        public string? EvaluatorBuildError { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_build_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.EvaluatorsEvaluatorBuildStatusJsonConverter))]
        public global::LangSmith.EvaluatorsEvaluatorBuildStatus? EvaluatorBuildStatus { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_secrets_keys")]
        public global::System.Collections.Generic.IList<string>? WorkspaceSecretsKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsCodeEvaluator" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="dependencies"></param>
        /// <param name="evaluatorBuildError"></param>
        /// <param name="evaluatorBuildStatus"></param>
        /// <param name="evaluatorId"></param>
        /// <param name="language">
        /// Default: "python"
        /// </param>
        /// <param name="workspaceSecretsKeys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsCodeEvaluator(
            string? code,
            string? dependencies,
            string? evaluatorBuildError,
            global::LangSmith.EvaluatorsEvaluatorBuildStatus? evaluatorBuildStatus,
            string? evaluatorId,
            string? language,
            global::System.Collections.Generic.IList<string>? workspaceSecretsKeys)
        {
            this.Code = code;
            this.Dependencies = dependencies;
            this.EvaluatorBuildError = evaluatorBuildError;
            this.EvaluatorBuildStatus = evaluatorBuildStatus;
            this.EvaluatorId = evaluatorId;
            this.Language = language;
            this.WorkspaceSecretsKeys = workspaceSecretsKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsCodeEvaluator" /> class.
        /// </summary>
        public EvaluatorsCodeEvaluator()
        {
        }

    }
}