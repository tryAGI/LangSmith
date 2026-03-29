
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaygroundSettingsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::LangSmith.PlaygroundSavedOptions? Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: complex
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.PlaygroundSettingsResponseSettingsTypeJsonConverter))]
        public global::LangSmith.PlaygroundSettingsResponseSettingsType? SettingsType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_ls_user_id")]
        public global::System.Guid? CreatedByLsUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by_ls_user_id")]
        public global::System.Guid? UpdatedByLsUserId { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_in_playground")]
        public bool? AvailableInPlayground { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_in_evaluators")]
        public bool? AvailableInEvaluators { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_in_agent_builder")]
        public bool? AvailableInAgentBuilder { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_in_polly")]
        public bool? AvailableInPolly { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_in_insights_heavy")]
        public bool? AvailableInInsightsHeavy { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_in_insights_light")]
        public bool? AvailableInInsightsLight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSettingsResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="options"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="settingsType">
        /// Default Value: complex
        /// </param>
        /// <param name="createdByLsUserId"></param>
        /// <param name="updatedByLsUserId"></param>
        /// <param name="availableInPlayground">
        /// Default Value: true
        /// </param>
        /// <param name="availableInEvaluators">
        /// Default Value: true
        /// </param>
        /// <param name="availableInAgentBuilder">
        /// Default Value: false
        /// </param>
        /// <param name="availableInPolly">
        /// Default Value: false
        /// </param>
        /// <param name="availableInInsightsHeavy">
        /// Default Value: false
        /// </param>
        /// <param name="availableInInsightsLight">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundSettingsResponse(
            global::System.Guid id,
            object settings,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::LangSmith.PlaygroundSavedOptions? options,
            string? name,
            string? description,
            global::LangSmith.PlaygroundSettingsResponseSettingsType? settingsType,
            global::System.Guid? createdByLsUserId,
            global::System.Guid? updatedByLsUserId,
            bool? availableInPlayground,
            bool? availableInEvaluators,
            bool? availableInAgentBuilder,
            bool? availableInPolly,
            bool? availableInInsightsHeavy,
            bool? availableInInsightsLight)
        {
            this.Id = id;
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
            this.Options = options;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Description = description;
            this.SettingsType = settingsType;
            this.CreatedByLsUserId = createdByLsUserId;
            this.UpdatedByLsUserId = updatedByLsUserId;
            this.AvailableInPlayground = availableInPlayground;
            this.AvailableInEvaluators = availableInEvaluators;
            this.AvailableInAgentBuilder = availableInAgentBuilder;
            this.AvailableInPolly = availableInPolly;
            this.AvailableInInsightsHeavy = availableInInsightsHeavy;
            this.AvailableInInsightsLight = availableInInsightsLight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSettingsResponse" /> class.
        /// </summary>
        public PlaygroundSettingsResponse()
        {
        }
    }
}