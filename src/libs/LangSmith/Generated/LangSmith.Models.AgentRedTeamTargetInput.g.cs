
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentRedTeamTargetInput
    {
        /// <summary>
        /// Headers are write-only and required unless clearing. An empty value<br/>
        /// keeps that header's saved value while the url is unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Kind is the protocol the endpoint speaks. Defaults to a2a.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgentRedTeamTargetInputKindJsonConverter))]
        public global::LangSmith.AgentRedTeamTargetInputKind? Kind { get; set; }

        /// <summary>
        /// OpenAPIOperations are the 1 to 10 operations probes may call on an<br/>
        /// openapi target, by operationId or as "METHOD /path". DELETE operations<br/>
        /// are not allowed. Required with a new spec; omit to keep the saved list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openapi_operations")]
        public global::System.Collections.Generic.IList<string>? OpenapiOperations { get; set; }

        /// <summary>
        /// OpenAPISpec is the endpoint's OpenAPI 3 document, for an openapi target.<br/>
        /// Omit it to keep the saved document while the url is unchanged. An<br/>
        /// openapi target cannot clear it with null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openapi_spec")]
        public object? OpenapiSpec { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRedTeamTargetInput" /> class.
        /// </summary>
        /// <param name="headers">
        /// Headers are write-only and required unless clearing. An empty value<br/>
        /// keeps that header's saved value while the url is unchanged.
        /// </param>
        /// <param name="kind">
        /// Kind is the protocol the endpoint speaks. Defaults to a2a.
        /// </param>
        /// <param name="openapiOperations">
        /// OpenAPIOperations are the 1 to 10 operations probes may call on an<br/>
        /// openapi target, by operationId or as "METHOD /path". DELETE operations<br/>
        /// are not allowed. Required with a new spec; omit to keep the saved list.
        /// </param>
        /// <param name="openapiSpec">
        /// OpenAPISpec is the endpoint's OpenAPI 3 document, for an openapi target.<br/>
        /// Omit it to keep the saved document while the url is unchanged. An<br/>
        /// openapi target cannot clear it with null.
        /// </param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRedTeamTargetInput(
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::LangSmith.AgentRedTeamTargetInputKind? kind,
            global::System.Collections.Generic.IList<string>? openapiOperations,
            object? openapiSpec,
            string? url)
        {
            this.Headers = headers;
            this.Kind = kind;
            this.OpenapiOperations = openapiOperations;
            this.OpenapiSpec = openapiSpec;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRedTeamTargetInput" /> class.
        /// </summary>
        public AgentRedTeamTargetInput()
        {
        }

    }
}