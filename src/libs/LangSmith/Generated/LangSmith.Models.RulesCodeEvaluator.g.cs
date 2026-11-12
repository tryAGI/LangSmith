
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RulesCodeEvaluator
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_evaluator_input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RulesCodeEvaluatorCodeEvaluatorInputJsonConverter))]
        public global::LangSmith.RulesCodeEvaluatorCodeEvaluatorInput? CodeEvaluatorInput { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RulesCodeEvaluatorLanguageJsonConverter))]
        public global::LangSmith.RulesCodeEvaluatorLanguage? Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_attachments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequireAttachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesCodeEvaluator" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="requireAttachments"></param>
        /// <param name="advancedFeaturesEnabled"></param>
        /// <param name="codeEvaluatorInput"></param>
        /// <param name="language"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RulesCodeEvaluator(
            string code,
            bool requireAttachments,
            bool? advancedFeaturesEnabled,
            global::LangSmith.RulesCodeEvaluatorCodeEvaluatorInput? codeEvaluatorInput,
            global::LangSmith.RulesCodeEvaluatorLanguage? language)
        {
            this.AdvancedFeaturesEnabled = advancedFeaturesEnabled;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.CodeEvaluatorInput = codeEvaluatorInput;
            this.Language = language;
            this.RequireAttachments = requireAttachments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesCodeEvaluator" /> class.
        /// </summary>
        public RulesCodeEvaluator()
        {
        }

    }
}