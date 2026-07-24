
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Response type for the batch workspace invite endpoint.<br/>
    /// Extends PendingIdentity so existing clients continue to work. When the<br/>
    /// invitee was already an active org member, ``ls_user_id`` is populated<br/>
    /// and ``email`` is filled from the request payload.
    /// </summary>
    public sealed partial class WorkspaceInviteResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public global::System.Guid? RoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? WorkspaceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_role_id")]
        public global::System.Guid? WorkspaceRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_role_name")]
        public string? WorkspaceRoleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// Default Value: workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AccessScopeJsonConverter))]
        public global::LangSmith.AccessScope? AccessScope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public global::System.Guid? TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public global::System.Guid? OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_role_id")]
        public global::System.Guid? OrgRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_role_name")]
        public string? OrgRoleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        public global::System.Guid? LsUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceInviteResult" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="roleId"></param>
        /// <param name="roleName"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="workspaceRoleId"></param>
        /// <param name="workspaceRoleName"></param>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="accessScope">
        /// Default Value: workspace
        /// </param>
        /// <param name="userId"></param>
        /// <param name="tenantId"></param>
        /// <param name="organizationId"></param>
        /// <param name="orgRoleId"></param>
        /// <param name="orgRoleName"></param>
        /// <param name="lsUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceInviteResult(
            string email,
            global::System.Guid id,
            global::System.DateTime createdAt,
            global::System.Guid? roleId,
            string? roleName,
            global::System.Collections.Generic.IList<global::System.Guid>? workspaceIds,
            global::System.Guid? workspaceRoleId,
            string? workspaceRoleName,
            string? password,
            string? fullName,
            global::LangSmith.AccessScope? accessScope,
            global::System.Guid? userId,
            global::System.Guid? tenantId,
            global::System.Guid? organizationId,
            global::System.Guid? orgRoleId,
            string? orgRoleName,
            global::System.Guid? lsUserId)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.RoleId = roleId;
            this.RoleName = roleName;
            this.WorkspaceIds = workspaceIds;
            this.WorkspaceRoleId = workspaceRoleId;
            this.WorkspaceRoleName = workspaceRoleName;
            this.Password = password;
            this.FullName = fullName;
            this.AccessScope = accessScope;
            this.Id = id;
            this.UserId = userId;
            this.TenantId = tenantId;
            this.OrganizationId = organizationId;
            this.CreatedAt = createdAt;
            this.OrgRoleId = orgRoleId;
            this.OrgRoleName = orgRoleName;
            this.LsUserId = lsUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceInviteResult" /> class.
        /// </summary>
        public WorkspaceInviteResult()
        {
        }

    }
}