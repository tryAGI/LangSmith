
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Represents an audit log message.<br/>
    /// Indexed columns are individual DB columns. All other fields<br/>
    /// (request_method, request_path, client_host, etc.) live in the<br/>
    /// enrichments JSONB column.
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
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_succeeded")]
        public bool? OperationSucceeded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RequestTime { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("enrichments")]
        public global::LangSmith.AuditLogEnrichments? Enrichments { get; set; }

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
        /// <param name="requestTime"></param>
        /// <param name="operationSucceeded"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="userId"></param>
        /// <param name="lsUserId"></param>
        /// <param name="organizationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="enrichments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogMessage(
            global::System.Guid id,
            string operationName,
            global::System.DateTime requestTime,
            bool? operationSucceeded,
            global::System.Guid? apiKeyId,
            global::System.Guid? userId,
            global::System.Guid? lsUserId,
            global::System.Guid? organizationId,
            global::System.Guid? workspaceId,
            global::LangSmith.AuditLogEnrichments? enrichments)
        {
            this.Id = id;
            this.OperationName = operationName ?? throw new global::System.ArgumentNullException(nameof(operationName));
            this.OperationSucceeded = operationSucceeded;
            this.RequestTime = requestTime;
            this.ApiKeyId = apiKeyId;
            this.UserId = userId;
            this.LsUserId = lsUserId;
            this.OrganizationId = organizationId;
            this.WorkspaceId = workspaceId;
            this.Enrichments = enrichments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogMessage" /> class.
        /// </summary>
        public AuditLogMessage()
        {
        }
    }
}