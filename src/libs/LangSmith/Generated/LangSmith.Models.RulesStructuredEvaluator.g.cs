
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RulesStructuredEvaluator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hub_ref")]
        public string? HubRef { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public object? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playground_settings_id")]
        public string? PlaygroundSettingsId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_format")]
        public string? TemplateFormat { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable_mapping")]
        public global::System.Collections.Generic.Dictionary<string, string>? VariableMapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesStructuredEvaluator" /> class.
        /// </summary>
        /// <param name="hubRef"></param>
        /// <param name="model"></param>
        /// <param name="playgroundSettingsId"></param>
        /// <param name="prompt"></param>
        /// <param name="schema"></param>
        /// <param name="templateFormat"></param>
        /// <param name="variableMapping"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RulesStructuredEvaluator(
            string? hubRef,
            object? model,
            string? playgroundSettingsId,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? prompt,
            object? schema,
            string? templateFormat,
            global::System.Collections.Generic.Dictionary<string, string>? variableMapping)
        {
            this.HubRef = hubRef;
            this.Model = model;
            this.PlaygroundSettingsId = playgroundSettingsId;
            this.Prompt = prompt;
            this.Schema = schema;
            this.TemplateFormat = templateFormat;
            this.VariableMapping = variableMapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesStructuredEvaluator" /> class.
        /// </summary>
        public RulesStructuredEvaluator()
        {
        }

    }
}