
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
            global::System.Collections.Generic.IList<string>? resourceIds)
        {
            this.RequestMethod = requestMethod;
            this.RequestPath = requestPath;
            this.ClientHost = clientHost;
            this.ClientPort = clientPort;
            this.XForwardedFor = xForwardedFor;
            this.ResponseStatusCode = responseStatusCode;
            this.ResourceIds = resourceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEnrichments" /> class.
        /// </summary>
        public AuditLogEnrichments()
        {
        }
    }
}