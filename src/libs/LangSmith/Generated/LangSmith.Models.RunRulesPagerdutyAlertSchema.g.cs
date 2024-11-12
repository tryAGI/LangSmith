
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunRulesPagerdutyAlertSchema
    {
        /// <summary>
        /// Enum for alert types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RunRulesAlertTypeJsonConverter))]
        public global::LangSmith.RunRulesAlertType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoutingKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Enum for severity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.PagerdutySeverityJsonConverter))]
        public global::LangSmith.PagerdutySeverity? Severity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunRulesPagerdutyAlertSchema" /> class.
        /// </summary>
        /// <param name="type">
        /// Enum for alert types.
        /// </param>
        /// <param name="routingKey"></param>
        /// <param name="summary"></param>
        /// <param name="severity">
        /// Enum for severity.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunRulesPagerdutyAlertSchema(
            string routingKey,
            global::LangSmith.RunRulesAlertType? type,
            string? summary,
            global::LangSmith.PagerdutySeverity? severity)
        {
            this.RoutingKey = routingKey ?? throw new global::System.ArgumentNullException(nameof(routingKey));
            this.Type = type;
            this.Summary = summary;
            this.Severity = severity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunRulesPagerdutyAlertSchema" /> class.
        /// </summary>
        public RunRulesPagerdutyAlertSchema()
        {
        }
    }
}