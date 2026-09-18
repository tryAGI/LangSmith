
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsUpdateCodeEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="advancedFeaturesEnabled"></param>
        /// <param name="code"></param>
        /// <param name="dependencies"></param>
        /// <param name="language"></param>
        /// <param name="managedCodeEvaluatorSettings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsUpdateCodeEvaluatorRequest(
            bool? advancedFeaturesEnabled,
            string? code,
            string? dependencies,
            string? language,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.EvaluatorsManagedCodeEvaluatorMetricSetting>? managedCodeEvaluatorSettings)
        {
            this.AdvancedFeaturesEnabled = advancedFeaturesEnabled;
            this.Code = code;
            this.Dependencies = dependencies;
            this.Language = language;
            this.ManagedCodeEvaluatorSettings = managedCodeEvaluatorSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsUpdateCodeEvaluatorRequest" /> class.
        /// </summary>
        public EvaluatorsUpdateCodeEvaluatorRequest()
        {
        }

    }
}