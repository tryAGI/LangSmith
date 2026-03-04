
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
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OperationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid>? ResourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_succeeded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool? OperationSucceeded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RequestTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ClientHost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_port")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? ClientPort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_forwarded_for")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? XForwardedFor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid? ApiKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid? LsUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid? OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? ResponseStatusCode { get; set; }

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
            global::System.Collections.Generic.IList<global::System.Guid>? resourceIds,
            bool? operationSucceeded,
            global::System.DateTime requestTime,
            string requestMethod,
            string requestPath,
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
            this.ResourceIds = resourceIds ?? throw new global::System.ArgumentNullException(nameof(resourceIds));
            this.OperationSucceeded = operationSucceeded;
            this.RequestTime = requestTime;
            this.RequestMethod = requestMethod ?? throw new global::System.ArgumentNullException(nameof(requestMethod));
            this.RequestPath = requestPath ?? throw new global::System.ArgumentNullException(nameof(requestPath));
            this.ClientHost = clientHost ?? throw new global::System.ArgumentNullException(nameof(clientHost));
            this.ClientPort = clientPort;
            this.XForwardedFor = xForwardedFor ?? throw new global::System.ArgumentNullException(nameof(xForwardedFor));
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