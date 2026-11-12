
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RulesAlert
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoutingKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RulesAlertSeverityJsonConverter))]
        public global::LangSmith.RulesAlertSeverity? Severity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RulesAlertTypeJsonConverter))]
        public global::LangSmith.RulesAlertType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesAlert" /> class.
        /// </summary>
        /// <param name="routingKey"></param>
        /// <param name="severity"></param>
        /// <param name="summary"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RulesAlert(
            string routingKey,
            global::LangSmith.RulesAlertSeverity? severity,
            string? summary,
            global::LangSmith.RulesAlertType? type)
        {
            this.RoutingKey = routingKey ?? throw new global::System.ArgumentNullException(nameof(routingKey));
            this.Severity = severity;
            this.Summary = summary;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesAlert" /> class.
        /// </summary>
        public RulesAlert()
        {
        }

    }
}