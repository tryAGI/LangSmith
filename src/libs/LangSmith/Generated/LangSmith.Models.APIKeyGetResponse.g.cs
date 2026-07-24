
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// API key GET schema.<br/>
    /// role_id, org_role_id, and access_scope let clients render the key's<br/>
    /// current role state without a second round trip. For workspace-scoped<br/>
    /// keys, org_role_id is null (the api_key's identity_id points at a<br/>
    /// workspace identity, so there is no caller-meaningful org role to surface).
    /// </summary>
    public sealed partial class APIKeyGetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShortKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_names")]
        public global::System.Collections.Generic.IList<string>? WorkspaceNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_workspace_name")]
        public string? DefaultWorkspaceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public global::System.Guid? RoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_role_id")]
        public global::System.Guid? OrgRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_scope")]
        public global::LangSmith.AccessScope? AccessScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyGetResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="shortKey"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUsedAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="workspaceNames"></param>
        /// <param name="defaultWorkspaceName"></param>
        /// <param name="roleId"></param>
        /// <param name="orgRoleId"></param>
        /// <param name="accessScope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIKeyGetResponse(
            global::System.Guid id,
            string shortKey,
            string description,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUsedAt,
            global::System.DateTime? expiresAt,
            global::System.Collections.Generic.IList<string>? workspaceNames,
            string? defaultWorkspaceName,
            global::System.Guid? roleId,
            global::System.Guid? orgRoleId,
            global::LangSmith.AccessScope? accessScope)
        {
            this.CreatedAt = createdAt;
            this.Id = id;
            this.ShortKey = shortKey ?? throw new global::System.ArgumentNullException(nameof(shortKey));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.LastUsedAt = lastUsedAt;
            this.ExpiresAt = expiresAt;
            this.WorkspaceNames = workspaceNames;
            this.DefaultWorkspaceName = defaultWorkspaceName;
            this.RoleId = roleId;
            this.OrgRoleId = orgRoleId;
            this.AccessScope = accessScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyGetResponse" /> class.
        /// </summary>
        public APIKeyGetResponse()
        {
        }

    }
}