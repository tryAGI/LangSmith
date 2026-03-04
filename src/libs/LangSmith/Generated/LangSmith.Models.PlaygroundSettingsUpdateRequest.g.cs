
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaygroundSettingsUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public object? Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::LangSmith.PlaygroundSavedOptions? Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_in_playground")]
        public bool? AvailableInPlayground { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_in_evaluators")]
        public bool? AvailableInEvaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_in_agent_builder")]
        public bool? AvailableInAgentBuilder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_in_polly")]
        public bool? AvailableInPolly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_in_insights_heavy")]
        public bool? AvailableInInsightsHeavy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_in_insights_light")]
        public bool? AvailableInInsightsLight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSettingsUpdateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="settings"></param>
        /// <param name="options"></param>
        /// <param name="availableInPlayground"></param>
        /// <param name="availableInEvaluators"></param>
        /// <param name="availableInAgentBuilder"></param>
        /// <param name="availableInPolly"></param>
        /// <param name="availableInInsightsHeavy"></param>
        /// <param name="availableInInsightsLight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundSettingsUpdateRequest(
            string? name,
            string? description,
            object? settings,
            global::LangSmith.PlaygroundSavedOptions? options,
            bool? availableInPlayground,
            bool? availableInEvaluators,
            bool? availableInAgentBuilder,
            bool? availableInPolly,
            bool? availableInInsightsHeavy,
            bool? availableInInsightsLight)
        {
            this.Name = name;
            this.Description = description;
            this.Settings = settings;
            this.Options = options;
            this.AvailableInPlayground = availableInPlayground;
            this.AvailableInEvaluators = availableInEvaluators;
            this.AvailableInAgentBuilder = availableInAgentBuilder;
            this.AvailableInPolly = availableInPolly;
            this.AvailableInInsightsHeavy = availableInInsightsHeavy;
            this.AvailableInInsightsLight = availableInInsightsLight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSettingsUpdateRequest" /> class.
        /// </summary>
        public PlaygroundSettingsUpdateRequest()
        {
        }
    }
}