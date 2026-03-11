
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Represents an audit log message.
    /// </summary>
    public sealed partial class AuditLogMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string OperationName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ResourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_succeeded")]
        public bool? OperationSucceeded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime RequestTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string RequestMethod { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string RequestPath { get; set; } = default!;

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
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public global::System.Guid? ApiKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        public global::System.Guid? LsUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public global::System.Guid? OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_status_code")]
        public int? ResponseStatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogMessage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="operationName"></param>
        /// <param name="resourceIds"></param>
        /// <param name="operationSucceeded"></param>
        /// <param name="requestTime"></param>
        /// <param name="requestMethod"></param>
        /// <param name="requestPath"></param>
        /// <param name="clientHost"></param>
        /// <param name="clientPort"></param>
        /// <param name="xForwardedFor"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="userId"></param>
        /// <param name="lsUserId"></param>
        /// <param name="organizationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="responseStatusCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogMessage(
            global::System.Guid id,
            string operationName,
            global::System.DateTime requestTime,
            string requestMethod,
            string requestPath,
            global::System.Collections.Generic.IList<global::System.Guid>? resourceIds,
            bool? operationSucceeded,
            string? clientHost,
            int? clientPort,
            string? xForwardedFor,
            global::System.Guid? apiKeyId,
            global::System.Guid? userId,
            global::System.Guid? lsUserId,
            global::System.Guid? organizationId,
            global::System.Guid? workspaceId,
            int? responseStatusCode)
        {
            this.Id = id;
            this.OperationName = operationName ?? throw new global::System.ArgumentNullException(nameof(operationName));
            this.RequestTime = requestTime;
            this.RequestMethod = requestMethod ?? throw new global::System.ArgumentNullException(nameof(requestMethod));
            this.RequestPath = requestPath ?? throw new global::System.ArgumentNullException(nameof(requestPath));
            this.ResourceIds = resourceIds;
            this.OperationSucceeded = operationSucceeded;
            this.ClientHost = clientHost;
            this.ClientPort = clientPort;
            this.XForwardedFor = xForwardedFor;
            this.ApiKeyId = apiKeyId;
            this.UserId = userId;
            this.LsUserId = lsUserId;
            this.OrganizationId = organizationId;
            this.WorkspaceId = workspaceId;
            this.ResponseStatusCode = responseStatusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogMessage" /> class.
        /// </summary>
        public AuditLogMessage()
        {
        }
    }
}