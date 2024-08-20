
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RuleLogActionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RuleLogActionOutcomeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.RuleLogActionOutcome Outcome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::System.AnyOf<global::LangSmith.RuleLogActionResponsePayload, object>? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}