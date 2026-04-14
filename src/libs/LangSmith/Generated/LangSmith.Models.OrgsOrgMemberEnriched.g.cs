
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsOrgMemberEnriched
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// auth-resolved display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// identity_id or pending_identity_id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// user disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_disabled")]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// true for pending invitations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_pending")]
        public bool? IsPending { get; set; }

        /// <summary>
        /// nil for pending members
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        public string? LsUserId { get; set; }

        /// <summary>
        /// org role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public string? RoleId { get; set; }

        /// <summary>
        /// org role name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_memberships")]
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsWorkspaceMembership>? WorkspaceMemberships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsOrgMemberEnriched" /> class.
        /// </summary>
        /// <param name="avatarUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="displayName">
        /// auth-resolved display name
        /// </param>
        /// <param name="email"></param>
        /// <param name="id">
        /// identity_id or pending_identity_id
        /// </param>
        /// <param name="isDisabled">
        /// user disabled
        /// </param>
        /// <param name="isPending">
        /// true for pending invitations
        /// </param>
        /// <param name="lsUserId">
        /// nil for pending members
        /// </param>
        /// <param name="roleId">
        /// org role
        /// </param>
        /// <param name="roleName">
        /// org role name
        /// </param>
        /// <param name="workspaceMemberships"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsOrgMemberEnriched(
            string? avatarUrl,
            string? createdAt,
            string? displayName,
            string? email,
            string? id,
            bool? isDisabled,
            bool? isPending,
            string? lsUserId,
            string? roleId,
            string? roleName,
            global::System.Collections.Generic.IList<global::LangSmith.OrgsWorkspaceMembership>? workspaceMemberships)
        {
            this.AvatarUrl = avatarUrl;
            this.CreatedAt = createdAt;
            this.DisplayName = displayName;
            this.Email = email;
            this.Id = id;
            this.IsDisabled = isDisabled;
            this.IsPending = isPending;
            this.LsUserId = lsUserId;
            this.RoleId = roleId;
            this.RoleName = roleName;
            this.WorkspaceMemberships = workspaceMemberships;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsOrgMemberEnriched" /> class.
        /// </summary>
        public OrgsOrgMemberEnriched()
        {
        }
    }
}