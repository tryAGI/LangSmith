
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// API key POST schema.<br/>
    /// expires_at: Optional datetime when the API key will expire.<br/>
    /// workspaces: List of workspace UUIDs this key can access (feature-flagged).<br/>
    /// role_id: Optional UUID of the role to assign to API key.<br/>
    ///     If not provided, uses default role based on read_only flag:<br/>
    ///     - WORKSPACE_ADMIN if read_only is False<br/>
    ///     - WORKSPACE_READER if read_only is True
    /// </summary>
    public sealed partial class APIKeyCreateRequest
    {
        /// <summary>
        /// Default Value: Default API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Workspaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public global::System.Guid? RoleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyCreateRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// Default Value: Default API key
        /// </param>
        /// <param name="readOnly">
        /// Default Value: false
        /// </param>
        /// <param name="expiresAt"></param>
        /// <param name="workspaces"></param>
        /// <param name="roleId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIKeyCreateRequest(
            string? description,
            bool? readOnly,
            global::System.DateTime? expiresAt,
            global::System.Collections.Generic.IList<global::System.Guid>? workspaces,
            global::System.Guid? roleId)
        {
            this.Description = description;
            this.ReadOnly = readOnly;
            this.ExpiresAt = expiresAt;
            this.Workspaces = workspaces;
            this.RoleId = roleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyCreateRequest" /> class.
        /// </summary>
        public APIKeyCreateRequest()
        {
        }
    }
}