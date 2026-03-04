
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Dimension values for a granular usage record.
    /// </summary>
    public sealed partial class GranularUsageDimensions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public global::System.Guid? ApiKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_short_key")]
        public string? ApiKeyShortKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_name")]
        public string? WorkspaceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GranularUsageDimensions" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="apiKeyShortKey"></param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="workspaceId"></param>
        /// <param name="workspaceName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GranularUsageDimensions(
            global::System.Guid? userId,
            string? userEmail,
            global::System.Guid? apiKeyId,
            string? apiKeyShortKey,
            global::System.Guid? projectId,
            string? projectName,
            global::System.Guid? workspaceId,
            string? workspaceName)
        {
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.ApiKeyId = apiKeyId;
            this.ApiKeyShortKey = apiKeyShortKey;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.WorkspaceId = workspaceId;
            this.WorkspaceName = workspaceName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GranularUsageDimensions" /> class.
        /// </summary>
        public GranularUsageDimensions()
        {
        }
    }
}