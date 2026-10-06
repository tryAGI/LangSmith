
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Non-indexed request metadata stored in the enrichments JSONB column.
    /// </summary>
    public sealed partial class AuditLogEnrichments
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_method")]
        public string? RequestMethod { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_path")]
        public string? RequestPath { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_host")]
        public string? ClientHost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_port")]
        public int? ClientPort { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_forwarded_for")]
        public string? XForwardedFor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_status_code")]
        public int? ResponseStatusCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_ids")]
        public global::System.Collections.Generic.IList<string>? ResourceIds { get; set; }

        /// <summary>
        /// LangSmith user ID of the member the resource belonged to, set when that is not the actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_owner_ls_user_id")]
        public string? ResourceOwnerLsUserId { get; set; }

        /// <summary>
        /// Sandbox that made the call under an access-delegation grant, set when the actor fields name its delegator rather than a user acting directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegated_from_sandbox_id")]
        public string? DelegatedFromSandboxId { get; set; }

        /// <summary>
        /// Time the server took to handle the request, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_milliseconds")]
        public int? DurationMilliseconds { get; set; }

        /// <summary>
        /// User-Agent header of the request, truncated to 256 bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_agent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// Tool the request invoked, as named by the caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        public string? ToolName { get; set; }

        /// <summary>
        /// LangSmith product that made the request, as reported by the caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller")]
        public string? Caller { get; set; }

        /// <summary>
        /// True when the invoked tool reported a failure inside a successful response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_tool_error")]
        public bool? IsToolError { get; set; }

        /// <summary>
        /// Managed Tools gateway the request went through.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gateway")]
        public global::LangSmith.AuditLogGateway? Gateway { get; set; }

        /// <summary>
        /// Server and tool a Managed Tools gateway routed the call to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream")]
        public global::LangSmith.AuditLogUpstream? Upstream { get; set; }

        /// <summary>
        /// Managed Tools MCP server the request reached.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public global::LangSmith.AuditLogServer? Server { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEnrichments" /> class.
        /// </summary>
        /// <param name="requestMethod"></param>
        /// <param name="requestPath"></param>
        /// <param name="clientHost"></param>
        /// <param name="clientPort"></param>
        /// <param name="xForwardedFor"></param>
        /// <param name="responseStatusCode"></param>
        /// <param name="resourceIds"></param>
        /// <param name="resourceOwnerLsUserId">
        /// LangSmith user ID of the member the resource belonged to, set when that is not the actor.
        /// </param>
        /// <param name="delegatedFromSandboxId">
        /// Sandbox that made the call under an access-delegation grant, set when the actor fields name its delegator rather than a user acting directly.
        /// </param>
        /// <param name="durationMilliseconds">
        /// Time the server took to handle the request, in milliseconds.
        /// </param>
        /// <param name="userAgent">
        /// User-Agent header of the request, truncated to 256 bytes.
        /// </param>
        /// <param name="toolName">
        /// Tool the request invoked, as named by the caller.
        /// </param>
        /// <param name="caller">
        /// LangSmith product that made the request, as reported by the caller.
        /// </param>
        /// <param name="isToolError">
        /// True when the invoked tool reported a failure inside a successful response.
        /// </param>
        /// <param name="gateway">
        /// Managed Tools gateway the request went through.
        /// </param>
        /// <param name="upstream">
        /// Server and tool a Managed Tools gateway routed the call to.
        /// </param>
        /// <param name="server">
        /// Managed Tools MCP server the request reached.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEnrichments(
            string? requestMethod,
            string? requestPath,
            string? clientHost,
            int? clientPort,
            string? xForwardedFor,
            int? responseStatusCode,
            global::System.Collections.Generic.IList<string>? resourceIds,
            string? resourceOwnerLsUserId,
            string? delegatedFromSandboxId,
            int? durationMilliseconds,
            string? userAgent,
            string? toolName,
            string? caller,
            bool? isToolError,
            global::LangSmith.AuditLogGateway? gateway,
            global::LangSmith.AuditLogUpstream? upstream,
            global::LangSmith.AuditLogServer? server)
        {
            this.RequestMethod = requestMethod;
            this.RequestPath = requestPath;
            this.ClientHost = clientHost;
            this.ClientPort = clientPort;
            this.XForwardedFor = xForwardedFor;
            this.ResponseStatusCode = responseStatusCode;
            this.ResourceIds = resourceIds;
            this.ResourceOwnerLsUserId = resourceOwnerLsUserId;
            this.DelegatedFromSandboxId = delegatedFromSandboxId;
            this.DurationMilliseconds = durationMilliseconds;
            this.UserAgent = userAgent;
            this.ToolName = toolName;
            this.Caller = caller;
            this.IsToolError = isToolError;
            this.Gateway = gateway;
            this.Upstream = upstream;
            this.Server = server;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEnrichments" /> class.
        /// </summary>
        public AuditLogEnrichments()
        {
        }

    }
}