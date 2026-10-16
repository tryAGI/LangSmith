
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluatorsUpdateCodeEvaluatorRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_features_enabled")]
        public bool? AdvancedFeaturesEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// CodeEvaluatorInput is config (not a snapshot rebuild). Null clears it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_evaluator_input")]
        public global::LangSmith.EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput? CodeEvaluatorInput { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public string? Dependencies { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managed_code_evaluator_settings")]
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.EvaluatorsManagedCodeEvaluatorMetricSetting>? ManagedCodeEvaluatorSettings { get; set; }

        /// <summary>
        /// RequireAttachments is fetch-time config: updating it does not rebuild<br/>
        /// the sandbox snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_attachments")]
        public bool? RequireAttachments { get; set; }

        /// <summary>
        /// WorkspaceSecretsKeys names the workspace secrets this evaluator may use.<br/>
        /// Each is sent as a header on requests to the hosts allowed for that<br/>
        /// secret; evaluator code never sees the value. Requires<br/>
        /// advanced_features_enabled, and each secret needs an allowed host with a<br/>
        /// header. Omit to keep the current list; [] clears it. Changing it does<br/>
        /// not rebuild the evaluator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_secrets_keys")]
        public global::System.Collections.Generic.IList<string>? WorkspaceSecretsKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsUpdateCodeEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="advancedFeaturesEnabled"></param>
        /// <param name="code"></param>
        /// <param name="codeEvaluatorInput">
        /// CodeEvaluatorInput is config (not a snapshot rebuild). Null clears it.
        /// </param>
        /// <param name="dependencies"></param>
        /// <param name="language"></param>
        /// <param name="managedCodeEvaluatorSettings"></param>
        /// <param name="requireAttachments">
        /// RequireAttachments is fetch-time config: updating it does not rebuild<br/>
        /// the sandbox snapshot.
        /// </param>
        /// <param name="workspaceSecretsKeys">
        /// WorkspaceSecretsKeys names the workspace secrets this evaluator may use.<br/>
        /// Each is sent as a header on requests to the hosts allowed for that<br/>
        /// secret; evaluator code never sees the value. Requires<br/>
        /// advanced_features_enabled, and each secret needs an allowed host with a<br/>
        /// header. Omit to keep the current list; [] clears it. Changing it does<br/>
        /// not rebuild the evaluator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsUpdateCodeEvaluatorRequest(
            bool? advancedFeaturesEnabled,
            string? code,
            global::LangSmith.EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput? codeEvaluatorInput,
            string? dependencies,
            string? language,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.EvaluatorsManagedCodeEvaluatorMetricSetting>? managedCodeEvaluatorSettings,
            bool? requireAttachments,
            global::System.Collections.Generic.IList<string>? workspaceSecretsKeys)
        {
            this.AdvancedFeaturesEnabled = advancedFeaturesEnabled;
            this.Code = code;
            this.CodeEvaluatorInput = codeEvaluatorInput;
            this.Dependencies = dependencies;
            this.Language = language;
            this.ManagedCodeEvaluatorSettings = managedCodeEvaluatorSettings;
            this.RequireAttachments = requireAttachments;
            this.WorkspaceSecretsKeys = workspaceSecretsKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsUpdateCodeEvaluatorRequest" /> class.
        /// </summary>
        public EvaluatorsUpdateCodeEvaluatorRequest()
        {
        }

    }
}