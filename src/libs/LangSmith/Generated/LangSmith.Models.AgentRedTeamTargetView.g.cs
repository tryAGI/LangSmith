
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentRedTeamTargetView
    {
        /// <summary>
        /// Auth describes the headers sent to this endpoint, and only to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public global::LangSmith.AgentTargetAuthStatus? Auth { get; set; }

        /// <summary>
        /// Kind is the protocol the endpoint speaks: an A2A agent, or an HTTP API<br/>
        /// described by an OpenAPI spec.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgentRedTeamTargetViewKindJsonConverter))]
        public global::LangSmith.AgentRedTeamTargetViewKind? Kind { get; set; }

        /// <summary>
        /// OpenAPIOperations are the operations probes may call on an OpenAPI<br/>
        /// target, by operationId or as "METHOD /path".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openapi_operations")]
        public global::System.Collections.Generic.IList<string>? OpenapiOperations { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentRedTeamTargetView" /> class.
        /// </summary>
        /// <param name="auth">
        /// Auth describes the headers sent to this endpoint, and only to it.
        /// </param>
        /// <param name="kind">
        /// Kind is the protocol the endpoint speaks: an A2A agent, or an HTTP API<br/>
        /// described by an OpenAPI spec.
        /// </param>
        /// <param name="openapiOperations">
        /// OpenAPIOperations are the operations probes may call on an OpenAPI<br/>
        /// target, by operationId or as "METHOD /path".
        /// </param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRedTeamTargetView(
            global::LangSmith.AgentTargetAuthStatus? auth,
            global::LangSmith.AgentRedTeamTargetViewKind? kind,
            global::System.Collections.Generic.IList<string>? openapiOperations,
            string? url)
        {
            this.Auth = auth;
            this.Kind = kind;
            this.OpenapiOperations = openapiOperations;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRedTeamTargetView" /> class.
        /// </summary>
        public AgentRedTeamTargetView()
        {
        }

    }
}