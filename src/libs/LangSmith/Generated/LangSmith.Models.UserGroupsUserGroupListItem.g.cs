
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserGroupsUserGroupListItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idp_group_name")]
        public string? IdpGroupName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idp_sync_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IdpSyncEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrganizationId { get; set; }

        /// <summary>
        /// ParentUserGroupID is the organization-wide user group a workspace user group belongs to.<br/>
        /// It is omitted for organization-wide user groups.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_user_group_id")]
        public global::System.Guid? ParentUserGroupId { get; set; }

        /// <summary>
        /// RoleID is the role an organization scoped user group is granted in the workspace given by the<br/>
        /// workspace_id filter. It is omitted otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public global::System.Guid? RoleId { get; set; }

        /// <summary>
        /// RoleName is the display name of RoleID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// WorkspaceID is the workspace the user group belongs to. It is omitted for<br/>
        /// organization-wide user groups.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGroupsUserGroupListItem" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="idpSyncEnabled"></param>
        /// <param name="name"></param>
        /// <param name="organizationId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="idpGroupName"></param>
        /// <param name="parentUserGroupId">
        /// ParentUserGroupID is the organization-wide user group a workspace user group belongs to.<br/>
        /// It is omitted for organization-wide user groups.
        /// </param>
        /// <param name="roleId">
        /// RoleID is the role an organization scoped user group is granted in the workspace given by the<br/>
        /// workspace_id filter. It is omitted otherwise.
        /// </param>
        /// <param name="roleName">
        /// RoleName is the display name of RoleID.
        /// </param>
        /// <param name="workspaceId">
        /// WorkspaceID is the workspace the user group belongs to. It is omitted for<br/>
        /// organization-wide user groups.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGroupsUserGroupListItem(
            string createdAt,
            string description,
            global::System.Guid id,
            bool idpSyncEnabled,
            string name,
            global::System.Guid organizationId,
            string updatedAt,
            string? idpGroupName,
            global::System.Guid? parentUserGroupId,
            global::System.Guid? roleId,
            string? roleName,
            global::System.Guid? workspaceId)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Id = id;
            this.IdpGroupName = idpGroupName;
            this.IdpSyncEnabled = idpSyncEnabled;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrganizationId = organizationId;
            this.ParentUserGroupId = parentUserGroupId;
            this.RoleId = roleId;
            this.RoleName = roleName;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGroupsUserGroupListItem" /> class.
        /// </summary>
        public UserGroupsUserGroupListItem()
        {
        }

    }
}