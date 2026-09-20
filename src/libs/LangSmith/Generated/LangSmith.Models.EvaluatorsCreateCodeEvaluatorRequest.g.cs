
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluatorsCreateCodeEvaluatorRequest
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public string? Dependencies { get; set; }

        /// <summary>
        /// Default: "python"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managed_code_evaluator_key")]
        public string? ManagedCodeEvaluatorKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managed_code_evaluator_settings")]
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.EvaluatorsManagedCodeEvaluatorMetricSetting>? ManagedCodeEvaluatorSettings { get; set; }

        /// <summary>
        /// RequireAttachments opts the evaluator into selecting/presigning run<br/>
        /// attachments (s3_urls) at evaluation time. Default false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_attachments")]
        public bool? RequireAttachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsCreateCodeEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="advancedFeaturesEnabled"></param>
        /// <param name="code"></param>
        /// <param name="dependencies"></param>
        /// <param name="language">
        /// Default: "python"
        /// </param>
        /// <param name="managedCodeEvaluatorKey"></param>
        /// <param name="managedCodeEvaluatorSettings"></param>
        /// <param name="requireAttachments">
        /// RequireAttachments opts the evaluator into selecting/presigning run<br/>
        /// attachments (s3_urls) at evaluation time. Default false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsCreateCodeEvaluatorRequest(
            bool? advancedFeaturesEnabled,
            string? code,
            string? dependencies,
            string? language,
            string? managedCodeEvaluatorKey,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.EvaluatorsManagedCodeEvaluatorMetricSetting>? managedCodeEvaluatorSettings,
            bool? requireAttachments)
        {
            this.AdvancedFeaturesEnabled = advancedFeaturesEnabled;
            this.Code = code;
            this.Dependencies = dependencies;
            this.Language = language;
            this.ManagedCodeEvaluatorKey = managedCodeEvaluatorKey;
            this.ManagedCodeEvaluatorSettings = managedCodeEvaluatorSettings;
            this.RequireAttachments = requireAttachments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsCreateCodeEvaluatorRequest" /> class.
        /// </summary>
        public EvaluatorsCreateCodeEvaluatorRequest()
        {
        }

    }
}