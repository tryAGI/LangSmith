
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// A decision-model evaluator to create and attach to a project or dataset.
    /// </summary>
    public sealed partial class DecisionModelRuleCreateSchema
    {
        /// <summary>
        /// The evaluator's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The tracing project to evaluate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// The dataset whose experiments to evaluate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// The prompt the model reads, as (role, template) pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> Prompt { get; set; }

        /// <summary>
        /// Default Value: mustache
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.DecisionModelRuleCreateSchemaTemplateFormatJsonConverter))]
        public global::LangSmith.DecisionModelRuleCreateSchemaTemplateFormat? TemplateFormat { get; set; }

        /// <summary>
        /// Maps the prompt's variables to run fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable_mapping")]
        public global::System.Collections.Generic.Dictionary<string, string>? VariableMapping { get; set; }

        /// <summary>
        /// The questions, keyed by feedback key, in the order to ask them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::LangSmith.DecisionModelQuestion> Questions { get; set; }

        /// <summary>
        /// typesafe for Jev and SemIf, typesafe_compatible for a TypeSafe-compatible endpoint, or openai_decisions.<br/>
        /// Default Value: typesafe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.DecisionModelRuleCreateSchemaProviderJsonConverter))]
        public global::LangSmith.DecisionModelRuleCreateSchemaProvider? Provider { get; set; }

        /// <summary>
        /// Defaults to jev-latest for typesafe and gpt-6-luna for openai_decisions. Use semif-qwen3.5-4b for SemIf.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Call this endpoint directly instead of through the LangSmith gateway, with the workspace's TYPESAFE_API_KEY or OPENAI_API_KEY secret. Required for typesafe_compatible.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Headers sent with each model call. They are saved in the evaluator's prompt as given, so do not put API keys here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? ModelHeaders { get; set; }

        /// <summary>
        /// Seconds to wait for each model call. openai_decisions only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// How many times to retry a failed model call. openai_decisions only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_retries")]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// A saved model configuration to start from: its model, endpoint, key and settings apply unless set here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playground_settings_id")]
        public global::System.Guid? PlaygroundSettingsId { get; set; }

        /// <summary>
        /// The fraction of runs to evaluate.<br/>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_rate")]
        public double? SamplingRate { get; set; }

        /// <summary>
        /// Only evaluate runs that match this filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelRuleCreateSchema" /> class.
        /// </summary>
        /// <param name="displayName">
        /// The evaluator's name.
        /// </param>
        /// <param name="prompt">
        /// The prompt the model reads, as (role, template) pairs.
        /// </param>
        /// <param name="questions">
        /// The questions, keyed by feedback key, in the order to ask them.
        /// </param>
        /// <param name="sessionId">
        /// The tracing project to evaluate.
        /// </param>
        /// <param name="datasetId">
        /// The dataset whose experiments to evaluate.
        /// </param>
        /// <param name="templateFormat">
        /// Default Value: mustache
        /// </param>
        /// <param name="variableMapping">
        /// Maps the prompt's variables to run fields.
        /// </param>
        /// <param name="provider">
        /// typesafe for Jev and SemIf, typesafe_compatible for a TypeSafe-compatible endpoint, or openai_decisions.<br/>
        /// Default Value: typesafe
        /// </param>
        /// <param name="model">
        /// Defaults to jev-latest for typesafe and gpt-6-luna for openai_decisions. Use semif-qwen3.5-4b for SemIf.
        /// </param>
        /// <param name="baseUrl">
        /// Call this endpoint directly instead of through the LangSmith gateway, with the workspace's TYPESAFE_API_KEY or OPENAI_API_KEY secret. Required for typesafe_compatible.
        /// </param>
        /// <param name="modelHeaders">
        /// Headers sent with each model call. They are saved in the evaluator's prompt as given, so do not put API keys here.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Seconds to wait for each model call. openai_decisions only.
        /// </param>
        /// <param name="maxRetries">
        /// How many times to retry a failed model call. openai_decisions only.
        /// </param>
        /// <param name="playgroundSettingsId">
        /// A saved model configuration to start from: its model, endpoint, key and settings apply unless set here.
        /// </param>
        /// <param name="samplingRate">
        /// The fraction of runs to evaluate.<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="filter">
        /// Only evaluate runs that match this filter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionModelRuleCreateSchema(
            string displayName,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> prompt,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.DecisionModelQuestion> questions,
            global::System.Guid? sessionId,
            global::System.Guid? datasetId,
            global::LangSmith.DecisionModelRuleCreateSchemaTemplateFormat? templateFormat,
            global::System.Collections.Generic.Dictionary<string, string>? variableMapping,
            global::LangSmith.DecisionModelRuleCreateSchemaProvider? provider,
            string? model,
            string? baseUrl,
            global::System.Collections.Generic.Dictionary<string, string>? modelHeaders,
            int? timeoutSeconds,
            int? maxRetries,
            global::System.Guid? playgroundSettingsId,
            double? samplingRate,
            string? filter)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.SessionId = sessionId;
            this.DatasetId = datasetId;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.TemplateFormat = templateFormat;
            this.VariableMapping = variableMapping;
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
            this.Provider = provider;
            this.Model = model;
            this.BaseUrl = baseUrl;
            this.ModelHeaders = modelHeaders;
            this.TimeoutSeconds = timeoutSeconds;
            this.MaxRetries = maxRetries;
            this.PlaygroundSettingsId = playgroundSettingsId;
            this.SamplingRate = samplingRate;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelRuleCreateSchema" /> class.
        /// </summary>
        public DecisionModelRuleCreateSchema()
        {
        }

    }
}