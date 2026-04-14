
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsWorkspaceMembership
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public string? RoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

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
        /// Initializes a new instance of the <see cref="OrgsWorkspaceMembership" /> class.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="roleName"></param>
        /// <param name="workspaceId"></param>
        /// <param name="workspaceName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsWorkspaceMembership(
            string? roleId,
            string? roleName,
            string? workspaceId,
            string? workspaceName)
        {
            this.RoleId = roleId;
            this.RoleName = roleName;
            this.WorkspaceId = workspaceId;
            this.WorkspaceName = workspaceName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsWorkspaceMembership" /> class.
        /// </summary>
        public OrgsWorkspaceMembership()
        {
        }
    }
}